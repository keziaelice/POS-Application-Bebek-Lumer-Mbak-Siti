using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_SAD_DBI
{
    public partial class FormInput : Form
    {
        FormStock form2stock;
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;
        MySqlDataReader sqlDataReader;

        DataTable dtmenu = new DataTable();
        DataTable dtharga = new DataTable();

        string connection;
        string sqlQuery;

        string nmbahan;
        int total;
        int newstock;

        Panel pnlsave = new Panel();
        Label lblnamabahan = new Label();
        Label jumlahbhn = new Label();
        Label jumlahhrg = new Label();
        TextBox txtjumlah = new TextBox();
        TextBox txtharga = new TextBox();
        ComboBox cbxmenu = new ComboBox();
        Label tglhariini = new Label();
        DateTimePicker pick = new DateTimePicker();
        Button update = new Button();

        PictureBox savepict = new PictureBox();
        PictureBox clearpict = new PictureBox();
        public FormInput(FormStock form1)
        {
            try
            {
                connection = "server=localhost;uid=root;pwd=root;database=SeCu";
                mysqlconnection = new MySqlConnection(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            InitializeComponent();
            this.form2stock = form1;
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            try
            {
                cbxmenu.Location = new Point(50, 50);
                cbxmenu.Size = new Size(190, 70);
                cbxmenu.BackColor = Color.Chocolate;
                cbxmenu.ForeColor = Color.White;
                cbxmenu.SelectionChangeCommitted += cbxmenu_SelectionChangeCommitted;
                this.Controls.Add(cbxmenu);

                dtmenu.Clear();
                sqlQuery = "SELECT b.nama_bahan, b.IDbahan\r\nFROM bahan b\r\norder by 1;";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtmenu);
                cbxmenu.DataSource = dtmenu;
                cbxmenu.DisplayMember = "nama_bahan";
                cbxmenu.ValueMember = "IDbahan";

                Label lbljumlah = new Label();
                lbljumlah.Location = new Point(50, 90);
                lbljumlah.Text = "Jumlah";
                lbljumlah.Size = new Size(150, 10);
                lbljumlah.AutoSize = false;
                lbljumlah.Font = new Font("Serif", 6, FontStyle.Regular);
                this.Controls.Add(lbljumlah);

                txtjumlah.Location = new Point(50, 105);
                txtjumlah.Size = new Size(190, 70);
                txtjumlah.KeyPress += Txtjumlah_KeyPress;
                this.Controls.Add(txtjumlah);

                Label lblharga = new Label();
                lblharga.Location = new Point(50, 140);
                lblharga.Text = "Harga";
                lblharga.Size = new Size(150, 10);
                lblharga.AutoSize = false;
                lblharga.Font = new Font("Serif", 6, FontStyle.Regular);
                this.Controls.Add(lblharga);

                txtharga.Location = new Point(50, 155);
                txtharga.Size = new Size(190, 70);
                txtharga.KeyPress += Txtharga_KeyPress;
                this.Controls.Add(txtharga);

                Label lbltgl = new Label();
                lbltgl.Location = new Point(50, 200);
                lbltgl.Size = new Size(150, 10);
                lbltgl.Text = "Tanggal Pembelian";
                lbltgl.AutoSize = false;
                lbltgl.Font = new Font("Serif", 6, FontStyle.Regular);
                this.Controls.Add(lbltgl);

                //Label tglhariini = new Label();
                tglhariini.Location = new Point(50, 220);
                tglhariini.Size = new Size(100, 40);
                tglhariini.Text = DateTime.Now.ToString();
                tglhariini.AutoSize = false;
                tglhariini.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                this.Controls.Add(tglhariini);

                pick.Location = new Point(170, 220);
                pick.Size = new Size(200, 50);
                pick.ValueChanged += Pick_ValueChanged;
                this.Controls.Add(pick);

                dtharga.Clear();
                sqlQuery = "SELECT harga_bahan\r\nFROM Bahan\r\nWHERE IDbahan = '" + cbxmenu.SelectedValue.ToString() + "';";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtharga);
                txtharga.Text = dtharga.Rows[0][0].ToString();

                update.Location = new Point(50, 280);
                update.Size = new Size(80, 30);
                update.BackColor = Color.AliceBlue;
                update.Text = "Update";
                update.Click += update_Click;
                this.Controls.Add(update);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txtharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Txtjumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void cbxmenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                txtjumlah.Text = "";
                nmbahan = "";
                total = 0;
                newstock = 0;

                dtharga.Clear();
                sqlQuery = "SELECT harga_bahan\r\nFROM Bahan\r\nWHERE IDbahan = '" + cbxmenu.SelectedValue.ToString() + "';";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtharga);
                txtharga.Text = dtharga.Rows[0][0].ToString();
                txtharga.Enabled = false;
                txtharga.BackColor = Color.White;

                nmbahan = cbxmenu.Text.ToString();
                total = newstock * Convert.ToInt32(dtharga.Rows[0][0].ToString());

                pnlsave.Location = new Point(400, 70);
                pnlsave.Size = new Size(400, 400);
                pnlsave.BackColor = Color.Chocolate;
                this.Controls.Add(pnlsave);

                lblnamabahan.Location = new Point(30, 30);
                lblnamabahan.Size = new Size(300, 20);
                lblnamabahan.Font = new Font("Serif", 10, FontStyle.Bold);
                lblnamabahan.Text = "Nama Bahan: " + nmbahan;
                lblnamabahan.ForeColor = Color.White;
                pnlsave.Controls.Add(lblnamabahan);

                jumlahbhn.Location = new Point(30, 60);
                jumlahbhn.Size = new Size(300, 20);
                jumlahbhn.Font = new Font("Serif", 10, FontStyle.Bold);
                jumlahbhn.Text = "Jumlah: " + newstock;
                jumlahbhn.ForeColor = Color.White;
                pnlsave.Controls.Add(jumlahbhn);

                jumlahhrg.Location = new Point(30, 90);
                jumlahhrg.Size = new Size(300, 20);
                jumlahhrg.Font = new Font("Serif", 10, FontStyle.Bold);
                jumlahhrg.Text = "Jumlah Harga: Rp " + total + ",-";
                jumlahhrg.ForeColor = Color.White;
                pnlsave.Controls.Add(jumlahhrg);

                savepict.Image = Image.FromFile($@"picture\save.png");
                savepict.Location = new Point(30, 130);
                savepict.Size = new Size(70, 20);
                savepict.SizeMode = PictureBoxSizeMode.StretchImage;
                savepict.BringToFront();
                savepict.Click += save_Click;
                pnlsave.Controls.Add(savepict);

                clearpict.Image = Image.FromFile($@"picture\clear.png");
                clearpict.Location = new Point(140, 130);
                clearpict.Size = new Size(70, 20);
                clearpict.SizeMode = PictureBoxSizeMode.StretchImage;
                clearpict.BringToFront();
                clearpict.Click += clear_Click;
                pnlsave.Controls.Add(clearpict);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pick_ValueChanged(object sender, EventArgs e)
        {
            tglhariini.Text = pick.Value.ToString();
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtjumlah.Text == "")
                {
                    MessageBox.Show("Silahkan mengisi jumlah stok yang ingin diinput", "! Peringatan !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    newstock = Convert.ToInt32(txtjumlah.Text.ToString());
                    sqlQuery = "UPDATE Bahan\r\nSET stok = stok + '" + newstock + "'\r\nWHERE IDbahan = '" + cbxmenu.SelectedValue.ToString() + "';";
                    mysqlconnection = new MySqlConnection(connection);
                    mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                    mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                    mysqlconnection.Open();
                    mysqlcommand.ExecuteNonQuery();
                    MessageBox.Show("Stock berhasil disimpan", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            try
            {
                nmbahan = "";
                lblnamabahan.Text = "Nama Bahan: " + nmbahan;
                newstock = 0;
                jumlahbhn.Text = "Jumlah: " + newstock;
                total = 0;
                jumlahhrg.Text = "Jumlah Harga: Rp " + total + ",-";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtjumlah.Text == "")
                {
                    MessageBox.Show("Silahkan input jumlah stok", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    newstock = Convert.ToInt32(txtjumlah.Text);
                    total = newstock * Convert.ToInt32(dtharga.Rows[0][0].ToString());
                    lblnamabahan.Text = "Nama Bahan: " + nmbahan;
                    jumlahbhn.Text = "Jumlah: " + newstock;
                    jumlahhrg.Text = "Jumlah Harga: Rp " + total + ",-";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
