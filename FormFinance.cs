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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ALP_SAD_DBI
{
    public partial class FormFinance : Form
    {
        Form_Main form_Main = Application.OpenForms["form_Main"] as Form_Main;
        Form_Home form_Home = Application.OpenForms["form_Home"] as Form_Home;
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;

        string connection;
        string sqlQuery;

        DataGridView dgvbahan = new DataGridView();
        ComboBox choose = new ComboBox();

        DataTable dtfinance = new DataTable();
        DataTable dtbulanan = new DataTable();
        DataTable dtharian = new DataTable();
        public FormFinance()
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
            timer_second.Start();
        }

        private void FormFinance_Load(object sender, EventArgs e)
        {
            timer_second.Tick += updateDateTime;

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

            pb_bg.Size = new Size(1280, 590);
            pb_bg.Location = new Point(0, 190);
            pb_bg.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_bg.BorderStyle = BorderStyle.None;

            label_finance.Location = new Point(pb_logo.Left + 40, pb_logo.Bottom + 70);
            label_finance.ForeColor = Color.FromArgb(255, 89, 89, 89);

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

            panel_container.Size = new Size(pb_bg.Width, pb_bg.Height);
            panel_container.Location = new Point(0, 0);
            panel_container.Parent = pb_bg;
            panel_container.BackColor = Color.Transparent;

            choose.Location = new Point(50, 50);
            choose.Size = new Size(300, 70);
            choose.Items.Add("Bulanan");
            choose.Items.Add("Harian");
            choose.Font = new Font("Montserrat", 12);
            choose.Click += choose_SelectionChangeCommitted;
            this.panel_container.Controls.Add(choose);

            Button search = new Button();
            search.Location = new Point(choose.Right + 5, choose.Top);
            search.Text = "Search";
            search.Font = new Font("Montserrat", 12);
            search.Size = new Size(150, 30);
            this.panel_container.Controls.Add(search);
            search.Click += search_Click;

            dgvbahan.Location = new Point(choose.Left, choose.Bottom + 25);
            dgvbahan.Size = new Size(1170, 370);
            dgvbahan.Anchor = AnchorStyles.Right;
            dgvbahan.Font = new Font("Montserrat", 12);
            dgvbahan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvbahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.panel_container.Controls.Add(dgvbahan);

            dtfinance.Clear();
            sqlQuery = "SELECT *\r\nFROM Pembukuan\r\norder by 1;";
            mysqlconnection = new MySqlConnection(connection);
            mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
            mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
            mysqldataadapter.Fill(dtfinance);
            dgvbahan.DataSource = dtfinance;
            dgvbahan.EnableHeadersVisualStyles = false;
            dgvbahan.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate;
            dgvbahan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvbahan.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            dgvbahan.ColumnHeadersHeight = 50;

            dgvbahan.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            dgvbahan.RowHeadersWidth = 80;

        }
        private void choose_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //if (choose.SelectedText.ToString() == "Bulanan")
            //{
            //    //dgvbahan.Rows.Clear();
            //    //dtbulanan.Clear();
            //    dtbulanan = new DataTable();
            //    sqlQuery = "SELECT * FROM pembukuan WHERE substring(IDTransaksi, 4, 2) = substring(date_format(curdate(), '%d%m%y'),3,2);";
            //    mysqlconnection = new MySqlConnection(connection);
            //    mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
            //    mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
            //    mysqldataadapter.Fill(dtbulanan);
            //    dgvbahan.DataSource = dtbulanan;
            //}
            //else if (choose.SelectedText.ToString() == "Harian")
            //{
            //    //dgvbahan.Rows.Clear();
            //    //dtharian.Clear();
            //    dtharian = new DataTable();
            //    sqlQuery = "SELECT * FROM pembukuan WHERE substring(IDTransaksi, 2, 6) = date_format(curdate(), '%d%m%y');";
            //    mysqlconnection = new MySqlConnection(connection);
            //    mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
            //    mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
            //    mysqldataadapter.Fill(dtharian);
            //    dgvbahan.DataSource = dtharian;
            //}
        }
        private void updateDateTime(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("HH : mm : ss");
            label_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
        private void search_Click(object sender, EventArgs e)
        {
            if (choose.Text.ToString() == "Bulanan")
            {
                //dgvbahan.Rows.Clear();
                //dtbulanan.Clear();
                dtbulanan = new DataTable();
                sqlQuery = "SELECT * FROM pembukuan WHERE substring(IDTransaksi, 4, 2) = substring(date_format(curdate(), '%d%m%y'),3,2);";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtbulanan);
                dgvbahan.DataSource = dtbulanan;
            }
            else if (choose.Text.ToString() == "Harian")
            {
                //dgvbahan.Rows.Clear();
                //dtharian.Clear();
                dtharian = new DataTable();
                sqlQuery = "SELECT * FROM pembukuan WHERE substring(IDTransaksi, 2, 6) = date_format(curdate(), '%d%m%y');";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtharian);
                dgvbahan.DataSource = dtharian;
            }
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
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
    }
}