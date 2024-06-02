namespace ALP_SAD_DBI
{
    partial class Form_Home
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
            this.pb_button_logout = new System.Windows.Forms.PictureBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pb_rectangle_datetime = new System.Windows.Forms.PictureBox();
            this.label_home = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.label_menu_stock = new System.Windows.Forms.Label();
            this.label_menu_finance = new System.Windows.Forms.Label();
            this.label_menu_service = new System.Windows.Forms.Label();
            this.timer_second = new System.Windows.Forms.Timer(this.components);
            this.pb_icon_stock = new System.Windows.Forms.PictureBox();
            this.pb_icon_finance = new System.Windows.Forms.PictureBox();
            this.pb_icon_service = new System.Windows.Forms.PictureBox();
            this.pb_bg = new System.Windows.Forms.PictureBox();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_button_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rectangle_datetime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_finance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.White;
            this.panel_header.Controls.Add(this.pb_button_logout);
            this.panel_header.Controls.Add(this.label_date);
            this.panel_header.Controls.Add(this.label_time);
            this.panel_header.Controls.Add(this.pb_rectangle_datetime);
            this.panel_header.Controls.Add(this.label_home);
            this.panel_header.Controls.Add(this.pb_logo);
            this.panel_header.Location = new System.Drawing.Point(1, 3);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1873, 100);
            this.panel_header.TabIndex = 1;
            // 
            // pb_button_logout
            // 
            this.pb_button_logout.Image = global::ALP_SAD_DBI.Properties.Resources.K_button_logout;
            this.pb_button_logout.Location = new System.Drawing.Point(1683, 11);
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
            this.label_date.Location = new System.Drawing.Point(1514, 22);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(130, 33);
            this.label_date.TabIndex = 4;
            this.label_date.Text = "11/21/2023";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(1371, 22);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(97, 33);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "3:32:54";
            // 
            // pb_rectangle_datetime
            // 
            this.pb_rectangle_datetime.Image = global::ALP_SAD_DBI.Properties.Resources.K_rectangle_datetime;
            this.pb_rectangle_datetime.Location = new System.Drawing.Point(1319, 9);
            this.pb_rectangle_datetime.Name = "pb_rectangle_datetime";
            this.pb_rectangle_datetime.Size = new System.Drawing.Size(537, 52);
            this.pb_rectangle_datetime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_rectangle_datetime.TabIndex = 2;
            this.pb_rectangle_datetime.TabStop = false;
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.Font = new System.Drawing.Font("Montserrat SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.Location = new System.Drawing.Point(3, 58);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(278, 99);
            this.label_home.TabIndex = 1;
            this.label_home.Text = "HOME";
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
            // 
            // label_menu_stock
            // 
            this.label_menu_stock.AutoSize = true;
            this.label_menu_stock.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu_stock.Location = new System.Drawing.Point(829, 612);
            this.label_menu_stock.Name = "label_menu_stock";
            this.label_menu_stock.Size = new System.Drawing.Size(84, 33);
            this.label_menu_stock.TabIndex = 9;
            this.label_menu_stock.Text = "Stock";
            this.label_menu_stock.Click += new System.EventHandler(this.label_menu_stock_Click);
            this.label_menu_stock.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.label_menu_stock.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // label_menu_finance
            // 
            this.label_menu_finance.AutoSize = true;
            this.label_menu_finance.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu_finance.Location = new System.Drawing.Point(552, 611);
            this.label_menu_finance.Name = "label_menu_finance";
            this.label_menu_finance.Size = new System.Drawing.Size(113, 33);
            this.label_menu_finance.TabIndex = 8;
            this.label_menu_finance.Text = "Finance";
            this.label_menu_finance.Click += new System.EventHandler(this.label_menu_finance_Click);
            this.label_menu_finance.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.label_menu_finance.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // label_menu_service
            // 
            this.label_menu_service.AutoSize = true;
            this.label_menu_service.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu_service.Location = new System.Drawing.Point(313, 611);
            this.label_menu_service.Name = "label_menu_service";
            this.label_menu_service.Size = new System.Drawing.Size(105, 33);
            this.label_menu_service.TabIndex = 7;
            this.label_menu_service.Text = "Service";
            this.label_menu_service.Click += new System.EventHandler(this.label_menu_service_Click);
            this.label_menu_service.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.label_menu_service.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pb_icon_stock
            // 
            this.pb_icon_stock.Image = global::ALP_SAD_DBI.Properties.Resources.K_icon_stock;
            this.pb_icon_stock.Location = new System.Drawing.Point(774, 428);
            this.pb_icon_stock.Name = "pb_icon_stock";
            this.pb_icon_stock.Size = new System.Drawing.Size(186, 180);
            this.pb_icon_stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon_stock.TabIndex = 6;
            this.pb_icon_stock.TabStop = false;
            this.pb_icon_stock.Click += new System.EventHandler(this.pb_icon_stock_Click);
            this.pb_icon_stock.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pb_icon_stock.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pb_icon_finance
            // 
            this.pb_icon_finance.Image = global::ALP_SAD_DBI.Properties.Resources.K_icon_finance;
            this.pb_icon_finance.Location = new System.Drawing.Point(497, 428);
            this.pb_icon_finance.Name = "pb_icon_finance";
            this.pb_icon_finance.Size = new System.Drawing.Size(183, 180);
            this.pb_icon_finance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon_finance.TabIndex = 5;
            this.pb_icon_finance.TabStop = false;
            this.pb_icon_finance.Click += new System.EventHandler(this.pb_icon_finance_Click);
            this.pb_icon_finance.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pb_icon_finance.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pb_icon_service
            // 
            this.pb_icon_service.BackColor = System.Drawing.Color.White;
            this.pb_icon_service.Image = global::ALP_SAD_DBI.Properties.Resources.K_icon_service;
            this.pb_icon_service.Location = new System.Drawing.Point(243, 428);
            this.pb_icon_service.Name = "pb_icon_service";
            this.pb_icon_service.Size = new System.Drawing.Size(179, 180);
            this.pb_icon_service.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon_service.TabIndex = 4;
            this.pb_icon_service.TabStop = false;
            this.pb_icon_service.Click += new System.EventHandler(this.pb_icon_service_Click);
            this.pb_icon_service.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pb_icon_service.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pb_bg
            // 
            this.pb_bg.Image = global::ALP_SAD_DBI.Properties.Resources.K_bg;
            this.pb_bg.Location = new System.Drawing.Point(7, 109);
            this.pb_bg.Name = "pb_bg";
            this.pb_bg.Size = new System.Drawing.Size(1873, 929);
            this.pb_bg.TabIndex = 2;
            this.pb_bg.TabStop = false;
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 1080);
            this.Controls.Add(this.label_menu_stock);
            this.Controls.Add(this.label_menu_finance);
            this.Controls.Add(this.label_menu_service);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.pb_icon_stock);
            this.Controls.Add(this.pb_icon_finance);
            this.Controls.Add(this.pb_icon_service);
            this.Controls.Add(this.pb_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bebek Lumer Mbak Siti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_button_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rectangle_datetime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_finance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pb_bg;
        private System.Windows.Forms.PictureBox pb_icon_service;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.PictureBox pb_rectangle_datetime;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox pb_button_logout;
        private System.Windows.Forms.Timer timer_second;
        private System.Windows.Forms.PictureBox pb_icon_finance;
        private System.Windows.Forms.PictureBox pb_icon_stock;
        private System.Windows.Forms.Label label_menu_service;
        private System.Windows.Forms.Label label_menu_finance;
        private System.Windows.Forms.Label label_menu_stock;
    }
}

