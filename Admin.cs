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
    public partial class Admin : Form
    {
        MySqlConnection connection = new MySqlConnection();
        public Admin()
        {
            InitializeComponent();
            connection.ConnectionString = "datasource=127.0.0.1;port=3306;Database=catalogue;Uid=root;Pwd=;";
            servicePop();//this populates the service combobox
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "Select * FROM tblgeneral";//this gets all of the information from tblgeneral and displays it
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                txtRate.Text = reader["Wage"].ToString();
                txtUser.Text = reader["UserName"].ToString();
                txtPass.Text = reader["Password"].ToString();
                reader.Close();
                connection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                connection.Close();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)//when the click edit then then can type a new username and pass word and are able to save it
        {
            enabled(true);
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                if (!(string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text)))//makes surre that become they save it all the informarion is filled
                {
                    command.CommandText = "UPDATE tblgeneral SET UserName='" + txtUser.Text + "' ,Password='" + txtPass.Text + "' where Reference=" + 1 + "";//updates the information in the database, database refrence will always be one because there is only one admin
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Username and Password updated");
                    enabled(false);//disables everthing so u can no longer edit 
                }
                else
                {
                    MessageBox.Show("Not all information has been filled");
                    connection.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                connection.Close();
            }
        }
        public void enabled(bool value)//this is used to shorten the code so that we can just pas in whichever bool  you need
        {
            btnSave2.Enabled = value;
            txtUser.Enabled = value;
            txtPass.Enabled = value;
        }

        private void btnDelete_Click(object sender, EventArgs e)//is used to delete services 
        {
            if (cmbService.Text.Length > 0)//makes sure that there has been a service selected
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandText = "Select Servicenum FROM tblservice WHERE Servicename='" + cmbService.Text + "'";//need to get the service num to delete it
                    MySqlDataReader reader = command.ExecuteReader();
                    int servNum = 0;
                    while (reader.Read())
                    {
                        servNum = Convert.ToInt16(reader["ServiceNum"].ToString());
                    }
                    reader.Close();
                    command.CommandText = "DELETE from tblservice WHERE Servicenum=" + servNum + "";//deletes the whole row fromt hat service num chosen
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Service Deleted");
                    servicePop();
                }
                catch(Exception a)
                {
                    MessageBox.Show(a.ToString());
                    connection.Close();
                }
                cmbService.ResetText();
            }
            else
            {
                MessageBox.Show("Please choose a service");
            }
           
        }
        public void servicePop()// this populates the serice combobox
        {
            try
            {
                cmbService.Items.Clear();
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "Select ServiceName From tblservice";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbService.Items.Add(reader["ServiceName"].ToString());
                }
                connection.Close();
                reader.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                connection.Close();
            }
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrWhiteSpace(cmbService.Text)))//makes sure that the service is not empty
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandText = "Select Servicenum FROM tblservice WHERE ServiceName='" + cmbService.Text + "'";
                    MySqlDataReader reader = command.ExecuteReader();
                    int servNum = 0;
                    while (reader.Read())
                    {
                        servNum = Convert.ToInt16(reader["ServiceNum"].ToString());//gets the service num
                    }
                    reader.Close();
                    connection.Close();
                    AdminEdit AdminEdit = new AdminEdit(cmbService.Text, servNum);//passes the name and the number so it can be edited in to other form so it can be displayed there
                    AdminEdit.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Choose Service Name");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                connection.Close();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminEdit AdminEdit = new AdminEdit();//takes you to the other form with no information because the user willl input new infomation there
            AdminEdit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enabledWage(true);//so  you are able to edit it
            btnEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = true;
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE tblgeneral SET Wage='" + txtRate.Text + "'where Reference=" + 1 + "";//updates the wage information
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("New wage has been saved");
                btnEdit.Enabled = true;//then stops the person from changes it again unless they click edit
                enabledWage(false);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                connection.Close();
            }
        }
        public void enabledWage(bool value)//this is used to shorten the code so that we can just pas in whichever bool  you need
        {
            btnSave.Enabled = value;
            txtRate.Enabled = value;
        }
    }
}
