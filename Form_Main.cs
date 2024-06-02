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

namespace ALP_SAD_DBI
{
    public partial class Form_Main : Form
    {
        public string connectionString = "server=localhost;uid=root;pwd=root;database=secu";
        public MySqlConnection sqlConnect;
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public MySqlDataReader sqlDataReader;
        public MySqlDataReader sqlReader;
        public string sqlQuery;
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            panel_Container.Location = new Point(0, 0);
            panel_Container.Size = new Size(this.Width, this.Height);
            panel_Container.BorderStyle = BorderStyle.FixedSingle;

            this.panel_Container.Controls.Clear();
            Form_Login form_login = new Form_Login();
            form_login.Dock = DockStyle.Fill;
            form_login.TopLevel = false;
            form_login.ControlBox = false;
            form_login.FormBorderStyle = FormBorderStyle.None;
            this.panel_Container.Controls.Add(form_login);
            form_login.Show();
        }
    }
}
