namespace ALP_SAD_DBI
{
    partial class Form_Service_MakeOrder_1
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
            this.label_customername = new System.Windows.Forms.Label();
            this.tb_customername = new Guna.UI2.WinForms.Guna2TextBox();
            this.pb_bg = new System.Windows.Forms.PictureBox();
            this.pb_menu_food = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb_menu_beverage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_listmenu = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_beverage)).BeginInit();
            this.SuspendLayout();
            // 
            // label_customername
            // 
            this.label_customername.AutoSize = true;
            this.label_customername.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customername.Location = new System.Drawing.Point(492, 23);
            this.label_customername.Name = "label_customername";
            this.label_customername.Size = new System.Drawing.Size(166, 25);
            this.label_customername.TabIndex = 8;
            this.label_customername.Text = "Customer Name:";
            // 
            // tb_customername
            // 
            this.tb_customername.AutoRoundedCorners = true;
            this.tb_customername.BorderColor = System.Drawing.Color.Gray;
            this.tb_customername.BorderRadius = 18;
            this.tb_customername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_customername.DefaultText = "";
            this.tb_customername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_customername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_customername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_customername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_customername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_customername.Font = new System.Drawing.Font("Montserrat", 11F);
            this.tb_customername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_customername.Location = new System.Drawing.Point(511, 60);
            this.tb_customername.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tb_customername.Name = "tb_customername";
            this.tb_customername.PasswordChar = '\0';
            this.tb_customername.PlaceholderText = "";
            this.tb_customername.SelectedText = "";
            this.tb_customername.Size = new System.Drawing.Size(360, 39);
            this.tb_customername.TabIndex = 7;
            // 
            // pb_bg
            // 
            this.pb_bg.Image = global::ALP_SAD_DBI.Properties.Resources.K_bg;
            this.pb_bg.Location = new System.Drawing.Point(-7, 2);
            this.pb_bg.Name = "pb_bg";
            this.pb_bg.Size = new System.Drawing.Size(943, 386);
            this.pb_bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_bg.TabIndex = 10;
            this.pb_bg.TabStop = false;
            // 
            // pb_menu_food
            // 
            this.pb_menu_food.BackColor = System.Drawing.Color.Transparent;
            this.pb_menu_food.Image = global::ALP_SAD_DBI.Properties.Resources.K_menu_food;
            this.pb_menu_food.ImageRotate = 0F;
            this.pb_menu_food.Location = new System.Drawing.Point(28, 49);
            this.pb_menu_food.Name = "pb_menu_food";
            this.pb_menu_food.Size = new System.Drawing.Size(136, 50);
            this.pb_menu_food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_menu_food.TabIndex = 11;
            this.pb_menu_food.TabStop = false;
            this.pb_menu_food.UseTransparentBackground = true;
            this.pb_menu_food.Click += new System.EventHandler(this.pb_menu_food_Click);
            this.pb_menu_food.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pb_menu_food.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pb_menu_beverage
            // 
            this.pb_menu_beverage.BackColor = System.Drawing.Color.Transparent;
            this.pb_menu_beverage.Image = global::ALP_SAD_DBI.Properties.Resources.K_menu_beverage;
            this.pb_menu_beverage.ImageRotate = 0F;
            this.pb_menu_beverage.Location = new System.Drawing.Point(160, 46);
            this.pb_menu_beverage.Name = "pb_menu_beverage";
            this.pb_menu_beverage.Size = new System.Drawing.Size(143, 53);
            this.pb_menu_beverage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_menu_beverage.TabIndex = 12;
            this.pb_menu_beverage.TabStop = false;
            this.pb_menu_beverage.UseTransparentBackground = true;
            this.pb_menu_beverage.Click += new System.EventHandler(this.pb_menu_beverage_Click);
            this.pb_menu_beverage.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pb_menu_beverage.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // panel_listmenu
            // 
            this.panel_listmenu.Location = new System.Drawing.Point(113, 175);
            this.panel_listmenu.Name = "panel_listmenu";
            this.panel_listmenu.Size = new System.Drawing.Size(200, 100);
            this.panel_listmenu.TabIndex = 0;
            // 
            // Form_Service_MakeOrder_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 450);
            this.Controls.Add(this.panel_listmenu);
            this.Controls.Add(this.pb_menu_beverage);
            this.Controls.Add(this.pb_menu_food);
            this.Controls.Add(this.label_customername);
            this.Controls.Add(this.tb_customername);
            this.Controls.Add(this.pb_bg);
            this.Name = "Form_Service_MakeOrder_1";
            this.Text = "Form_Service_MakeOrder_1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Service_MakeOrder_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_beverage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_customername;
        private Guna.UI2.WinForms.Guna2TextBox tb_customername;
        private System.Windows.Forms.PictureBox pb_bg;
        private Guna.UI2.WinForms.Guna2PictureBox pb_menu_food;
        private Guna.UI2.WinForms.Guna2PictureBox pb_menu_beverage;
        private Guna.UI2.WinForms.Guna2Panel panel_listmenu;
    }
}