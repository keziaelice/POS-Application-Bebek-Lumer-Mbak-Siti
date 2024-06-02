namespace ALP_SAD_DBI
{
    partial class Form_Service_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_menu_checkorder = new System.Windows.Forms.Label();
            this.label_menu_payment = new System.Windows.Forms.Label();
            this.label_menu_makeorder = new System.Windows.Forms.Label();
            this.pb_menu_checkorder = new System.Windows.Forms.PictureBox();
            this.pb_menu_payment = new System.Windows.Forms.PictureBox();
            this.pb_menu_makeorder = new System.Windows.Forms.PictureBox();
            this.pb_icon_back = new System.Windows.Forms.PictureBox();
            this.pb_icon_home = new System.Windows.Forms.PictureBox();
            this.pb_button_logout = new System.Windows.Forms.PictureBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pb_rectangle_datetime = new System.Windows.Forms.PictureBox();
            this.label_service = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.timer_second = new System.Windows.Forms.Timer(this.components);
            this.pb_bg = new System.Windows.Forms.PictureBox();
            this.panel_container = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_checkorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_makeorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_button_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rectangle_datetime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.White;
            this.panel_header.Controls.Add(this.label_menu_checkorder);
            this.panel_header.Controls.Add(this.label_menu_payment);
            this.panel_header.Controls.Add(this.label_menu_makeorder);
            this.panel_header.Controls.Add(this.pb_menu_checkorder);
            this.panel_header.Controls.Add(this.pb_menu_payment);
            this.panel_header.Controls.Add(this.pb_menu_makeorder);
            this.panel_header.Controls.Add(this.pb_icon_back);
            this.panel_header.Controls.Add(this.pb_icon_home);
            this.panel_header.Controls.Add(this.pb_button_logout);
            this.panel_header.Controls.Add(this.label_date);
            this.panel_header.Controls.Add(this.label_time);
            this.panel_header.Controls.Add(this.pb_rectangle_datetime);
            this.panel_header.Controls.Add(this.label_service);
            this.panel_header.Controls.Add(this.pb_logo);
            this.panel_header.Location = new System.Drawing.Point(10, -5);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1873, 100);
            this.panel_header.TabIndex = 10;
            this.panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_header_Paint);
            // 
            // label_menu_checkorder
            // 
            this.label_menu_checkorder.AutoSize = true;
            this.label_menu_checkorder.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu_checkorder.Location = new System.Drawing.Point(608, 68);
            this.label_menu_checkorder.Name = "label_menu_checkorder";
            this.label_menu_checkorder.Size = new System.Drawing.Size(182, 36);
            this.label_menu_checkorder.TabIndex = 13;
            this.label_menu_checkorder.Text = "Check Order";
            this.label_menu_checkorder.Click += new System.EventHandler(this.menu_checkorder_Click);
            this.label_menu_checkorder.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.label_menu_checkorder.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // label_menu_payment
            // 
            this.label_menu_payment.AutoSize = true;
            this.label_menu_payment.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu_payment.Location = new System.Drawing.Point(485, 68);
            this.label_menu_payment.Name = "label_menu_payment";
            this.label_menu_payment.Size = new System.Drawing.Size(136, 36);
            this.label_menu_payment.TabIndex = 12;
            this.label_menu_payment.Text = "Payment";
            this.label_menu_payment.Click += new System.EventHandler(this.menu_payment_Click);
            this.label_menu_payment.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.label_menu_payment.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // label_menu_makeorder
            // 
            this.label_menu_makeorder.AutoSize = true;
            this.label_menu_makeorder.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu_makeorder.Location = new System.Drawing.Point(371, 68);
            this.label_menu_makeorder.Name = "label_menu_makeorder";
            this.label_menu_makeorder.Size = new System.Drawing.Size(169, 36);
            this.label_menu_makeorder.TabIndex = 11;
            this.label_menu_makeorder.Text = "Make Order";
            this.label_menu_makeorder.Click += new System.EventHandler(this.menu_makeorder_Click);
            this.label_menu_makeorder.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.label_menu_makeorder.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pb_menu_checkorder
            // 
            this.pb_menu_checkorder.Image = global::ALP_SAD_DBI.Properties.Resources.K_rectangle_menu;
            this.pb_menu_checkorder.Location = new System.Drawing.Point(588, 58);
            this.pb_menu_checkorder.Name = "pb_menu_checkorder";
            this.pb_menu_checkorder.Size = new System.Drawing.Size(100, 39);
            this.pb_menu_checkorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_menu_checkorder.TabIndex = 10;
            this.pb_menu_checkorder.TabStop = false;
            this.pb_menu_checkorder.Click += new System.EventHandler(this.menu_checkorder_Click);
            this.pb_menu_checkorder.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pb_menu_checkorder.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pb_menu_payment
            // 
            this.pb_menu_payment.Image = global::ALP_SAD_DBI.Properties.Resources.K_rectangle_menu;
            this.pb_menu_payment.Location = new System.Drawing.Point(473, 58);
            this.pb_menu_payment.Name = "pb_menu_payment";
            this.pb_menu_payment.Size = new System.Drawing.Size(100, 39);
            this.pb_menu_payment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_menu_payment.TabIndex = 9;
            this.pb_menu_payment.TabStop = false;
            this.pb_menu_payment.Click += new System.EventHandler(this.menu_payment_Click);
            this.pb_menu_payment.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pb_menu_payment.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pb_menu_makeorder
            // 
            this.pb_menu_makeorder.Image = global::ALP_SAD_DBI.Properties.Resources.K_rectangle_menu;
            this.pb_menu_makeorder.Location = new System.Drawing.Point(352, 58);
            this.pb_menu_makeorder.Name = "pb_menu_makeorder";
            this.pb_menu_makeorder.Size = new System.Drawing.Size(100, 39);
            this.pb_menu_makeorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_menu_makeorder.TabIndex = 8;
            this.pb_menu_makeorder.TabStop = false;
            this.pb_menu_makeorder.Click += new System.EventHandler(this.menu_makeorder_Click);
            this.pb_menu_makeorder.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pb_menu_makeorder.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pb_icon_back
            // 
            this.pb_icon_back.BackColor = System.Drawing.Color.Transparent;
            this.pb_icon_back.Image = global::ALP_SAD_DBI.Properties.Resources.K_icon_back;
            this.pb_icon_back.Location = new System.Drawing.Point(1766, 9);
            this.pb_icon_back.Name = "pb_icon_back";
            this.pb_icon_back.Size = new System.Drawing.Size(100, 50);
            this.pb_icon_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon_back.TabIndex = 7;
            this.pb_icon_back.TabStop = false;
            this.pb_icon_back.Click += new System.EventHandler(this.pb_icon_back_Click);
            this.pb_icon_back.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pb_icon_back.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pb_icon_home
            // 
            this.pb_icon_home.BackColor = System.Drawing.Color.Transparent;
            this.pb_icon_home.Image = global::ALP_SAD_DBI.Properties.Resources.K_icon_home;
            this.pb_icon_home.Location = new System.Drawing.Point(1659, 11);
            this.pb_icon_home.Name = "pb_icon_home";
            this.pb_icon_home.Size = new System.Drawing.Size(100, 50);
            this.pb_icon_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon_home.TabIndex = 6;
            this.pb_icon_home.TabStop = false;
            this.pb_icon_home.Click += new System.EventHandler(this.pb_icon_home_Click);
            this.pb_icon_home.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pb_icon_home.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pb_button_logout
            // 
            this.pb_button_logout.Image = global::ALP_SAD_DBI.Properties.Resources.K_button_logout;
            this.pb_button_logout.Location = new System.Drawing.Point(1480, 11);
            this.pb_button_logout.Name = "pb_button_logout";
            this.pb_button_logout.Size = new System.Drawing.Size(120, 50);
            this.pb_button_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_button_logout.TabIndex = 5;
            this.pb_button_logout.TabStop = false;
            this.pb_button_logout.Click += new System.EventHandler(this.pb_button_logout_Click);
            this.pb_button_logout.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pb_button_logout.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(1311, 22);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(130, 33);
            this.label_date.TabIndex = 4;
            this.label_date.Text = "11/21/2023";
            this.label_date.Click += new System.EventHandler(this.label_date_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(1168, 22);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(97, 33);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "3:32:54";
            this.label_time.Click += new System.EventHandler(this.label_time_Click);
            // 
            // pb_rectangle_datetime
            // 
            this.pb_rectangle_datetime.Image = global::ALP_SAD_DBI.Properties.Resources.K_rectangle_datetime;
            this.pb_rectangle_datetime.Location = new System.Drawing.Point(1116, 9);
            this.pb_rectangle_datetime.Name = "pb_rectangle_datetime";
            this.pb_rectangle_datetime.Size = new System.Drawing.Size(537, 52);
            this.pb_rectangle_datetime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_rectangle_datetime.TabIndex = 2;
            this.pb_rectangle_datetime.TabStop = false;
            this.pb_rectangle_datetime.Click += new System.EventHandler(this.pb_rectangle_datetime_Click);
            // 
            // label_service
            // 
            this.label_service.AutoSize = true;
            this.label_service.Font = new System.Drawing.Font("Montserrat SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_service.Location = new System.Drawing.Point(3, 58);
            this.label_service.Name = "label_service";
            this.label_service.Size = new System.Drawing.Size(362, 99);
            this.label_service.TabIndex = 1;
            this.label_service.Text = "SERVICE";
            this.label_service.Click += new System.EventHandler(this.label_service_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::ALP_SAD_DBI.Properties.Resources.K_logo;
            this.pb_logo.Location = new System.Drawing.Point(3, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(203, 52);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            this.pb_logo.Click += new System.EventHandler(this.pb_logo_Click);
            // 
            // timer_second
            // 
            this.timer_second.Tick += new System.EventHandler(this.timer_second_Tick);
            // 
            // pb_bg
            // 
            this.pb_bg.Image = global::ALP_SAD_DBI.Properties.Resources.K_bg;
            this.pb_bg.Location = new System.Drawing.Point(16, 101);
            this.pb_bg.Name = "pb_bg";
            this.pb_bg.Size = new System.Drawing.Size(1873, 929);
            this.pb_bg.TabIndex = 11;
            this.pb_bg.TabStop = false;
            this.pb_bg.Click += new System.EventHandler(this.pb_bg_Click);
            // 
            // panel_container
            // 
            this.panel_container.Location = new System.Drawing.Point(70, 142);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1083, 513);
            this.panel_container.TabIndex = 13;
            this.panel_container.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_container_Paint);
            // 
            // Form_Service_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.pb_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Service_1";
            this.Text = "Form_Service_1";
            this.Load += new System.EventHandler(this.Form_Service_1_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_checkorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_makeorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_button_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rectangle_datetime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pb_button_logout;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox pb_rectangle_datetime;
        private System.Windows.Forms.Timer timer_second;
        private System.Windows.Forms.PictureBox pb_bg;
        private System.Windows.Forms.PictureBox pb_icon_home;
        private System.Windows.Forms.PictureBox pb_icon_back;
        private System.Windows.Forms.PictureBox pb_menu_makeorder;
        private System.Windows.Forms.PictureBox pb_menu_payment;
        private System.Windows.Forms.PictureBox pb_menu_checkorder;
        private System.Windows.Forms.Label label_menu_makeorder;
        private System.Windows.Forms.Label label_menu_checkorder;
        private System.Windows.Forms.Label label_menu_payment;
        private Guna.UI2.WinForms.Guna2Panel panel_container;
        public System.Windows.Forms.Label label_service;
    }
}