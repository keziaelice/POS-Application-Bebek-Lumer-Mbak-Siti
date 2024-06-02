using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ALP_SAD_DBI
{
    public partial class Form_Home : Form
    {
        Form_Main form_Main = Application.OpenForms["form_Main"] as Form_Main;
        public Form_Home()
        {
            InitializeComponent();
            timer_second.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_second.Tick += updateDateTime;

            //panel_transparent.Size = new Size(1280, 590);
            //panel_transparent.Location = new Point(0, 0);
            //panel_transparent.BackColor = Color.FromArgb(175, 255, 255, 255);
            //panel_transparent.BorderStyle = BorderStyle.None;
            //panel_transparent.Parent = pb_bg;

            panel_header.Size = new Size(1280, 190);
            panel_header.Location = new Point(0, 0);
            panel_header.BackColor = Color.White;


            pb_rectangle_datetime.Location = new Point(935, pb_logo.Top + 15);

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

            label_home.Text = "HOME";
            label_home.Location = new Point(pb_logo.Left + 40, pb_logo.Bottom + 70);
            label_home.ForeColor = Color.FromArgb(255, 89, 89, 89);

            pb_logo.Size = new Size(500, 100);
            pb_logo.Location = new Point(0, 10);
            pb_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo.BorderStyle = BorderStyle.None;
            pb_logo.BackColor = Color.Transparent;

            pb_icon_service.Size = new Size(165, 165);
            pb_icon_service.Location = new Point(320, 135);
            pb_icon_service.SizeMode = PictureBoxSizeMode.Zoom;
            pb_icon_service.BorderStyle = BorderStyle.None;
            pb_icon_service.BackColor = Color.Transparent;
            pb_icon_service.Parent = pb_bg;

            //label_menu_service.Location = (pb_icon_service.Left + 50, 150);

            pb_icon_finance.Size = new Size(165, 165);
            pb_icon_finance.Location = new Point(pb_icon_service.Right + 75, 135);
            pb_icon_finance.SizeMode = PictureBoxSizeMode.Zoom;
            pb_icon_finance.BorderStyle = BorderStyle.None;
            pb_icon_finance.BackColor = Color.Transparent;
            pb_icon_finance.Parent = pb_bg;

            pb_icon_stock.Size = new Size(165, 165);
            pb_icon_stock.Location = new Point(pb_icon_finance.Right + 75, 135);
            pb_icon_stock.SizeMode = PictureBoxSizeMode.Zoom;
            pb_icon_stock.BorderStyle = BorderStyle.None;
            pb_icon_stock.BackColor = Color.Transparent;
            pb_icon_stock.Parent = pb_bg;

            //label_menu_service.Parent = pb_bg;
            label_menu_service.BackColor= Color.Transparent;
            label_menu_service.Location = new Point(pb_icon_service.Left + (pb_icon_service.Width / 2) - (label_menu_service.Width / 2),pb_icon_service.Bottom + 10);
            label_menu_service.Parent = pb_bg;
            label_menu_finance.BackColor = Color.Transparent;
            label_menu_finance.Location = new Point(pb_icon_finance.Left + (pb_icon_finance.Width / 2) - (label_menu_finance.Width / 2), pb_icon_finance.Bottom + 10);
            label_menu_finance.Parent = pb_bg;
            label_menu_stock.BackColor = Color.Transparent;
            label_menu_stock.Location = new Point(pb_icon_stock.Left + (pb_icon_stock.Width / 2) - (label_menu_stock.Width / 2), pb_icon_stock.Bottom + 10);
            label_menu_stock.Parent = pb_bg;
        }
        private void updateDateTime(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("HH : mm : ss");
            label_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
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

        private void pb_icon_service_Click(object sender, EventArgs e)
        {
            form_Main.panel_Container.Controls.Clear();
            Form_Service_1 form_Service_1 = new Form_Service_1();
            form_Service_1.Dock = DockStyle.Fill;
            form_Service_1.TopLevel = false;
            form_Service_1.ControlBox = false;
            form_Service_1.FormBorderStyle = FormBorderStyle.None;
            form_Main.panel_Container.Controls.Add(form_Service_1);
            form_Service_1.Show();
        }

        private void label_menu_service_Click(object sender, EventArgs e)
        {
            form_Main.panel_Container.Controls.Clear();
            Form_Service_1 form_Service_1 = new Form_Service_1();
            form_Service_1.Dock = DockStyle.Fill;
            form_Service_1.TopLevel = false;
            form_Service_1.ControlBox = false;
            form_Service_1.FormBorderStyle = FormBorderStyle.None;
            form_Main.panel_Container.Controls.Add(form_Service_1);
            form_Service_1.Show();
        }

        private void pb_icon_finance_Click(object sender, EventArgs e)
        {
            form_Main.panel_Container.Controls.Clear();
            FormFinance formFinance = new FormFinance();
            formFinance.Dock = DockStyle.Fill;
            formFinance.TopLevel = false;
            formFinance.ControlBox = false;
            formFinance.FormBorderStyle = FormBorderStyle.None;
            form_Main.panel_Container.Controls.Add(formFinance);
            formFinance.Show();
        }

        private void label_menu_finance_Click(object sender, EventArgs e)
        {
            form_Main.panel_Container.Controls.Clear();
            FormFinance formFinance = new FormFinance();
            formFinance.Dock = DockStyle.Fill;
            formFinance.TopLevel = false;
            formFinance.ControlBox = false;
            formFinance.FormBorderStyle = FormBorderStyle.None;
            form_Main.panel_Container.Controls.Add(formFinance);
            formFinance.Show();
        }

        private void pb_icon_stock_Click(object sender, EventArgs e)
        {
            form_Main.panel_Container.Controls.Clear();
            FormStock formStock = new FormStock();
            formStock.Dock = DockStyle.Fill;
            formStock.TopLevel = false;
            formStock.ControlBox = false;
            formStock.FormBorderStyle = FormBorderStyle.None;
            form_Main.panel_Container.Controls.Add(formStock);
            formStock.Show();
        }

        private void label_menu_stock_Click(object sender, EventArgs e)
        {
            form_Main.panel_Container.Controls.Clear();
            FormStock formStock = new FormStock();
            formStock.Dock = DockStyle.Fill;
            formStock.TopLevel = false;
            formStock.ControlBox = false;
            formStock.FormBorderStyle = FormBorderStyle.None;
            form_Main.panel_Container.Controls.Add(formStock);
            formStock.Show();
        }
    }
}
