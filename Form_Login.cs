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
    public partial class Form_Login : Form
    {
        Form_Main form_Main = Application.OpenForms["form_Main"] as Form_Main;
        public DataTable dtUsername;
        public Form_Login()
        {
            InitializeComponent();
            form_Main.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=secu");
            form_Main.sqlConnect.Open();
            timer_second.Start();
        }
          TextBox password = new TextBox();
        TextBox username = new TextBox();

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

            //label_home.Text = "LOGIN";
            //label_home.Location = new Point(pb_logo.Left + 40, pb_logo.Bottom + 70);
            //label_home.ForeColor = Color.FromArgb(255, 89, 89, 89);

            pb_logo.Size = new Size(500, 100);
            pb_logo.Location = new Point(0, 10);
            pb_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo.BorderStyle = BorderStyle.None;
            pb_logo.BackColor = Color.Transparent;

            //Panel panelLogin=new Panel();
            // panelLogin.BorderStyle = BorderStyle.None;
            // panelLogin.BackColor = Color.White;
            // panelLogin.Size = new Size(this.Width / 3, this.Height / 3);
            // panelLogin.BringToFront();
            // this.Controls.Add(panelLogin);

            // Membuat panel baru
            Panel panelLogin = new Panel
            {
                //BackColor = Color.FromArgb(10, 0, 0, 0),  // Ganti dengan kode warna yang tepat
                BackColor = Color.Gray,
                Size = new Size(500, 400), // Atur ukuran sesuai kebutuhan
                                           // Posisi panel akan diatur setelah ukuran form diketahui
                
            };

            // Membuat label
            Label lblGreeting = new Label
            {
                Text = "Selamat Pagi!",
                ForeColor = Color.White, // Atur warna teks sesuai dengan yang diinginkan
                Font = new Font("Arial", 30, FontStyle.Bold), // Atur font sesuai kebutuhan
                AutoSize = true,
                BackColor = Color.Transparent,
            };
            panelLogin.Controls.Add(lblGreeting);
            Label lblGreeting2 = new Label
            {
                Text = "Silakan login terlebih dahulu!",
                ForeColor = Color.White, // Atur warna teks sesuai dengan yang diinginkan
                Font = new Font("Arial", 14, FontStyle.Regular), // Atur font sesuai kebutuhan
                AutoSize = true,
                BackColor = Color.Transparent,
            };
            panelLogin.Controls.Add(lblGreeting2);

            // Membuat PictureBox untuk ikon pengguna
            //PictureBox pictureBoxUser = new PictureBox
            //{
            //    Image = Properties.Resources.userIcon, // Asumsikan Anda memiliki ikon pengguna di resources
            //    SizeMode = PictureBoxSizeMode.AutoSize,
            //    Location = new Point(135, 100) // Posisi bisa disesuaikan
            //};
            // Mengatur posisi label di dalam panel
            lblGreeting.Location = new Point((panelLogin.Width - lblGreeting.Width) / 2, 30); // 30 adalah margin top dari panel
            lblGreeting2.Location = new Point((panelLogin.Width - lblGreeting2.Width) / 2, lblGreeting.Height + 30);


            pictureBoxUser.Size = new Size(panelLogin.Width/3-10, panelLogin.Height/3-10);
            pictureBoxUser.Location = new Point((panelLogin.Width - pictureBoxUser.Width) / 2,
                                            (lblGreeting2.Location.Y+40));
            panelLogin.Controls.Add(pictureBoxUser);

            // Menambahkan panel ke form
            this.Controls.Add(panelLogin);

            // Mengatur posisi panel agar berada di tengah form
            panelLogin.Location = new Point((this.ClientSize.Width - panelLogin.Width) / 2,
                                            (this.ClientSize.Height - panelLogin.Height) / 2);

            

            Label lblUsername = new Label
            {
                Text = "Username",
                ForeColor = Color.Black, // Atur warna teks sesuai dengan yang diinginkan
                Font = new Font("Arial", 12, FontStyle.Regular), // Atur font sesuai kebutuhan
                AutoSize = true,
            };
            lblUsername.Location = new Point(panelLogin.Width / 10, panelLogin.Height / 2 + 50);
            panelLogin.Controls.Add(lblUsername);

            
            username.Size= new Size(panelLogin.Width - (panelLogin.Width/10)*2, 20);
            username.Location = new Point(panelLogin.Width /10,panelLogin.Height/2+70);
            username.BorderStyle = BorderStyle.None;
            username.BackColor = Color.White;
            username.Text = "Masukkan username anda...";
            username.ForeColor = Color.Gray;
            username.Font = new Font("Arial", 15, FontStyle.Regular);


            // Event ketika textbox mendapat fokus
            username.Enter += (sender1, e1) => {
                TextBox tb = (TextBox)sender1;
                if (tb.Text == "Masukkan username anda..." && tb.ForeColor == Color.Gray)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black; // Warna teks normal
                }
            };

            // Event ketika textbox kehilangan fokus
            username.Leave += (sender1, e1) => {
                TextBox tb = (TextBox)sender1;
                if (string.IsNullOrEmpty(tb.Text))
                {
                    tb.Text = "Masukkan username anda...";
                    tb.ForeColor = Color.Gray; // Warna placeholder
                }
            };


            Label lblPassword = new Label
            {
                Text = "Password",
                ForeColor = Color.Black, // Atur warna teks sesuai dengan yang diinginkan
                Font = new Font("Arial", 12, FontStyle.Regular), // Atur font sesuai kebutuhan
                AutoSize = true,
            };
            lblPassword.Location = new Point(panelLogin.Width / 10, panelLogin.Height / 2 + 100);
            panelLogin.Controls.Add(lblPassword);

          
            password.Size = new Size(panelLogin.Width - (panelLogin.Width / 10) * 2, 20);
            password.Location = new Point(panelLogin.Width / 10, panelLogin.Height / 2 + 120);
            password.BorderStyle = BorderStyle.None;
            password.BackColor = Color.White;
            password.Text = "Masukkan password anda...";
            password.ForeColor = Color.Gray;
            password.Font = new Font("Arial", 15, FontStyle.Regular);
          

            // Event ketika textbox mendapat fokus
            password.Enter += (sender1, e1) => {
                TextBox tb = (TextBox)sender1;
                if (tb.Text == "Masukkan password anda..." && tb.ForeColor == Color.Gray)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black; // Warna teks normal
                    tb.PasswordChar = '*';
                }
            };

            // Event ketika textbox kehilangan fokus
            password.Leave += (sender1, e1) => {
                TextBox tb = (TextBox)sender1;
                if (string.IsNullOrEmpty(tb.Text))
                {
                    tb.Text = "Masukkan password anda...";
                    tb.ForeColor = Color.Gray; // Warna placeholder
                    tb.PasswordChar = '\0';
                }
            };


            //username.BringToFront();
            //pictureBoxUser.SendToBack();

            panelLogin.Controls.Add(username);
            panelLogin.Controls.Add(password);

            panelLogin.BringToFront();
            panelLogin.Focus() ;

            Button signIn=new Button();
            signIn.BackColor = Color.Blue;
            signIn.Text = "Sign In";
            signIn.ForeColor = Color.White;
            signIn.Font=new Font("Arial", 20, FontStyle.Bold);
            signIn.Size = new Size(150, 50);
            
            signIn.Location= new Point((this.ClientSize.Width - signIn.Width) / 2,
                                            panelLogin.Location.Y + panelLogin.Height+10);
            this.Controls.Add(signIn);
            signIn.BringToFront() ;
            signIn.Click += SignIn_Click;

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                form_Main.sqlQuery = $"select pass_user as password from userr where nama_user='{username.Text.ToString()}';";
                form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);

                string result = null;
                if (form_Main.sqlCommand.ExecuteScalar() != null)
                {
                    result = form_Main.sqlCommand.ExecuteScalar().ToString();
                }
                //form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
                //form_Main.sqlAdapter.Fill();
                if (result == null)
                {
                    MessageBox.Show("Username salah");
                }
                else
                {
                    if (result == password.Text)
                    {
                        dtUsername = new DataTable();
                        form_Main.sqlQuery = $"SELECT u.IDuser FROM userr u WHERE u.nama_user = '{username.Text}';";
                        form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
                        form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
                        form_Main.sqlAdapter.Fill(dtUsername);

                        form_Main.panel_Container.Controls.Clear();
                        Form_Home form_home = new Form_Home();
                        form_home.Dock = DockStyle.Fill;
                        form_home.TopLevel = false;
                        form_home.ControlBox = false;
                        form_home.FormBorderStyle = FormBorderStyle.None;
                        form_Main.panel_Container.Controls.Add(form_home);
                        form_home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password salah");
                    }

                }
            }
            catch (Exception)
            {
            }
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
            
        }


        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Login_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pb_bg_Click(object sender, EventArgs e)
        {

        }
    }
}
