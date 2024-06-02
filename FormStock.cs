using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ALP_SAD_DBI
{
    public partial class FormStock : Form
    {
        Form_Main form_Main = Application.OpenForms["form_Main"] as Form_Main;
        Form_Home form_Home = Application.OpenForms["form_Home"] as Form_Home;
        public FormStock()
        {
            try
            {
                form_Main.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=secu");
                form_Main.sqlConnect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
        }
        Panel panelstock = new Panel();
        Guna2Panel panelKanan = new Guna2Panel();

        PictureBox buttoninput = new PictureBox();
        PictureBox stockopname = new PictureBox();

        DataTable dtbahan = new DataTable();

        private void FormStock_Load(object sender, EventArgs e)
        {
            timer_second.Start();
            timer_second.Tick += updateDateTime;

            this.BackColor = Color.White;
            this.Size = new Size(1280, 720);

            label_service.Location = new Point(pb_logo.Left + 40, pb_logo.Bottom + 70);
            label_service.ForeColor = Color.FromArgb(255, 89, 89, 89);
            label_service.Text = "STOCK";

            guna2Panel1.Size = new Size(pb_bg.Width, pb_bg.Height + 100);
            guna2Panel1.Location = new Point(0, 80);
            //guna2Panel1.Parent = pb_bg;

            panel_header.Size = new Size(1280, 190);
            panel_header.Location = new Point(0, 0);
            panel_header.BackColor = Color.White;

            pb_rectangle_datetime.Location = new Point(882, pb_logo.Top + 15);

            label_time.Text = DateTime.Now.ToString("HH:mm:ss");
            label_time.Location = new Point(pb_rectangle_datetime.Left + 40, pb_rectangle_datetime.Top + 5);
            label_time.BackColor = Color.FromArgb(255, 133, 70, 24);
            label_time.ForeColor = Color.White;

            label_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
            label_date.Location = new Point(label_time.Right + 18, pb_rectangle_datetime.Top + 5);
            label_date.BackColor = Color.FromArgb(255, 133, 70, 24);
            label_date.ForeColor = Color.White;

            pb_button_logout.BackColor = Color.FromArgb(255, 133, 70, 24);
            pb_button_logout.Location = new Point(pb_rectangle_datetime.Right - 120, pb_rectangle_datetime.Top + 1);

            pb_bg.Size = new Size(1280, 790);
            pb_bg.Location = new Point(0, 80);
            pb_bg.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_bg.BorderStyle = BorderStyle.None;

            pb_logo.Size = new Size(500, 100);
            pb_logo.Location = new Point(0, 10);
            pb_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo.BorderStyle = BorderStyle.None;
            pb_logo.BackColor = Color.Transparent;

            pb_icon_home.Location = new Point(pb_rectangle_datetime.Right - 27, pb_rectangle_datetime.Top);
            pb_icon_home.BorderStyle = BorderStyle.None;
            pb_icon_home.Size = new Size(30, pb_rectangle_datetime.Height);

            pb_icon_back.Location = new Point(pb_rectangle_datetime.Right + 2, pb_rectangle_datetime.Top);
            pb_icon_back.BorderStyle = BorderStyle.None;
            pb_icon_back.Size = new Size(30, pb_rectangle_datetime.Height);

            panelstock.BackColor = Color.DarkGray;
            panelstock.Location = new Point(0, 0);
            panelstock.Size = new Size(250, 720);
            panelstock.BorderStyle = BorderStyle.FixedSingle;
            guna2Panel1.Controls.Add(panelstock);

            panel_header.Location = new Point(0, 0);
            panel_header.Size = new Size(1320, 80);
            panel_header.Anchor = AnchorStyles.Top;
            this.Controls.Add(panel_header);

            PictureBox stock = new PictureBox();
            stock.Image = Image.FromFile($@"picture\logostock.png");
            stock.Location = new Point(10, 90);
            stock.Size = new Size(222, 304);
            stock.SizeMode = PictureBoxSizeMode.Zoom;
            panelstock.Controls.Add(stock);

            buttoninput.Image = Image.FromFile($@"picture\inputstock.png");
            buttoninput.Location = new Point(40, 400);
            buttoninput.Size = new Size(170, 45);
            buttoninput.SizeMode = PictureBoxSizeMode.Zoom;
            buttoninput.BringToFront();
            buttoninput.Click += Input_Click;
            panelstock.Controls.Add(buttoninput);
            buttoninput.BringToFront();

            stockopname.Image = Image.FromFile($@"picture\stockopname.png");
            stockopname.Location = new Point(40, 470);
            stockopname.Size = new Size(170, 45);
            stockopname.SizeMode = PictureBoxSizeMode.Zoom;
            stockopname.Click += StockOpname_Click;
            panelstock.Controls.Add(stockopname);
            stockopname.BringToFront();

            panelKanan.BackColor = Color.Transparent;
            panelKanan.Location = new Point(300, 50);
            panelKanan.Size = new Size(1720, 1043);
            panelKanan.Anchor = AnchorStyles.Left;
            guna2Panel1.Controls.Add(panelKanan);

            DataGridView dgvbahan = new DataGridView();
            dgvbahan.Location = new Point(120, 30);
            dgvbahan.Size = new Size(605, 400);
            dgvbahan.Anchor = AnchorStyles.Right;
            panelKanan.Controls.Add(dgvbahan);

            dtbahan.Clear();
            form_Main.sqlQuery = "SELECT *\r\nFROM bahan b\r\norder by 1;";
            //mysqlconnection = new MySqlConnection(connection);
            form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
            form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
            form_Main.sqlAdapter.Fill(dtbahan);
            dgvbahan.DataSource = dtbahan;
            dgvbahan.EnableHeadersVisualStyles = false;
            dgvbahan.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate;
            dgvbahan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dgvbahan.RowsDefaultCellStyle.BackColor = Color.Coral;
            //dgvbahan.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvbahan.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            dgvbahan.ColumnHeadersHeight = 50;

            dgvbahan.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            dgvbahan.RowHeadersWidth = 88;
        }
        private void Input_Click(object sender, EventArgs e)
        {
            this.panelKanan.Controls.Clear();
            FormInput input = new FormInput(this);
            input.Dock = DockStyle.Fill;
            input.TopLevel = false;
            this.panelKanan.Controls.Add(input);
            input.Show();
            stockopname.Image = Image.FromFile($@"picture\stockopname.png");
            buttoninput.Image = Image.FromFile($@"picture\inputorange.png");
        }
        private void StockOpname_Click(object sender, EventArgs e)
        {
            this.panelKanan.Controls.Clear();
            buttoninput.Image = Image.FromFile($@"picture\inputstock.png");
            stockopname.Image = Image.FromFile($@"picture\opnameorange.png");
            FormOpname opname = new FormOpname(this);
            opname.Dock = DockStyle.Fill;
            opname.TopLevel = false;
            this.panelKanan.Controls.Add(opname);
            opname.Show();
        }
        private void updateDateTime(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("HH : mm : ss");
            label_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
        private void label_service_Click(object sender, EventArgs e)
        {

        }
        private void pb_button_logout_Click(object sender, EventArgs e)
        {

            form_Main.panel_Container.Controls.Clear();
            Form_Login form_login = new Form_Login();
            form_login.Dock = DockStyle.Fill;
            form_login.TopLevel = false;
            form_login.ControlBox = false;
            form_login.FormBorderStyle = FormBorderStyle.None;
            form_Main.panel_Container.Controls.Add(form_login);
            form_login.Show();
        }
        private void pb_icon_home_Click(object sender, EventArgs e)
        {
            form_Main.panel_Container.Controls.Clear();
            form_Main.panel_Container.Controls.Add(form_Home);
            form_Home.Show();
        }

        private void pb_icon_back_Click(object sender, EventArgs e)
        {
            form_Main.panel_Container.Controls.Clear();
            form_Main.panel_Container.Controls.Add(form_Home);
            form_Home.Show();
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
