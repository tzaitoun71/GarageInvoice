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
    public partial class AdminEdit : Form
    {
        MySqlConnection connection = new MySqlConnection();

        public AdminEdit()//this is initianlized when the a person is adding new information this is one of the oops
        {
            InitializeComponent();
            connection.ConnectionString = "datasource=127.0.0.1;port=3306;Database=catalogue;Uid=root;Pwd=;";
            btnSave.Visible = true;//for the insert code
        }
        public AdminEdit(string serviceName, int servNum)//this is initalizied whenthere are editing inforation
        {
            InitializeComponent();
            connection.ConnectionString = "datasource=127.0.0.1;port=3306;Database=catalogue;Uid=root;Pwd=;";
            btnSave2.Visible = true;//save2 save is for the update code
            txtService.Text = serviceName;
            lblServNum.Text = Convert.ToString(servNum);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "Select Time FROM tblservice WHERE Servicename='" + txtService.Text + "'";//uses the servicemane to get the time
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    double mins = Convert.ToDouble(reader["Time"].ToString()) * 60;//displays the time in mins(orignally hours in the database)
                    txtTime.Text = Convert.ToString(mins);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                connection.Close();
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)//this save button is for editing
        {
            try
            {
                if (!(string.IsNullOrWhiteSpace(txtService.Text) || string.IsNullOrWhiteSpace(txtTime.Text)))//makes sure nothing is blank
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    double mins = Convert.ToDouble(txtTime.Text);
                    double hours = mins / 60;//changes it from minutes to hours because htats is how its saved in the database
                    command.CommandText = "UPDATE tblservice SET Servicename='" + txtService.Text + "',Time=" + hours + " WHERE Servicenum=" + lblServNum.Text + "";//updates all the infoation needed
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data Edited");
                    this.Hide();
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)//this save button is for new information
        {

            try
            {
                if (!(string.IsNullOrWhiteSpace(txtService.Text) || string.IsNullOrWhiteSpace(txtTime.Text)))//makes sure nothing is blank
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    double mins = Convert.ToDouble(txtTime.Text);
                    double hours = mins / 60;
                    MessageBox.Show(Convert.ToString(hours));
                    command.CommandText = "INSERT into catalogueref.tblservice (Servicename, Time) values('" + txtService.Text + "'," + hours + ");";//inserts the new serivice into the database
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data Added");
                    this.Hide();
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                connection.Close();
            }
        }

        private void txtService_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetter(c) & c != 8 & c != 32) //string, backspace,spacebar
            {
                e.Handled = true;
            }
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) & c != 8 & c != 190) //numbers, backspce, period? (ask if it is minutes or hours)
            {
                e.Handled = true;
            }
        }

    }
}
