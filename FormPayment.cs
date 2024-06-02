using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ALP_SAD_DBI
{
    public partial class FormPayment : Form
    {
        DataTable dtCustName = new DataTable();
        DataTable dtSimpanPayment = new DataTable();
        Form_Main form_Main = Application.OpenForms["form_Main"] as Form_Main;

        Bitmap memoryImage;
        public FormPayment()
        {
            InitializeComponent();
            form_Main.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=secu");
            form_Main.sqlConnect.Open();
        }

        PictureBox makeorder = new PictureBox();
        PictureBox payment = new PictureBox();
        PictureBox checkorder = new PictureBox();
        Font BigFont = new Font("Montserrat", 30);

        Button Open = new Button();
        Button Print = new Button();

        Panel print = new Panel();
        

        Guna2Panel panelPayment = new Guna2Panel();
        ComboBox comboboxCustName = new ComboBox();

        private void FormPayment_Load(object sender, EventArgs e)
        {
            dtCustName.Rows.Clear();
            pb_bg.Size = new Size(1280, 590);
            pb_bg.Location = new Point(0, 0);
            pb_bg.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_bg.BorderStyle = BorderStyle.None;
            pb_bg.SendToBack();

            panelPayment.Size = new Size(1278, 528);
            panelPayment.Location = new Point(0, 0);
            panelPayment.Parent = pb_bg;
            panelPayment.UseTransparentBackground = true;
            this.Controls.Add(panelPayment);
            panelPayment.BringToFront();

            PictureBox Payment = new PictureBox();
            Payment.Size = new Size(152, 55);
            Payment.Location = new Point(63, 20);
            Payment.Image = Image.FromFile(@"D:\SAD - AFL 3 PROJECT\T_PAYMENTBSR.png");
            Payment.BackColor = Color.Transparent;
            //Payment.BorderStyle = BorderStyle.FixedSingle;
            Payment.SizeMode = PictureBoxSizeMode.Zoom;
            panelPayment.Controls.Add(Payment);
            Payment.BringToFront();

            comboboxCustName.Size = new Size(300, 120);
            comboboxCustName.Location = new Point(70, 100);
            comboboxCustName.BackColor = Color.Chocolate;
            comboboxCustName.ForeColor = Color.White;
            panelPayment.Controls.Add(comboboxCustName);
            comboboxCustName.BringToFront();

            form_Main.sqlQuery = "SELECT IDcustomer,nama_customer FROM customer;";
            form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
            form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
            form_Main.sqlAdapter.Fill(dtCustName);
            comboboxCustName.DataSource = dtCustName;
            comboboxCustName.ValueMember = "IDcustomer";
            comboboxCustName.DisplayMember = "nama_customer";
            comboboxCustName.SelectionChangeCommitted += comboboxCustName_SelectionChangeCommitted;

            comboboxCustName.Font = new Font("Montserrat", 12, FontStyle.Regular);

            //Button Open Payment
            Open.Size = new Size(90, 33);
            Open.Location = new Point(comboboxCustName.Right + 20, comboboxCustName.Top);
            Open.BackColor = Color.Chocolate;
            Open.Text = "OPEN";
            Open.Font = new Font("Montserrat", 12, FontStyle.Regular);
            Open.ForeColor = Color.White;
            //Open.ForeColor = Color.White;
            Open.Click += comboboxCustName_ClickPayment;
            panelPayment.Controls.Add(Open);
            Open.BringToFront();

            //Button Print
            Print.Size = new Size(90, 33);
            Print.Location = new Point(1150, 440);
            Print.BackColor = Color.Chocolate;
            Print.Text = "PRINT";
            Print.Font = new Font("Montserrat", 12, FontStyle.Regular);
            Print.ForeColor = Color.White;
            //Print.Click += comboboxCustName_ClickPayment;
            Print.Click += BtnPrint;
            panelPayment.Controls.Add(Print);
            Print.BringToFront();

            Button Close = new Button();
            Close.Size = new Size(90, 66);
            Close.Location = new Point(1150, 360);
            Close.BackColor = Color.Chocolate;
            Close.Text = "Close\nPrint Display";
            Close.Font = new Font("Montserrat Bold", 9, FontStyle.Bold);
            Close.ForeColor = Color.White;
            Close.Click += closePrint;
            panelPayment.Controls.Add(Close);
            Close.BringToFront();


        }

        private void BtnPaymentClick(object sender, EventArgs e)
        {

            statusDisplayBTN = false;
            dtCustName.Rows.Clear();
            panelPayment.Controls.Clear();
            payment.Image = Image.FromFile(@"D:\SAD - AFL 3 PROJECT\T_PAYMENTSELECT.png");
            checkorder.Image = Image.FromFile(@"D:\SAD - AFL 3 PROJECT\T_CHECKORDER.png");

            PictureBox Payment = new PictureBox();
            Payment.Size = new Size(372, 123);
            Payment.Location = new Point(73, 70);
            Payment.Image = Image.FromFile(@"D:\SAD - AFL 3 PROJECT\T_PAYMENTBSR.png");
            Payment.BackColor = Color.Transparent;
            panelPayment.Controls.Add(Payment);
            Payment.BringToFront();

            Open.Location = new Point(520, 220);
            comboboxCustName.Location = new Point(73, 220);
            panelPayment.Controls.Add(comboboxCustName);
            comboboxCustName.BringToFront();

            form_Main.sqlQuery = "SELECT IDcustomer,nama_customer FROM customer;";
            form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
            form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
            form_Main.sqlAdapter.Fill(dtCustName);
            comboboxCustName.DataSource = dtCustName;
            comboboxCustName.ValueMember = "IDcustomer";
            comboboxCustName.DisplayMember = "nama_customer";
            comboboxCustName.Font = new Font("Montserrat Bold", 15, FontStyle.Bold);

            panelPayment.Controls.Add(Open);
            Open.BringToFront();


            //Button Print
            Print.Size = new Size(90, 33);
            Print.Location = new Point(1750, 600);
            Print.BackColor = Color.Chocolate;
            Print.Text = "PRINT";
            Print.Font = new Font("Montserrat Bold", 15, FontStyle.Bold);
            Print.Click += BtnPrint;
            panelPayment.Controls.Add(Print);
            Print.BringToFront();

            Button Close = new Button();
            Close.Size = new Size(90, 66);
            Close.Location = new Point(1750, 520);
            Close.BackColor = Color.Chocolate;
            Close.Text = "Close\nPrint Display";
            Close.Font = new Font("Montserrat Bold", 9, FontStyle.Bold);
            Close.Click += closePrint;
            panelPayment.Controls.Add(Close);
            Close.BringToFront();



        }

        private void comboboxCustName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Panel display = new Panel();
            //display.Size = new Size(780, 300);
            //display.Location = new Point(1000, 100);
            //display.BackColor = Color.Orange;
            //this.Controls.Add(display);
            //display.BringToFront();
        }

        List<Button> status = new List<Button>(10);
        bool statusDisplayBTN = false;
        private void BtnCheckOrder(object sender, EventArgs e)
        {
            statusDisplayBTN = true;
            panelPayment.Controls.Clear();
            this.Controls.Remove(display);
            dtCustName.Rows.Clear();

            payment.Image = Image.FromFile(@"D:\SAD - AFL 3 PROJECT\T_PAYMENT.png");
            checkorder.Image = Image.FromFile(@"D:\SAD - AFL 3 PROJECT\T_CHECKORDERSELECTED.png");

            PictureBox CheckOrderTXT = new PictureBox();
            CheckOrderTXT.Size = new Size(372, 38);
            CheckOrderTXT.Location = new Point(73, 70);
            CheckOrderTXT.Image = Image.FromFile(@"D:\SAD - AFL 3 PROJECT\T_CHECK ORDER.png");
            CheckOrderTXT.BackColor = Color.Transparent;
            panelPayment.Controls.Add(CheckOrderTXT);

            comboboxCustName.Location = new Point(73, 140);
            panelPayment.Controls.Add(comboboxCustName);
            comboboxCustName.BringToFront();

            form_Main.sqlQuery = "SELECT IDcustomer,nama_customer FROM customer;";
            form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
            form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
            form_Main.sqlAdapter.Fill(dtCustName);
            comboboxCustName.DataSource = dtCustName;
            comboboxCustName.ValueMember = "IDcustomer";
            comboboxCustName.DisplayMember = "nama_customer";

            comboboxCustName.Font = new Font("Montserrat Bold", 15, FontStyle.Bold);

            Open.Size = new Size(90, 33);
            Open.Location = new Point(520, 140);
            Open.BackColor = Color.Chocolate;
            Open.Text = "OPEN";
            Open.Font = new Font("Montserrat Bold", 15, FontStyle.Bold);
            //Open.ForeColor = Color.White;
            Open.Click += comboboxCustName_ClickPayment;
            panelPayment.Controls.Add(Open);
            Open.BringToFront();
        }

        private void statusDoneClick(object sender, EventArgs e)
        {
            Button apa = sender as Button;
            // MessageBox.Show(apa.Tag.ToString()); CHECK
            for (int i = 0; i < dtSimpanPayment.Rows.Count; i++)
            {
                if (status[i].Tag.ToString() == apa.Tag.ToString())
                {
                    if (status[i].Text == "ON PROGRESS") // - ke done
                    {
                        status[i].ForeColor = Color.Green;
                        status[i].Text = "DONE";
                        string command = $"UPDATE Pesan SET done = 'DONE' WHERE IDorder = '{dtSimpanPayment.Rows[i][4].ToString()}';";

                        try
                        {
                            form_Main.sqlConnect.Open();
                            form_Main.sqlCommand = new MySqlCommand(command, form_Main.sqlConnect);
                            int rowsAffected = form_Main.sqlCommand.ExecuteNonQuery();
                            MessageBox.Show($"{rowsAffected} row(s) updated successfully.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            form_Main.sqlConnect.Close();
                        }
                    }
                    else
                    {
                        status[i].ForeColor = Color.Black; // done ke -
                        status[i].Text = "ON PROGRESS";
                        string command = $"UPDATE Pesan SET done = 'ON PROGRESS' WHERE IDorder = '{dtSimpanPayment.Rows[i][4].ToString()}';";

                        try
                        {
                            form_Main.sqlConnect.Open();
                            form_Main.sqlCommand = new MySqlCommand(command, form_Main.sqlConnect);
                            int rowsAffected = form_Main.sqlCommand.ExecuteNonQuery();
                            MessageBox.Show($"{rowsAffected} row(s) updated successfully.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            form_Main.sqlConnect.Close();
                        }
                    }
                    break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void comboboxCustNameprivatobject sender, MouseEventArgs e)
        Panel display = new Panel();

        string TglPemesanan = "";
        string IDOrder = "";
        private void comboboxCustName_ClickPayment(object sender, EventArgs e) //PANEL
        {
            dtSimpanPayment.Rows.Clear();
            display.Size = new Size(605, 360);
            display.Location = new Point(Open.Right + 30, Open.Top);
            display.BackColor = Color.Gray;
            display.BorderStyle = BorderStyle.Fixed3D;
            display.Controls.Clear();
            this.Controls.Remove(display);
            this.Controls.Add(display);
            display.BringToFront();

            Label DetailPesanan = new Label();
            DetailPesanan.Text = "Detail Pesanan";
            DetailPesanan.Font = new Font("Montserrat", 14, FontStyle.Bold);
            DetailPesanan.TextAlign = ContentAlignment.MiddleCenter;
            DetailPesanan.ForeColor = Color.White;
            DetailPesanan.AutoSize = false;
            DetailPesanan.Size = new Size(display.Width, 40);
            //DetailPesanan.BorderStyle = BorderStyle.FixedSingle;
            DetailPesanan.Location = new Point(DetailPesanan.Left, DetailPesanan.Top + 10);
            display.Controls.Add(DetailPesanan);

            //Label t = new Label();
            //t.Text = "Detail Pesanan";
            //t.Font = new Font("Montserrat", 22, FontStyle.Bold);
            //t.ForeColor = Color.White;
            //t.Size = new Size(300, 40);
            //t.Location = new Point(30, 100);
            //display.Controls.Add(t);

            form_Main.sqlQuery = $"SELECT m.nama_menu, m.harga, p.jumlah_pes, p.tglOrder,p.IDorder,p.done FROM menu m LEFT JOIN pesan p ON p.IDmenu = m.IDmenu WHERE p.IDcustomer = '{comboboxCustName.SelectedValue.ToString()}';";
            form_Main.sqlCommand = new MySqlCommand(form_Main.sqlQuery, form_Main.sqlConnect);
            form_Main.sqlAdapter = new MySqlDataAdapter(form_Main.sqlCommand);
            form_Main.sqlAdapter.Fill(dtSimpanPayment);

            int x = 15;
            int y = 120;
            //
            int a = 750;
            int b = 120;

            Label JDL = new Label();
            JDL.Text = $"NAMA MENU                          Pcs                 JUMLAH";
            JDL.Font = new Font("Montserrat", 15, FontStyle.Bold);
            JDL.ForeColor = Color.White;
            JDL.Size = new Size(700, 40);
            JDL.Location = new Point(15, 80);
            display.Controls.Add(JDL);

            if (dtSimpanPayment.Rows.Count > 0)
            {
                TglPemesanan = dtSimpanPayment.Rows[1][3].ToString();
                IDOrder = dtSimpanPayment.Rows[1][4].ToString();
            }
            else
            {
                TglPemesanan = "";
                IDOrder = "";
            }


            if (dtSimpanPayment.Rows.Count > 0)
            {
                status.Clear();
                int total = 0;
                int totalHarga = 0;
                for (int i = 0; i < dtSimpanPayment.Rows.Count; i++)
                {
                    string namaMenu = dtSimpanPayment.Rows[i][0].ToString();
                    int jumlahPesanan = int.Parse(dtSimpanPayment.Rows[i][1].ToString());
                    int hargaMenu = int.Parse(dtSimpanPayment.Rows[i][2].ToString());
                    totalHarga = jumlahPesanan * hargaMenu;
                    total += totalHarga;
                    //MASIH BELUM RAPIH TLG RAPIHIN
                    string displayText = $"{namaMenu.ToString().PadRight(35, ' ')} {hargaMenu.ToString().PadRight(10, ' ')} {totalHarga.ToString()}";

                    Label pilihanMenu = new Label
                    {
                        Text = namaMenu,
                        Font = new Font("Montserrat", 15, FontStyle.Regular),
                        ForeColor = Color.White,
                        Size = new Size(300, 40),
                        Location = new Point(x, y)
                    };
                    Label pilihanPcs = new Label
                    {
                        Text = hargaMenu.ToString(),
                        Font = new Font("Montserrat", 15, FontStyle.Regular),
                        ForeColor = Color.White,
                        Size = new Size(100, 40),
                        Location = new Point(x+300, y)
                    };
                    Label pilihanJumlah = new Label
                    {
                        Text = totalHarga.ToString(),
                        Font = new Font("Montserrat", 15, FontStyle.Regular),
                        ForeColor = Color.White,
                        Size = new Size(100, 40),
                        Location = new Point(x + 400, y),
                        AutoSize = false,
                        RightToLeft=RightToLeft.Yes
                    };

                    display.Controls.Add(pilihanMenu);
                    display.Controls.Add(pilihanJumlah);
                    display.Controls.Add(pilihanPcs);
                    y += 45;
                    if (statusDisplayBTN == true)
                    {
                        Button Stts = new Button();
                        Stts.Size = new Size(120, 33);
                        Stts.Location = new Point(a, b);
                        Stts.BackColor = Color.White;
                        Stts.Text = dtSimpanPayment.Rows[i][5].ToString();
                        Stts.Font = new Font("Montserrat Bold", 9, FontStyle.Bold);
                        if (Stts.Text == "DONE")
                        {
                            Stts.ForeColor = Color.Green;
                        }
                        else
                        {
                            Stts.ForeColor = Color.Black;
                        }
                        Stts.Click += statusDoneClick;
                        Stts.Tag = $"Status {i.ToString()}";
                        display.Controls.Add(Stts);
                        Stts.BringToFront();
                        status.Add(Stts);
                        b += 45;
                    }
                }
                Label TotalHarga = new Label
                {
                    Text = $"---------------------------------\nTotal :                       Rp.{total.ToString()}",
                    Font = new Font("Montserrat", 15, FontStyle.Regular),
                    ForeColor = Color.White,
                    Size = new Size(800, 80),
                    Location = new Point(300, 400)
                };
                display.Controls.Add(TotalHarga);
                display.AutoScroll = true;
            }
            //label1.Text = comboboxCustName.SelectedValue.ToString();

        }

        private void BtnPrint(object sender, EventArgs e)
        {
            print.Enabled = true;
            print.Visible = true;
            print.Controls.Clear();
            print.Size = new Size(632, 500); //732
            print.Location = new Point(255, 0);
            print.BackColor = Color.White;
            print.AutoScroll = true;
            this.Controls.Add(print);
            print.BringToFront();

            Button PrintOK = new Button();
            PrintOK.Size = new Size(60, 33);
            PrintOK.Location = new Point(550, 680);
            PrintOK.BackColor = Color.Chocolate;
            PrintOK.Text = "PRINT";
            PrintOK.Font = new Font("Montserrat Bold", 9, FontStyle.Bold);
            PrintOK.Click += printOK;
            print.Controls.Add(PrintOK);
            PrintOK.BringToFront();


            Label JDL = new Label();
            JDL.Text = $"Bebek Lumer Mbak Siti";
            JDL.Font = new Font("Montserrat", 15, FontStyle.Bold);
            JDL.ForeColor = Color.Black;
            JDL.Size = new Size(700, 25);
            JDL.Location = new Point(200, 10);
            print.Controls.Add(JDL);

            Label Alamat = new Label();
            Alamat.Text = $"Jl. Griya Babatan Mukti IX No.20A, Babatan, Kec. Wiyung, Surabaya, Jawa Timur 60227";
            Alamat.Font = new Font("Montserrat", 9, FontStyle.Regular);
            Alamat.ForeColor = Color.Black;
            Alamat.Size = new Size(700, 25);
            Alamat.Location = new Point(60, 50);
            Alamat.BackColor = Color.Transparent;
            Alamat.BringToFront();
            print.Controls.Add(Alamat);

            Label Garis = new Label();
            Garis.Text = $"---------------------------------------------------------------------------------------";
            Garis.Font = new Font("Montserrat", 15, FontStyle.Bold);
            Garis.ForeColor = Color.Black;
            Garis.Size = new Size(1000, 30);
            Garis.Location = new Point(0, 70);
            print.Controls.Add(Garis);

            Label txtIDpemesanan = new Label();
            txtIDpemesanan.Text = $"NO. Pemesanan : {IDOrder}";
            txtIDpemesanan.Font = new Font("Montserrat", 9, FontStyle.Regular);
            txtIDpemesanan.ForeColor = Color.Black;
            txtIDpemesanan.Size = new Size(700, 25);
            txtIDpemesanan.Location = new Point(10, 100);
            txtIDpemesanan.BackColor = Color.Transparent;
            txtIDpemesanan.BringToFront();
            print.Controls.Add(txtIDpemesanan);

            Label txttglwaktu = new Label();
            txttglwaktu.Text = $"Tgl/Waktu : {TglPemesanan}";
            txttglwaktu.Font = new Font("Montserrat", 9, FontStyle.Regular);
            txttglwaktu.ForeColor = Color.Black;
            txttglwaktu.Size = new Size(700, 25);
            txttglwaktu.Location = new Point(10, 125);
            txttglwaktu.BackColor = Color.Transparent;
            txttglwaktu.BringToFront();
            print.Controls.Add(txttglwaktu);

            Label txtStaff = new Label();
            txtStaff.Text = $"Staff :";
            txtStaff.Font = new Font("Montserrat", 9, FontStyle.Regular);
            txtStaff.ForeColor = Color.Black;
            txtStaff.Size = new Size(700, 25);
            txtStaff.Location = new Point(10, 150);
            txtStaff.BackColor = Color.Transparent;
            txtStaff.BringToFront();
            print.Controls.Add(txtStaff);

            Label Garis1 = new Label();
            Garis1.Text = $"---------------------------------------------------------------------------------------";
            Garis1.Font = new Font("Montserrat", 15, FontStyle.Bold);
            Garis1.ForeColor = Color.Black;
            Garis1.Size = new Size(1000, 30);
            Garis1.Location = new Point(0, 165);
            print.Controls.Add(Garis1);

            Label JDL1 = new Label();
            JDL1.Text = $"NAMA MENU                                  PCS                                  JUMLAH";
            JDL1.Font = new Font("Montserrat", 12, FontStyle.Bold);
            JDL1.ForeColor = Color.Black;
            JDL1.Size = new Size(700, 40);
            JDL1.Location = new Point(10, 195);
            print.Controls.Add(JDL1);


            int x = 10;
            int y = 240;

            ///////////////////////////////////////////////////////


            if (dtSimpanPayment.Rows.Count > 0)
            {
                int total = 0;
                int totalHarga = 0;
                for (int i = 0; i < dtSimpanPayment.Rows.Count; i++)
                {
                    ;
                    string namaMenu = dtSimpanPayment.Rows[i][0].ToString();
                    int jumlahPesanan = int.Parse(dtSimpanPayment.Rows[i][1].ToString());
                    int hargaMenu = int.Parse(dtSimpanPayment.Rows[i][2].ToString());
                    totalHarga = jumlahPesanan * hargaMenu;
                    total += totalHarga;
                    //MASIH BELUM RAPIH TLG RAPIHIN
                    string displayText = $"{namaMenu} {hargaMenu.ToString().PadLeft(35, ' ')} {totalHarga.ToString().PadLeft(58, ' ')}";

                    Label pilihanMenu = new Label
                    {
                        Text = namaMenu,
                        Font = new Font("Montserrat", 10, FontStyle.Regular),
                        ForeColor = Color.Black,
                        Size = new Size(300, 40),
                        Location = new Point(x, y)
                    };
                    Label pilihanPcs = new Label
                    {
                        Text = hargaMenu.ToString(),
                        Font = new Font("Montserrat", 10, FontStyle.Regular),
                        ForeColor = Color.Black,
                        Size = new Size(100, 40),
                        Location = new Point(x + 300, y)
                    };
                    Label pilihanJumlah = new Label
                    {
                        Text = totalHarga.ToString(),
                        Font = new Font("Montserrat", 10, FontStyle.Regular),
                        ForeColor = Color.Black,
                        Size = new Size(100, 40),
                        Location = new Point(x + 450, y),
                        AutoSize = false,
                        RightToLeft = RightToLeft.Yes
                    };

                    print.Controls.Add(pilihanJumlah);
                    print.Controls.Add(pilihanPcs);
                    print.Controls.Add(pilihanMenu);
                    y += 45;
                }
                Label TotalHarga = new Label
                {
                    Text = $"------------------------------------\nTotal :                       Rp.{total.ToString()}",
                    Font = new Font("Montserrat", 12, FontStyle.Regular),
                    ForeColor = Color.Black,
                    Size = new Size(800, 80),
                    Location = new Point(370, 570)
                };
                print.Controls.Add(TotalHarga);
            }


        }

        private void closePrint(object sender, EventArgs e)
        {
            print.Enabled = false;
            print.Visible = false;
        }


        private void printOK(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = print.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            printDocument1.Print();
        }

        private void printDocument1_PrintPage_1(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e) =>
               e.Graphics.DrawImage(memoryImage, 0, 0);


        private void ExecuteUpdateQuery(string sqlQuery)
        {

        }
    }
}
