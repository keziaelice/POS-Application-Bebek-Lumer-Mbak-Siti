using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_SAD_DBI
{
    public partial class FormOpname : Form
    {
        FormStock form2opname;
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;
        MySqlDataReader sqlDataReader;

        string connection;
        string sqlQuery;

        DataTable dtbahan = new DataTable();
        DataTable dtjumlah = new DataTable();

        PictureBox pictbahan = new PictureBox();
        ComboBox cbxbahan = new ComboBox();
        Label jmlstok = new Label();
        TextBox txtjmlstok = new TextBox();
        Label jmlasli = new Label();
        TextBox txtjmlasli = new TextBox();
        Label alasan = new Label();
        TextBox txtalsn = new TextBox();

        PictureBox save = new PictureBox();
        PictureBox clear = new PictureBox();
        public FormOpname(FormStock form2)
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
            this.form2opname = form2;
        }

        private void FormOpname_Load(object sender, EventArgs e)
        {
            pictbahan.Image = Image.FromFile($@"picture\bahan.png");
            pictbahan.Location = new Point(70, 70);
            pictbahan.Size = new Size(300, 40);
            pictbahan.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictbahan);

            cbxbahan.Location = new Point(120, 120);
            cbxbahan.Size = new Size(150, 40);
            cbxbahan.BackColor = Color.Chocolate;
            cbxbahan.ForeColor = Color.White;
            cbxbahan.BringToFront();
            cbxbahan.SelectionChangeCommitted += cbxbahan_SelectionChangeCommitted;
            this.Controls.Add(cbxbahan);

            dtbahan.Clear();
            sqlQuery = "SELECT b.nama_bahan, b.IDbahan\r\nFROM bahan b\r\norder by 1;";
            mysqlconnection = new MySqlConnection(connection);
            mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
            mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
            mysqldataadapter.Fill(dtbahan);
            cbxbahan.DataSource = dtbahan;
            cbxbahan.DisplayMember = "nama_bahan";
            cbxbahan.ValueMember = "IDbahan";
        }
        private void cbxbahan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            jmlstok.Location = new Point(70, 170);
            jmlstok.Size = new Size(150, 20);
            jmlstok.Text = "Jumlah Stok";
            jmlstok.AutoSize = false;
            jmlstok.Font = new Font("Serif", 8, FontStyle.Regular);
            this.Controls.Add(jmlstok);

            txtjmlstok.Location = new Point(70, 190);
            txtjmlstok.Size = new Size(190, 70);
            txtjmlstok.KeyPress += Txtjmlstok_KeyPress;
            this.Controls.Add(txtjmlstok);

            dtjumlah.Clear();
            sqlQuery = "SELECT stok\r\nFROM Bahan\r\nWHERE IDbahan = '" + cbxbahan.SelectedValue.ToString() + "';";
            mysqlconnection = new MySqlConnection(connection);
            mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
            mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
            mysqldataadapter.Fill(dtjumlah);
            txtjmlstok.Text = dtjumlah.Rows[0][0].ToString();
            txtjmlstok.Enabled = false;
            txtjmlstok.BackColor = Color.White;

            jmlasli.Location = new Point(70, 230);
            jmlasli.Size = new Size(150, 20);
            jmlasli.Text = "Jumlah Sesungguhnya";
            jmlasli.AutoSize = false;
            jmlasli.Font = new Font("Serif", 8, FontStyle.Regular);
            this.Controls.Add(jmlasli);

            txtjmlasli.Location = new Point(70, 250);
            txtjmlasli.Size = new Size(190, 70);
            txtjmlasli.KeyPress += Txtjmlasli_KeyPress;
            this.Controls.Add(txtjmlasli);

            alasan.Location = new Point(70, 290);
            alasan.Size = new Size(150, 20);
            alasan.Text = "Alasan";
            alasan.AutoSize = false;
            alasan.Font = new Font("Serif", 8, FontStyle.Regular);
            this.Controls.Add(alasan);

            txtalsn.Location = new Point(70, 310);
            txtalsn.Size = new Size(190, 70);
            this.Controls.Add(txtalsn);

            save.Image = Image.FromFile($@"picture\save.png");
            save.Location = new Point(70, 350);
            save.Size = new Size(70, 20);
            save.SizeMode = PictureBoxSizeMode.StretchImage;
            save.BringToFront();
            save.Click += save_Click;
            this.Controls.Add(save);

            clear.Image = Image.FromFile($@"picture\clear.png");
            clear.Location = new Point(160, 350);
            clear.Size = new Size(70, 20);
            clear.SizeMode = PictureBoxSizeMode.StretchImage;
            clear.BringToFront();
            clear.Click += clear_Click;
            this.Controls.Add(clear);
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtjmlasli.Text.ToString() == "" || txtalsn.Text.ToString() == "")
                {
                    MessageBox.Show("Silahkan input jumlah dan keterangan", "!PERINGATAN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sqlQuery = "UPDATE Bahan\r\nSET stok = '" + Convert.ToInt32(txtjmlasli.Text) + "'\r\nWHERE IDbahan = '" + cbxbahan.SelectedValue.ToString() + "';";
                    mysqlconnection = new MySqlConnection(connection);
                    mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                    mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                    mysqlconnection.Open();
                    mysqlcommand.ExecuteNonQuery();
                    MessageBox.Show("Stock berhasil diubah", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtjmlasli.Text = "";
                txtjmlstok.Text = "";
                txtalsn.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Txtjmlstok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Txtjmlasli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
