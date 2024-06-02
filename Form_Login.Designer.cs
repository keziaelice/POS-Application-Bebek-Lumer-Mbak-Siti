namespace ALP_SAD_DBI
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.panel_header = new System.Windows.Forms.Panel();
            this.pb_button_logout = new System.Windows.Forms.PictureBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pb_rectangle_datetime = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.timer_second = new System.Windows.Forms.Timer(this.components);
            this.pb_bg = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_button_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rectangle_datetime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.White;
            this.panel_header.Controls.Add(this.pb_button_logout);
            this.panel_header.Controls.Add(this.label_date);
            this.panel_header.Controls.Add(this.label_time);
            this.panel_header.Controls.Add(this.pb_rectangle_datetime);
            this.panel_header.Controls.Add(this.pb_logo);
            this.panel_header.Location = new System.Drawing.Point(1, 2);
            this.panel_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1665, 80);
            this.panel_header.TabIndex = 1;
            this.panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_header_Paint);
            // 
            // pb_button_logout
            // 
            this.pb_button_logout.Image = global::ALP_SAD_DBI.Properties.Resources.K_button_logout;
            this.pb_button_logout.Location = new System.Drawing.Point(1496, 9);
            this.pb_button_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_button_logout.Name = "pb_button_logout";
            this.pb_button_logout.Size = new System.Drawing.Size(107, 40);
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
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(1346, 18);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(112, 25);
            this.label_date.TabIndex = 4;
            this.label_date.Text = "11/21/2023";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(1219, 18);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(79, 25);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "3:32:54";
            // 
            // pb_rectangle_datetime
            // 
            this.pb_rectangle_datetime.Image = global::ALP_SAD_DBI.Properties.Resources.K_rectangle_datetime;
            this.pb_rectangle_datetime.Location = new System.Drawing.Point(1172, 7);
            this.pb_rectangle_datetime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_rectangle_datetime.Name = "pb_rectangle_datetime";
            this.pb_rectangle_datetime.Size = new System.Drawing.Size(477, 42);
            this.pb_rectangle_datetime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_rectangle_datetime.TabIndex = 2;
            this.pb_rectangle_datetime.TabStop = false;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::ALP_SAD_DBI.Properties.Resources.K_logo;
            this.pb_logo.Location = new System.Drawing.Point(3, 2);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(180, 42);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // pb_bg
            // 
            this.pb_bg.BackColor = System.Drawing.Color.Transparent;
            this.pb_bg.Image = ((System.Drawing.Image)(resources.GetObject("pb_bg.Image")));
            this.pb_bg.Location = new System.Drawing.Point(6, 87);
            this.pb_bg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_bg.Name = "pb_bg";
            this.pb_bg.Size = new System.Drawing.Size(1665, 743);
            this.pb_bg.TabIndex = 2;
            this.pb_bg.TabStop = false;
            this.pb_bg.Click += new System.EventHandler(this.pb_bg_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(482, 97);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 3;
            this.pictureBoxUser.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 864);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.pb_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bebek Lumer Mbak Siti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Login_Paint);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_button_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rectangle_datetime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.PictureBox pb_rectangle_datetime;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox pb_button_logout;
        private System.Windows.Forms.Timer timer_second;
        private System.Windows.Forms.PictureBox pb_bg;
        private System.Windows.Forms.PictureBox pictureBoxUser;
    }
}

