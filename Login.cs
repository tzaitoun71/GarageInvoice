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

namespace GoetzGarage_Invoice
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection();
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = "datasource=127.0.0.1;port=3306;Database=catalogue;Uid=root;Pwd=;";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();//the next three line will be repeated often theis is to make the conenction to access the database
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT UserName,Password FROM tblgeneral";
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string user = reader["UserName"].ToString();
            string pass = reader["Password"].ToString();
            reader.Close();
            if (txtUser.Text == user && txtPass.Text == pass)//this just makes sure if the informationn inputed is valid
            {
                this.Hide();
                Admin Admin = new Admin();
                Admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect UserName or/and Password");
                connection.Close();
            }
        }
    }
}
