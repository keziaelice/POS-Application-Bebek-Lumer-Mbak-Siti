using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Guna.UI2.WinForms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ALP_SAD_DBI
{
    public partial class Form_Service_MakeOrder_1 : Form
    {
        Form_Main form_Main = Application.OpenForms["form_Main"] as Form_Main;
        Form_Home form_Home = Application.OpenForms["form_Home"] as Form_Home;
        Form_Service_1 form_Service_1 = Application.OpenForms["form_Service_1"] as Form_Service_1;
        Form_Login form_Login = Application.OpenForms["form_Login"] as Form_Login;

        public DataTable dtMenuMakanan;
        public DataTable dtMenuMinuman;
        public DataTable dtMenu;
        public List<PictureBox> pbBackground = new List<PictureBox>();
        public List<Label> labelMenuOrder = new List<Label>();
        public int x = 0;
        public int y = 0;
        public string kategori = "";
        string idMenu = "";
        string namaMenu = "";
        int harga = 0;
        string gambar = "";
        Guna2Panel panel_orderlist = new Guna2Panel();
        //Guna2Panel panel_orderlist_2 = new Guna2Panel();
        List<string> list_idmenu = new List<string>();
        List<int> list_jumlah = new List<int>();
        List<Label> list_label_jumlah = new List<Label>();
        List<string> listjumlah = new List<string>();
        int counter = 0;
        string IDmenu = "";
        string IDmenu_edit = "";
        DataTable dtidcust = new DataTable();
        //public Guna2Panel panel_listmenu;
        public Form_Service_MakeOrder_1()
        {
            InitializeComponent();
            form_Main.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=secu");
            form_Main.sqlConnect.Open();
        }

        private void Form_Service_MakeOrder_1_Load(object sender, EventArgs e)
        {
            panel_listmenu.Size = new Size(730, 400);
            panel_listmenu.AutoScroll = true;
            panel_listmenu.Parent = pb_bg;
            panel_listmenu.Location = new Point(30, 75);
            panel_listmenu.BackColor = Color.Transparent;

            pb_bg.Size = new Size(1280, 590);
            pb_bg.Location = new Point(0, 0);
            pb_bg.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_bg.BorderStyle = BorderStyle.None;

            pb_menu_food.Size = new Size(80, 35);
            pb_menu_food.Location = new Point(form_Service_1.label_service.Left, 40);
            pb_menu_food.BorderStyle = BorderStyle.None;
            pb_menu_beverage.Size = new Size(110, 35);
            pb_menu_beverage.Location = new Point(pb_menu_food.Right - 5, 40);
            pb_menu_beverage.BorderStyle = BorderStyle.None;

            tb_customername.Location = new Point(pb_menu_beverage.Right + 18, pb_menu_beverage.Top + 7);
            tb_customername.Parent = pb_bg;
            tb_customername.BackColor = Color.Transparent;
            label_customername.Location = new Point(tb_customername.Left, pb_menu_beverage.Top - 11);
            label_customername.Parent = pb_bg;
            label_customername.BackColor = Color.Transparent;
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pb_menu_food_Click(object sender, EventArgs e)
        {
            this.pb_menu_food.Image = Image.FromFile($@"resources\K_menu_food_clicked.png");
            this.pb_menu_beverage.Image = Image.FromFile($@"resources\K_menu_beverage.png");

            panel_listmenu.Controls.Clear();
            x = 0;
            y = 0;
            kategori = "makanan";
            dtMenuMakanan = new DataTable();
            try
            {
                form_Main.sqlQuery = $"SELECT * FROM vMenuMakanan;";
                form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
                form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
                form_Main.sqlAdapter.Fill(dtMenuMakanan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dtMenuMakanan.Rows.Count > 0)
            {
                displayMenu(kategori, 0, x, y);
                x++;
                if (dtMenuMakanan.Rows.Count > 1)
                {
                    for (int i = 1; i < dtMenuMakanan.Rows.Count; i++)
                    {
                        displayMenu(kategori, i, x, y);
                        if (x < 4)
                        {
                            x++;
                        }
                        else
                        {
                            x = 0;
                            y++;
                        }
                    }
                }
            }
            showOrderList();
        }

        private void pb_menu_beverage_Click(object sender, EventArgs e)
        {
            this.pb_menu_beverage.Image = Image.FromFile($@"resources\K_menu_beverage_clicked.png");
            this.pb_menu_food.Image = Image.FromFile($@"resources\K_menu_food.png");

            panel_listmenu.Controls.Clear();
            x = 0;
            y = 0;
            kategori = "minuman";
            dtMenuMinuman = new DataTable();
            try
            {
                form_Main.sqlQuery = $"SELECT * FROM vMenuMinuman;";
                form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
                form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
                form_Main.sqlAdapter.Fill(dtMenuMinuman);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dtMenuMinuman.Rows.Count > 0)
            {
                displayMenu(kategori, 0, x, y);
                x++;
                if (dtMenuMinuman.Rows.Count > 1)
                {
                    for (int i = 1; i < dtMenuMinuman.Rows.Count; i++)
                    {
                        displayMenu(kategori, i, x, y);
                        if (x < 4)
                        {
                            x++;
                        }
                        else
                        {
                            x = 0;
                            y++;
                        }
                    }
                }
            }
            showOrderList();
        }

        private void displayMenu(string _kategori, int _i, int _x, int _y)
        {
            string kategori = _kategori;
            int i = _i;
            int x = _x;
            int y = _y;

            //MessageBox.Show(i.ToString());

            if (kategori == "makanan")
            {
                idMenu = dtMenuMakanan.Rows[i][0].ToString();
                namaMenu = dtMenuMakanan.Rows[i][1].ToString();
                harga = Convert.ToInt32(dtMenuMakanan.Rows[i][2]);
                gambar = dtMenuMakanan.Rows[i][3].ToString();
            }
            else if (kategori == "minuman")
            {
                idMenu = dtMenuMinuman.Rows[i][0].ToString();
                namaMenu = dtMenuMinuman.Rows[i][1].ToString();
                harga = Convert.ToInt32(dtMenuMinuman.Rows[i][2]);
                gambar = dtMenuMinuman.Rows[i][3].ToString();
            }

            //MessageBox.Show(idMenu, namaMenu);

            Guna2PictureBox pb_background = new Guna2PictureBox();
            //pb_background.BorderStyle = BorderStyle.FixedSingle;
            pb_background.Tag = idMenu;
            pb_background.UseTransparentBackground = true;
            pb_background.Image = Image.FromFile($@"resources\K_rectangle_bg_menu.png");
            pb_background.Size = new Size(125, 170);
            pb_background.Location = new Point(x * 125 + 12, y * 180 + 30);
            pb_background.SizeMode = PictureBoxSizeMode.Zoom;
            pb_background.MouseEnter += mouseEnter;
            pb_background.Click += plusOrder;
            pb_background.MouseLeave += mouseLeave;
            //pb_background.BorderStyle = BorderStyle.FixedSingle;
            pbBackground.Add(pb_background);
            this.panel_listmenu.Controls.Add(pb_background);

            Guna2PictureBox pb_menu = new Guna2PictureBox();
            pb_menu.Tag = idMenu;
            pb_menu.Image = Image.FromFile($@"resources\{gambar}");
            //pb_from.Image = Image.FromFile($@"assets\history_from.png");
            pb_menu.Size = new Size(89, 89);
            pb_menu.BorderRadius = 10;
            pb_menu.UseTransparentBackground = true;
            pb_menu.SizeMode = PictureBoxSizeMode.Zoom;
            pb_menu.Location = new Point(pb_background.Left + 17, pb_background.Top + 10);
            //pb_menu.BorderStyle = BorderStyle.FixedSingle;
            pb_menu.MouseEnter += mouseEnter;
            pb_menu.Click += plusOrder;
            pb_menu.MouseLeave += mouseLeave;
            panel_listmenu.Controls.Add(pb_menu);
            //MessageBox.Show("pb");
            pb_menu.BringToFront();

            Label label_namamenu = new Label();
            label_namamenu.Tag = idMenu;
            label_namamenu.Text = namaMenu;
            label_namamenu.Font = new Font("Montserrat", 8, FontStyle.Regular);
            label_namamenu.AutoSize = false;
            label_namamenu.Size = new Size(pb_menu.Width, 37);
            label_namamenu.Location = new Point(pb_menu.Left, pb_menu.Bottom + 4);
            //label_namamenu.BorderStyle = BorderStyle.FixedSingle;
            label_namamenu.BackColor = Color.FromArgb(161, 161, 161);
            label_namamenu.ForeColor = Color.White;
            label_namamenu.TextAlign = ContentAlignment.TopCenter;
            label_namamenu.MouseEnter += mouseEnter;
            label_namamenu.Click += plusOrder;
            label_namamenu.MouseLeave += mouseLeave;
            panel_listmenu.Controls.Add(label_namamenu);
            label_namamenu.BringToFront();

            Label label_harga = new Label();
            label_harga.Tag = idMenu;
            label_harga.Text = $"Rp{harga},-";
            label_harga.Font = new Font("Montserrat", 8, FontStyle.Bold);
            label_harga.AutoSize = false;
            label_harga.Size = new Size(pb_menu.Width, 20);
            label_harga.Location = new Point(pb_menu.Left, label_namamenu.Bottom);
            //label_harga.BorderStyle = BorderStyle.FixedSingle;
            label_harga.BackColor = Color.FromArgb(161, 161, 161);
            label_harga.ForeColor = Color.White;
            label_harga.TextAlign = ContentAlignment.TopCenter;
            label_harga.MouseEnter += mouseEnter;
            label_harga.Click += plusOrder;
            label_harga.MouseLeave += mouseLeave;
            panel_listmenu.Controls.Add(label_harga);
            label_harga.BringToFront();

            panel_orderlist.Size = new Size(455, 420);
            panel_orderlist.Location = new Point(panel_listmenu.Right + 10, label_customername.Top + 5);
            panel_orderlist.UseTransparentBackground = true;
            panel_orderlist.BorderThickness = 0;
            panel_orderlist.BorderColor = Color.Black;
            this.Controls.Add(panel_orderlist);
            panel_orderlist.BringToFront();
        }

        private void showOrderList()
        {
            panel_orderlist.Controls.Clear();

            Guna2PictureBox pb_background_orderlist = new Guna2PictureBox();
            pb_background_orderlist.Image = Image.FromFile($@"resources\K_rectangle_bg_orderlist.png");
            pb_background_orderlist.SizeMode = PictureBoxSizeMode.Zoom;
            pb_background_orderlist.Size = new Size(455, 360);
            pb_background_orderlist.Location = new Point(0, 0);
            pb_background_orderlist.UseTransparentBackground = true;
            pb_background_orderlist.BorderStyle = BorderStyle.None;
            panel_orderlist.Controls.Add(pb_background_orderlist);
            pb_background_orderlist.BringToFront();

            Label label_orderlist = new Label();
            label_orderlist.Text = "Order List";
            label_orderlist.Font = new Font("Montserrat", 10, FontStyle.Bold);
            label_orderlist.Location = new Point(pb_background_orderlist.Left + 10, pb_background_orderlist.Top + 15);
            //label_harga.BorderStyle = BorderStyle.FixedSingle;
            label_orderlist.Parent = pb_background_orderlist;
            label_orderlist.BackColor = Color.FromArgb(255, 99, 99, 99);
            label_orderlist.ForeColor = Color.White;
            panel_orderlist.Controls.Add(label_orderlist);
            label_orderlist.BringToFront();

            Guna2PictureBox pb_background_orderlist_2 = new Guna2PictureBox();
            pb_background_orderlist_2.Image = Image.FromFile($@"resources\K_rectangle_bg_orderlist_2.png");
            pb_background_orderlist_2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_background_orderlist_2.Size = new Size(435, 300);
            pb_background_orderlist_2.Location = new Point(pb_background_orderlist.Left + 10, pb_background_orderlist.Top + 30);
            pb_background_orderlist_2.UseTransparentBackground = true;
            pb_background_orderlist_2.BorderStyle = BorderStyle.None;
            panel_orderlist.Controls.Add(pb_background_orderlist_2);
            pb_background_orderlist_2.BringToFront();

            //panel_orderlist_2 = new Guna2Panel();
            //panel_orderlist_2.Size = new Size(pb_background_orderlist_2.Width, pb_background_orderlist_2.Height);
            //panel_orderlist_2.Location = new Point(pb_background_orderlist_2.Left, pb_background_orderlist_2.Top);
            //panel_orderlist_2.UseTransparentBackground = true;
            //panel_orderlist_2.BorderThickness = 0;
            //panel_orderlist_2.BorderColor = Color.Black;
            //panel_orderlist.Controls.Add(panel_orderlist_2);
            //panel_orderlist_2.BringToFront();

            Guna2PictureBox pb_confirmorder = new Guna2PictureBox();
            pb_confirmorder.Image = Image.FromFile($@"resources\K_button_confirmorder.png");
            pb_confirmorder.SizeMode = PictureBoxSizeMode.Zoom;
            pb_confirmorder.Size = new Size(200, 50);
            pb_confirmorder.Location = new Point(pb_background_orderlist.Left, pb_background_orderlist.Bottom + 5);
            pb_confirmorder.UseTransparentBackground = true;
            pb_confirmorder.BorderStyle = BorderStyle.None;
            pb_confirmorder.Click += confirmOrder;
            pb_confirmorder.MouseEnter += mouseEnter;
            pb_confirmorder.MouseLeave += mouseLeave;
            panel_orderlist.Controls.Add(pb_confirmorder);
            pb_confirmorder.BringToFront();
            
            //panel_orderlist_2.Controls.Clear();
            if (list_idmenu.Count > 0)
            {
                for (int i = 0; i < list_idmenu.Count; i++)
                {
                    dtMenu = new DataTable();
                    string namamenu = "";
                    int jumlah = 0;
                    try
                    {
                        form_Main.sqlQuery = $"SELECT * FROM menu;";
                        form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
                        form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
                        form_Main.sqlAdapter.Fill(dtMenu);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    for (int j = 0; j < dtMenu.Rows.Count; j++)
                    {
                        if (dtMenu.Rows[j][0].ToString() == list_idmenu[i])
                        {
                            namamenu = dtMenu.Rows[j][1].ToString();
                            jumlah = list_jumlah[i];
                        }
                    }
                    //MessageBox.Show(namamenu);
                    Label label_namamenu = new Label();
                    label_namamenu.Text = namamenu;
                    label_namamenu.Location = new Point(pb_background_orderlist_2.Left + 18, pb_background_orderlist_2.Top + (i + 1) * 30);
                    label_namamenu.Font = new Font("Montserrat", 10, FontStyle.Bold);
                    label_namamenu.AutoSize = false;
                    label_namamenu.Size = new Size(200, 20);
                    //label_namamenu.BorderStyle = BorderStyle.FixedSingle;
                    label_namamenu.Parent = pb_background_orderlist_2;
                    label_namamenu.BackColor = Color.White;
                    label_namamenu.ForeColor = Color.FromArgb(255, 89, 89, 89);
                    panel_orderlist.Controls.Add(label_namamenu);
                    //MessageBox.Show(namamenu);
                    label_namamenu.BringToFront();

                    Guna2PictureBox pb_min = new Guna2PictureBox();
                    pb_min.Image = Image.FromFile($@"resources\K_icon_min.png");
                    pb_min.SizeMode = PictureBoxSizeMode.Zoom;
                    pb_min.Size = new Size(20, 20);
                    pb_min.Location = new Point(label_namamenu.Right + 10, pb_background_orderlist_2.Top + (i + 1) * 30);
                    pb_min.UseTransparentBackground = true;
                    //pb_min.BorderStyle = BorderStyle.FixedSingle;
                    pb_min.Click += minOrder;
                    pb_min.Tag += list_idmenu[i];
                    pb_min.MouseEnter += mouseEnter;
                    pb_min.MouseLeave += mouseLeave;
                    panel_orderlist.Controls.Add(pb_min);
                    pb_min.BringToFront();

                    Guna2PictureBox pb_bg_qty = new Guna2PictureBox();
                    pb_bg_qty.Image = Image.FromFile($@"resources\K_bg_qty.png");
                    pb_bg_qty.SizeMode = PictureBoxSizeMode.Zoom;
                    pb_bg_qty.Size = new Size(50, 25);
                    pb_bg_qty.Location = new Point(pb_min.Right + 10, pb_background_orderlist_2.Top + (i + 1) * 28);
                    pb_bg_qty.UseTransparentBackground = true;
                    pb_bg_qty.BorderStyle = BorderStyle.None;
                    panel_orderlist.Controls.Add(pb_bg_qty);
                    pb_bg_qty.SendToBack();


                    Label label_jumlah = new Label();
                    label_jumlah.Text = jumlah.ToString();
                    label_jumlah.Tag = IDmenu;
                    counter++;
                    //listjumlah.Add(label_jumlah.Tag.ToString());
                    //MessageBox.Show(listjumlah[0]);
                    label_jumlah.Location = new Point(pb_min.Right + 13, pb_background_orderlist_2.Top + (i + 1) * 30);
                    label_jumlah.Font = new Font("Montserrat", 10, FontStyle.Bold);
                    label_jumlah.AutoSize = false;
                    label_jumlah.Size = new Size(50, 20);
                    //label_jumlah.BorderStyle = BorderStyle.FixedSingle;
                    label_jumlah.Parent = pb_background_orderlist_2;
                    label_jumlah.BackColor = Color.White;
                    label_jumlah.ForeColor = Color.Black;
                    label_jumlah.TextAlign = ContentAlignment.MiddleCenter;
                    panel_orderlist.Controls.Add(label_jumlah);
                    label_jumlah.BringToFront();
                    //MessageBox.Show(label_jumlah.Location.ToString());

                    Guna2PictureBox pb_plus = new Guna2PictureBox();
                    pb_plus.Image = Image.FromFile($@"resources\K_icon_plus.png");
                    pb_plus.SizeMode = PictureBoxSizeMode.Zoom;
                    pb_plus.Size = new Size(20, 20);
                    pb_plus.Location = new Point(pb_bg_qty.Right + 10, pb_background_orderlist_2.Top + (i + 1) * 30);
                    pb_plus.UseTransparentBackground = true;
                    //pb_plus.BorderStyle = BorderStyle.FixedSingle;
                    pb_plus.Click += plusOrder;
                    pb_plus.Tag += list_idmenu[i];
                    pb_plus.MouseEnter += mouseEnter;
                    pb_plus.MouseLeave += mouseLeave;
                    panel_orderlist.Controls.Add(pb_plus);
                    pb_plus.BringToFront();
                } 
            }
        }

        //private void menuClick(object sender, EventArgs e)
        //{
        //    //IDmenu = "";
        //    Label label = sender as Label;
        //    PictureBox pictureBox = sender as PictureBox;
        //    if (label != null)
        //    {
        //        //MessageBox.Show(label.Tag.ToString());
        //        IDmenu = label.Tag.ToString();
        //        MessageBox.Show(label.Tag.ToString());
        //        listjumlah.Add(IDmenu);
        //        //MessageBox.Show("id menu" + IDmenu);
        //    }
        //    else if (pictureBox != null)
        //    {
        //        //MessageBox.Show(pictureBox.Tag.ToString());
        //        IDmenu = pictureBox.Tag.ToString();
        //        //MessageBox.Show("id menu" + IDmenu);
        //    }

        //    if (list_idmenu.Contains(IDmenu) == false)
        //    {
        //        list_idmenu.Add(IDmenu);
        //        list_jumlah.Add(1);
        //        //MessageBox.Show(list_jumlah[0].ToString());
        //    }
        //    else
        //    {
        //        for (int i = 0; i < list_idmenu.Count; i++)
        //        {
        //            //MessageBox.Show("list idmenu i = " + list_idmenu[i].ToString() + IDmenu);
        //            if (list_idmenu[i].ToString() == IDmenu)
        //            {
        //                //MessageBox.Show(list_idmenu[i].ToString(), IDmenu);
        //                //MessageBox.Show("jalan");
        //                list_jumlah[i]++;
        //            }
        //        }
        //    }
        //    panel_orderlist_2.Controls.Clear();
        //    if (list_idmenu.Count > 0)
        //    {
        //        for (int i = 0; i < list_idmenu.Count; i++)
        //        {
        //            Label label_namamenu = new Label();
        //            Label label_jumlah = new Label();
        //            dtMenu = new DataTable();
        //            string namamenu = "";
        //            int jumlah = 0;
        //            try
        //            {
        //                form_Main.sqlQuery = $"SELECT * FROM menu;";
        //                form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
        //                form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
        //                form_Main.sqlAdapter.Fill(dtMenu);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }
        //            for (int j = 0; j < dtMenu.Rows.Count; j++)
        //            {
        //                if (dtMenu.Rows[j][0].ToString() == list_idmenu[i])
        //                {
        //                    namamenu = dtMenu.Rows[j][1].ToString();
        //                    jumlah = list_jumlah[i];
        //                }
        //            }
        //            //MessageBox.Show(namamenu);
        //            label_namamenu.Text = namamenu;
        //            label_namamenu.Location = new Point(panel_orderlist_2.Left + 8, panel_orderlist_2.Top + i * 30);
        //            label_namamenu.Font = new Font("Montserrat", 10, FontStyle.Bold);
        //            label_namamenu.AutoSize = false;
        //            label_namamenu.Size = new Size(200, 20);
        //            //label_namamenu.BorderStyle = BorderStyle.FixedSingle;
        //            label_namamenu.Parent = panel_orderlist_2;
        //            label_namamenu.BackColor = Color.Transparent;
        //            label_namamenu.ForeColor = Color.FromArgb(255, 89, 89, 89);
        //            panel_orderlist_2.Controls.Add(label_namamenu);
        //            label_namamenu.BringToFront();

        //            Guna2PictureBox pb_min = new Guna2PictureBox();
        //            pb_min.Image = Image.FromFile($@"resources\K_icon_min.png");
        //            pb_min.SizeMode = PictureBoxSizeMode.Zoom;
        //            pb_min.Size = new Size(20, 20);
        //            pb_min.Location = new Point(label_namamenu.Right + 10, panel_orderlist_2.Top + (i + 1) * 30);
        //            pb_min.UseTransparentBackground = true;
        //            pb_min.BorderStyle = BorderStyle.None;
        //            pb_min.Click += minOrder;
        //            pb_min.Tag += IDmenu;
        //            pb_min.MouseEnter += mouseEnter;
        //            pb_min.MouseLeave += mouseLeave;
        //            panel_orderlist.Controls.Add(pb_min);
        //            pb_min.BringToFront();

        //            Guna2PictureBox pb_bg_qty = new Guna2PictureBox();
        //            pb_bg_qty.Image = Image.FromFile($@"resources\K_bg_qty.png");
        //            pb_bg_qty.SizeMode = PictureBoxSizeMode.Zoom;
        //            pb_bg_qty.Size = new Size(50, 25);
        //            pb_bg_qty.Location = new Point(pb_min.Right + 10, panel_orderlist_2.Top + (i + 1) * 28);
        //            pb_bg_qty.UseTransparentBackground = true;
        //            pb_bg_qty.BorderStyle = BorderStyle.None;
        //            panel_orderlist.Controls.Add(pb_bg_qty);
        //            pb_bg_qty.SendToBack();


        //            label_jumlah.Text = jumlah.ToString();
        //            label_jumlah.Tag += IDmenu;
        //            label_jumlah.Location = new Point(pb_min.Right + 13, panel_orderlist_2.Top + i * 30);
        //            label_jumlah.Font = new Font("Montserrat", 10, FontStyle.Bold);
        //            label_jumlah.AutoSize = false;
        //            label_jumlah.Size = new Size(50, 20);
        //            //label_namamenu.BorderStyle = BorderStyle.FixedSingle;
        //            label_jumlah.Parent = panel_orderlist_2;
        //            //label_jumlah.BackColor = Color.Transparent;
        //            label_jumlah.ForeColor = Color.Black;
        //            panel_orderlist_2.Controls.Add(label_jumlah);
        //            label_jumlah.BringToFront();
        //            //MessageBox.Show(label_jumlah.Location.ToString());

        //            Guna2PictureBox pb_plus = new Guna2PictureBox();
        //            pb_plus.Image = Image.FromFile($@"resources\K_icon_plus.png");
        //            pb_plus.SizeMode = PictureBoxSizeMode.Zoom;
        //            pb_plus.Size = new Size(20, 20);
        //            pb_plus.Location = new Point(pb_bg_qty.Right + 10, panel_orderlist_2.Top + (i + 1) * 30);
        //            pb_plus.UseTransparentBackground = true;
        //            pb_plus.BorderStyle = BorderStyle.None;
        //            pb_plus.Click += plusOrder;
        //            pb_plus.Tag += IDmenu;
        //            pb_plus.MouseEnter += mouseEnter;
        //            pb_plus.MouseLeave += mouseLeave;
        //            panel_orderlist.Controls.Add(pb_plus);
        //            pb_plus.BringToFront();
        //        }
        //    }
        //}

        private void minOrder(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            IDmenu_edit = pictureBox.Tag.ToString();
            //MessageBox.Show(IDmenu_edit);
            for (int i = 0; i < list_idmenu.Count; i++)
            {
                if (list_idmenu[i] == IDmenu_edit)
                {
                    list_jumlah[i]--;
                    if (list_jumlah[i] == 0)
                    {
                        list_jumlah.RemoveAt(i);
                        list_idmenu.RemoveAt(i);
                    }
                }
            }
            showOrderList();
        }

        private void plusOrder(object sender, EventArgs e)
        {
            Label label = sender as Label;
            PictureBox pictureBox = sender as PictureBox;
            //IDmenu_edit = pictureBox.Tag.ToString();

            //IDmenu = "";
            //Label label = sender as Label;
            //PictureBox pictureBox = sender as PictureBox;
            if (label != null)
            {
                //MessageBox.Show(label.Tag.ToString());
                IDmenu = label.Tag.ToString();
                MessageBox.Show(label.Tag.ToString());
                listjumlah.Add(IDmenu);
                //MessageBox.Show("id menu" + IDmenu);
            }
            else if (pictureBox != null)
            {
                //MessageBox.Show(pictureBox.Tag.ToString());
                IDmenu = pictureBox.Tag.ToString();
                //MessageBox.Show("id menu" + IDmenu);
            }

            if (list_idmenu.Contains(IDmenu) == false)
            {
                list_idmenu.Add(IDmenu);
                list_jumlah.Add(1);
                //MessageBox.Show(list_jumlah[0].ToString());
            }
            else
            {
                for (int i = 0; i < list_idmenu.Count; i++)
                {
                    //MessageBox.Show("list idmenu i = " + list_idmenu[i].ToString() + IDmenu);
                    if (list_idmenu[i].ToString() == IDmenu)
                    {
                        //MessageBox.Show(list_idmenu[i].ToString(), IDmenu);
                        //MessageBox.Show("jalan");
                        list_jumlah[i]++;
                    }
                }
            }


            //for (int i = 0; i < list_idmenu.Count; i++)
            //{
            //    if (list_idmenu[i] == IDmenu_edit)
            //    {
            //        list_jumlah[i]++;
            //    }
            //}
            showOrderList();

        }

        private void confirmOrder(object sender, EventArgs e)
        {
            string custID = "";
            PictureBox pictureBox = sender as PictureBox;
            if (tb_customername.Text == "")
            {
                MessageBox.Show("Masukkan nama customer");
            }
            else
            {
                if (list_idmenu.Count < 1)
                {
                    MessageBox.Show("Silakan isi pesanan terlebih dahulu!");
                }
                else
                {
                    try
                    {
                        dtidcust = new DataTable();
                        form_Main.sqlQuery = $"(SELECT fAutoGenIDcustomer('{tb_customername.Text.ToUpper()}'))";
                        form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
                        form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
                        form_Main.sqlAdapter.Fill(dtidcust);
                        MessageBox.Show(dtidcust.Rows[0][0].ToString());
                        custID = dtidcust.Rows[0][0].ToString();


                        form_Main.sqlQuery = $"INSERT INTO customer VALUES\r\n('{custID}', '{tb_customername.Text}', 0);";
                        form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
                        form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
                        form_Main.sqlDataReader = form_Main.sqlCommand.ExecuteReader();
                        form_Main.sqlDataReader.Close();
                        //MessageBox.Show(list_label_jumlah.Count().ToString());

                        for (int i = 0; i < list_idmenu.Count; i++)
                        {
                            //MessageBox.Show(" a");
                            
                            form_Main.sqlQuery = $"INSERT INTO pesan VALUES\r\n((SELECT fAutoGenIDOrder()), '{list_idmenu[i]}', '2023-12-06', {list_jumlah[i]}, 'U001', '{custID}','ON PROGRESS', 0);";
                            form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
                            form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
                            form_Main.sqlDataReader = form_Main.sqlCommand.ExecuteReader();
                            form_Main.sqlDataReader.Close();
                        }
                        MessageBox.Show("Order berhasil disimpan!");
                        tb_customername.Clear();
                        //panel_orderlist_2.Controls.Clear();
                        panel_orderlist.Controls.Clear();
                        list_idmenu.Clear();
                        list_jumlah.Clear();
                        showOrderList();


                        //form_Main.sqlQuery = $"SELECT * FROM menu;";
                        //form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
                        //form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
                        //form_Main.sqlAdapter.Fill(dtMenu);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //IDmenu_edit = pictureBox.Tag.ToString();
            //for (int i = 0; i < list_idmenu.Count; i++)
            //{
            //    if (list_idmenu[i] == IDmenu_edit)
            //    {
            //        list_jumlah[i]++;
            //    }
            //}
            //showOrderList();

        }

            //private void panel_listmenu_Scroll(object sender, ScrollEventArgs e)
            //{
            //    panel_listmenu.Refresh();
            //}
        }
    }
