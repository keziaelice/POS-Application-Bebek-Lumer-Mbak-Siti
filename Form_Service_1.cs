using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ALP_SAD_DBI
{
    public partial class Form_Service_1 : Form
    {
        Form_Main form_Main = Application.OpenForms["form_Main"] as Form_Main;
        Form_Home form_Home = Application.OpenForms["form_Home"] as Form_Home;
        //Panel panel_listmenu = new Panel();
        public Form_Service_1()
        {
            InitializeComponent();
            timer_second.Start();
        }

        private void Form_Service_1_Load(object sender, EventArgs e)
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

            label_service.Location = new Point(pb_logo.Left + 40, pb_logo.Bottom + 70);
            label_service.ForeColor = Color.FromArgb(255, 89, 89, 89);

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

            pb_menu_makeorder.Size = new Size(140, label_service.Height);
            pb_menu_makeorder.Location = new Point(label_service.Right + 5, label_service.Top + 4);
            pb_menu_makeorder.BorderStyle = BorderStyle.None;
            label_menu_makeorder.AutoSize = false;
            label_menu_makeorder.Size = new Size(pb_menu_makeorder.Width - 6, 25);
            label_menu_makeorder.Location = new Point(pb_menu_makeorder.Left + 3, label_service.Top + 24);
            label_menu_makeorder.TextAlign = ContentAlignment.MiddleCenter;
            label_menu_makeorder.BackColor = Color.FromArgb(255, 133, 70, 24);
            label_menu_makeorder.ForeColor = Color.White;
            label_menu_makeorder.BorderStyle = BorderStyle.None;

            pb_menu_payment.Size = new Size(140, label_service.Height);
            pb_menu_payment.Location = new Point(pb_menu_makeorder.Right + 10, label_service.Top + 4);
            label_menu_payment.AutoSize = false;
            label_menu_payment.Size = new Size(pb_menu_payment.Width - 6, 25);
            label_menu_payment.Location = new Point(pb_menu_payment.Left + 3, label_service.Top + 24);
            label_menu_payment.TextAlign = ContentAlignment.MiddleCenter;
            label_menu_payment.BackColor = Color.FromArgb(255, 133, 70, 24);
            label_menu_payment.ForeColor = Color.White;

            pb_menu_checkorder.Size = new Size(140, label_service.Height);
            pb_menu_checkorder.Location = new Point(pb_menu_payment.Right + 10, label_service.Top + 4);
            label_menu_checkorder.AutoSize = false;
            label_menu_checkorder.Size = new Size(pb_menu_checkorder.Width - 6, 25);
            label_menu_checkorder.Location = new Point(pb_menu_checkorder.Left + 3, label_service.Top + 24);
            label_menu_checkorder.TextAlign = ContentAlignment.MiddleCenter;
            label_menu_checkorder.BackColor = Color.FromArgb(255, 133, 70, 24);
            label_menu_checkorder.ForeColor = Color.White;

            panel_container.Size = new Size(pb_bg.Width, pb_bg.Height);
            panel_container.Location = new Point(0, 0);
            panel_container.Parent = pb_bg;
            panel_container.BackColor = Color.Transparent;
            //panel_container.BackgroundImage = Image.FromFile($@"resources\K_bg.png");

            //pb_menu_food.Size = new Size(80, 35);
            //pb_menu_food.Location = new Point(label_service.Left, 40);
            //pb_menu_food.BorderStyle = BorderStyle.None;
            //pb_menu_beverage.Size = new Size(110, 35);
            //pb_menu_beverage.Location = new Point(pb_menu_food.Right - 5, 40);
            //pb_menu_beverage.BorderStyle = BorderStyle.None;

            //tb_customername.Location = new Point(pb_menu_beverage.Right + 18, pb_menu_beverage.Top + 7);
            //label_customername.Location = new Point(tb_customername.Left, pb_menu_beverage.Top - 11);

            //panel_listmenu.BorderStyle = BorderStyle.FixedSingle;
            //panel_listmenu.Location = new Point(312, 300);
            //panel_listmenu.Size = new Size(1000, 500);
            //this.Controls.Add(panel_listmenu);
            //panel_listmenu.Parent = pb_bg;
            //panel_listmenu.BackColor = Color.Transparent;
            //panel_listmenu.BringToFront();

            //Guna2PictureBox pbcb = new Guna2PictureBox();
            //pbcb.Location = new Point(50, 200);
            //pbcb.Size = new Size(100, 100);
            //pbcb.Parent = panel_container;
            //pbcb.UseTransparentBackground = true;
            //pbcb.BorderRadius = 10;
            //pbcb.Image = Image.FromFile($@"resources\K_picture_menu_A0001.jpg");
            //pbcb.SizeMode = PictureBoxSizeMode.Zoom;
            //this.Controls.Add(pbcb);
            //pbcb.BringToFront();
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

        private void menu_makeorder_Click(object sender, EventArgs e)
        {
            this.pb_menu_makeorder.Image = Image.FromFile($@"resources\K_rectangle_menu_clicked.png");
            //this.pb_menu_makeorder.SizeMode = PictureBoxSizeMode.Zoom;
            //this.pb_menu_makeorder.BorderStyle = BorderStyle.None;
            this.label_menu_makeorder.BackColor = Color.FromArgb(255, 208, 132, 76); 
            this.pb_menu_payment.Image = Image.FromFile($@"resources\K_rectangle_menu.png");
            this.label_menu_payment.BackColor = Color.FromArgb(255, 133, 70, 24);
            this.pb_menu_checkorder.Image = Image.FromFile($@"resources\K_rectangle_menu.png");
            this.label_menu_checkorder.BackColor = Color.FromArgb(255, 133, 70, 24);

            this.panel_container.Controls.Clear();
            Form_Service_MakeOrder_1 form_Service_MakeOrder_1 = new Form_Service_MakeOrder_1();
            form_Service_MakeOrder_1.Dock = DockStyle.Fill;
            form_Service_MakeOrder_1.TopLevel = false;
            form_Service_MakeOrder_1.ControlBox = false;
            form_Service_MakeOrder_1.FormBorderStyle = FormBorderStyle.None;
            this.panel_container.Controls.Add(form_Service_MakeOrder_1);
            form_Service_MakeOrder_1.Show();
        }

        private void menu_payment_Click(object sender, EventArgs e)
        {
            this.pb_menu_payment.Image = Image.FromFile($@"resources\K_rectangle_menu_clicked.png");
            this.label_menu_payment.BackColor = Color.FromArgb(255, 208, 132, 76);
            this.pb_menu_makeorder.Image = Image.FromFile($@"resources\K_rectangle_menu.png");
            this.label_menu_makeorder.BackColor = Color.FromArgb(255, 133, 70, 24);
            this.pb_menu_checkorder.Image = Image.FromFile($@"resources\K_rectangle_menu.png");
            this.label_menu_checkorder.BackColor = Color.FromArgb(255, 133, 70, 24);

            this.panel_container.Controls.Clear();
            FormPayment formPayment = new FormPayment();
            formPayment.Dock = DockStyle.Fill;
            formPayment.TopLevel = false;
            formPayment.ControlBox = false;
            formPayment.FormBorderStyle = FormBorderStyle.None;
            this.panel_container.Controls.Add(formPayment);
            formPayment.Show();
        }

        private void menu_checkorder_Click(object sender, EventArgs e)
        {
            this.pb_menu_checkorder.Image = Image.FromFile($@"resources\K_rectangle_menu_clicked.png");
            this.label_menu_checkorder.BackColor = Color.FromArgb(255, 208, 132, 76);
            this.pb_menu_makeorder.Image = Image.FromFile($@"resources\K_rectangle_menu.png");
            this.label_menu_makeorder.BackColor = Color.FromArgb(255, 133, 70, 24);
            this.pb_menu_payment.Image = Image.FromFile($@"resources\K_rectangle_menu.png");
            this.label_menu_payment.BackColor = Color.FromArgb(255, 133, 70, 24);

            this.panel_container.Controls.Clear();
            FormCheckOrder formCheckOrder = new FormCheckOrder();
            formCheckOrder.Dock = DockStyle.Fill;
            formCheckOrder.TopLevel = false;
            formCheckOrder.ControlBox = false;
            formCheckOrder.FormBorderStyle = FormBorderStyle.None;
            this.panel_container.Controls.Add(formCheckOrder);
            formCheckOrder.Show();
        }

        private void timer_second_Tick(object sender, EventArgs e)
        {

        }

        private void label_date_Click(object sender, EventArgs e)
        {

        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_rectangle_datetime_Click(object sender, EventArgs e)
        {

        }

        private void label_service_Click(object sender, EventArgs e)
        {

        }

        private void pb_logo_Click(object sender, EventArgs e)
        {

        }

        private void label_time_Click(object sender, EventArgs e)
        {

        }

        private void pb_bg_Click(object sender, EventArgs e)
        {

        }

        private void panel_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
