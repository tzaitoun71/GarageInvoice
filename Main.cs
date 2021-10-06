using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;//to be able to grab data from teh mysql database
//Vivik Pereira,Joseph Caruna, Conor French, Andrew Quito
//Tuesday, January 23rd 2018
//ICS CPT: Goetz Garage Invoice
//Create a database/printing program for Goetz Garages invoices, replaces the need for manual input for reciepts, uses information within Database to create a paper copy that is available to print..

//Dana, Tariq, Moh, Tim
//20 Jan 2020
//GOetz Garage CPt
//Connects to database and uses catelogue to choose information
namespace GoetzGarage_Invoice
{

    public partial class Main : Form
    {
        MySqlConnection connection = new MySqlConnection();
        private double subtotal = 0;//we did this so we can use it multiple times,and we wanted to use +=
        public Main()
        {
            InitializeComponent();
            connection.ConnectionString = "datasource=127.0.0.1;port=3306;Database=catalogue;Uid=root;Pwd=;";
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "Select Max(InvoiceNum) From tblHistory";//used the select max we can get the highest incoce num and add one as this info will e saves in the next invoice numbert
            int invoice = (int)command.ExecuteScalar() +1;
            txtinvoice.Text = Convert.ToString(invoice);
            connection.Close();
            autoVIN();//this will call the method so we canuse the vin num to search up if the person is a new customer or an old one
            brandDisplay();//to populate teh brand
            serviceDisplay();//to populate the service
        }

        private void btn_Prodemand_Click(object sender, EventArgs e) // opens up prodemands website
        {
            System.Diagnostics.Process.Start("https://aui.mitchell1.com/Login?y=tusc1&exitUrl=http://www.prodemand.com&rememberPassword=True&autoLogin=True&z=");
        }

        private void toolStripBtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog ToPrint = new PrintPreviewDialog(); // makes new print preview dialog to show user before they print
                PrintDocument Document = new PrintDocument(); // new document
                Document.PrintPage += Doc_PrintPage; // if there are multiple documents it adds on
                ToPrint.Document = Document; //sets PrintPreviews document to the documents(s)
                ToPrint.ShowDialog(); // shows print previews.
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e) // new event for printing 
        {
            try
            {
                Bitmap bm = new Bitmap(pnlPaperDisplay.Width, pnlPaperDisplay.Height); // creates new bitmap according to panels widht,height
                pnlPaperDisplay.DrawToBitmap(bm, new Rectangle(0, 0, pnlPaperDisplay.Width, pnlPaperDisplay.Height)); // draws panel to bitmap
                e.Graphics.DrawImage(bm, e.MarginBounds); // this stretches to the aspect ratio of the printing paper
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void brandDisplay()//this method retrevies the brand name from the tblcar from the datatbase and displays to combobox through the select query
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "Select Brand From tblcar";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbBrand.Items.Add(reader["Brand"].ToString());
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
        public void serviceDisplay()//this method retrevies the servicename from the tblservice from the datatbase and displays to combobox through the select query
        {
            try
            {
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

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOilType.Items.Clear();//we clear all of comboxes so that the next time this combobox is selected again we do not have additional copies of the same options
            cmbWarm.Items.Clear();
            cmbCool.Items.Clear();
            cmbBrake.Items.Clear();
            cmbOilType.ResetText();//we reset the text so that if they came back to that option again, their previous option, so basically clears the textbox itself
            cmbWarm.ResetText();
            cmbCool.ResetText();
            cmbBrake.ResetText();
            if (cmbService.Text == "Oil Change")//we sepeated them because different options willl be avaible if oil was picked
            {
                cmbBrake.Visible = false;//we made this false so that there wouldn;'t be two comboboxes on top of one another, and bcause we want thenm only to choose between the the differnt oil ypes
                enabled(true);//here were enabled them as they were disabled since we didn want those opions to be avaible if you didnt choose oil change
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    int custID = 0;
                    command.CommandText = "Select OilType,Warm,Cool From tblHistory WHERE InvoiceNum=" + custID + "";//and her we used the refernce(invoicenum) to retrive their info so we can display it
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())//displays all of the info in the proper comboboxes
                    {
                        cmbOilType.Text = reader["OilType"].ToString();
                        cmbWarm.Text = reader["Warm"].ToString();
                        cmbCool.Text = reader["Cool"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch
                {
                    connection.Close();
                }

            }
            else if (cmbService.Text == "Brake Work")
            {
                cmbBrake.Visible = true;
                enabled(false);
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    int custID = 0;
                    command.CommandText = "Select Max(InvoiceNum) From tblHistory WHERE Brand='" + cmbBrand.Text + "'AND Model='" + cmbModel.Text + "'AND Year=" + txtYear.Text + "";// this retrevies the most recent history from the database so that it could recommend the oil type of what a person with he same model and make choose
                    custID = (int)command.ExecuteScalar();//there^ we got he inoicenum of that person 
                    command.CommandText = "Select BrakeType From tblHistory WHERE InvoiceNum=" + custID + "";
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbBrake.Text = reader["BrakeType"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch
                {
                    connection.Close();
                }
            }
            else
            {
                cmbBrake.Visible = false;//dont want all of the comboboxs to show
                enabled(false);
            }
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "Select Time From tblservice where ServiceName='" + cmbService.Text + "'";//got the time so that we can use it to display how long this service will take
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                double time = Convert.ToDouble(reader["Time"]) * 60;//data saved in table as hours wanted to change it to minutes because its less confusing
                lblTime.Text = Convert.ToString(time) + " minutes";
                reader.Close();
                MySqlCommand command3 = new MySqlCommand();
                command3.Connection = connection;
                command3.CommandText = "Select Wage From tblgeneral";//get the wage per person per hour for a person
                MySqlDataReader reader3 = command3.ExecuteReader();
                reader3.Read();
                int price = Convert.ToInt16(reader3["Wage"]);
                double hourRate = (time / 60) * price;//got the hourly rate like this because the wage can cahnge since the admin is able to chaneg the wage, therefore we made it dynamic so that the pice would change base on the wage, therefore we choose not to display the price in the table
                lblPrice.Text = Convert.ToString(hourRate.ToString("0.00"));
                connection.Close();
                reader3.Close();
                oilFill();//this filled up all the comboboxes that have to do with the oil
                try
                {
                    connection.Open();
                    MySqlCommand command2 = new MySqlCommand();
                    command2.Connection = connection;
                    command2.CommandText = "Select BrakeType From tblbrake";//this is for the brake information
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    while (reader2.Read())
                    {
                        cmbBrake.Items.Add(reader2["BrakeType"].ToString());
                    }
                    connection.Close();
                    reader2.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                    connection.Close();
                }
            }
            catch (Exception a)
            {
                connection.Close();
                MessageBox.Show(a.ToString());
                oilFill();//redisplay the information
            }
        }
        public void enabled(bool value)//this is used to shorten the code so that we can just pas in whichever bool  you need
        {
            cmbOilType.Visible = value;
            cmbWarm.Visible = value;
            cmbCool.Visible = value;
        }
        public void oilFill()//this method will fill up the combo boxes htat have to do withthe oil chnage
        {
            try
            {
                connection.Open();
                MySqlCommand command2 = new MySqlCommand();
                command2.Connection = connection;
                command2.CommandText = "Select OilType From tbloil";
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    cmbOilType.Items.Add(reader2["OilType"].ToString());
                }
                connection.Close();
                reader2.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                connection.Close();
            }
            try
            {
                connection.Open();
                MySqlCommand command2 = new MySqlCommand();
                command2.Connection = connection;
                command2.CommandText = "Select CoolTemp From tbltemp";
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    cmbCool.Items.Add(reader2["CoolTemp"].ToString());
                }
                connection.Close();
                reader2.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                connection.Close();
            }
            try
            {
                connection.Open();
                MySqlCommand command2 = new MySqlCommand();
                command2.Connection = connection;
                command2.CommandText = "Select WarmTemp From tbltemp";
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    cmbWarm.Items.Add(reader2["WarmTemp"].ToString());
                }
                connection.Close();
                reader2.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                connection.Close();
            }
        }

        private void txtKm_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txtKm.Text)))//if its not empty
            {
                long kilometer = long.Parse(txtKm.Text);//we put it into a long because the number of digits will be longer
                if (kilometer > 100000)//recommended that u change your tires after 100000
                {
                    MessageBox.Show("Are you sure you dont need a tire change? It is recommended that a car gets after 100000");
                }
            }
        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) & c != 8) //numbers, backspce, period? (ask if it is minutes or hours)
            {
                e.Handled = true;
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbModel.Items.Clear();//clears it so it does not pile up
                connection.Close();
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "Select Model1, Model2,Model3 From tblcar Where Brand='" + cmbBrand.Text + "'";//fills the brand up for the models 
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbModel.Items.Add(reader["Model1"].ToString());
                    cmbModel.Items.Add(reader["Model2"].ToString());
                    cmbModel.Items.Add(reader["Model3"].ToString());
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

        public void VINCheck()//this checks if the vin number is 17 digits
        {
            if (txtVIN.Text.Length != 17)
            {
                MessageBox.Show("VIN must be 17 digits long");
            }
            else
            {
                checkSave();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbService.Text == "Oil Change" && cmbService.Text.Length > 1 && !string.IsNullOrWhiteSpace(cmbOilType.Text) && !string.IsNullOrWhiteSpace(cmbWarm.Text) && !string.IsNullOrWhiteSpace(cmbCool.Text) && !string.IsNullOrWhiteSpace(cmbBrand.Text) && !string.IsNullOrWhiteSpace(cmbModel.Text) && !string.IsNullOrWhiteSpace(txtYear.Text) && !string.IsNullOrWhiteSpace(txtPlate.Text) && !string.IsNullOrWhiteSpace(txtVIN.Text) && !string.IsNullOrWhiteSpace(txtKm.Text) && !string.IsNullOrWhiteSpace(txtNumber.Text) && !string.IsNullOrWhiteSpace(txtName.Text))//this makes sure that all the oil related information has been filled
            {
                VINCheck();
            }
            else if (cmbService.Text == "Brake Work" && cmbService.Text.Length > 1 && !string.IsNullOrWhiteSpace(cmbBrake.Text) && !string.IsNullOrWhiteSpace(cmbBrand.Text) && !string.IsNullOrWhiteSpace(cmbModel.Text) && !string.IsNullOrWhiteSpace(txtYear.Text) && !string.IsNullOrWhiteSpace(txtPlate.Text) && !string.IsNullOrWhiteSpace(txtVIN.Text) && !string.IsNullOrWhiteSpace(txtKm.Text) && !string.IsNullOrWhiteSpace(txtNumber.Text) && !string.IsNullOrWhiteSpace(txtName.Text))//this makes sure all the brake related information has been filled
            {
                VINCheck();
            }
            else if (cmbService.Text != "Oil Change" && cmbService.Text != "Brake Work" && cmbService.Text.Length > 1 && !string.IsNullOrWhiteSpace(cmbBrand.Text) && !string.IsNullOrWhiteSpace(cmbModel.Text) && !string.IsNullOrWhiteSpace(txtYear.Text) && !string.IsNullOrWhiteSpace(txtPlate.Text) && !string.IsNullOrWhiteSpace(txtVIN.Text) && !string.IsNullOrWhiteSpace(txtKm.Text) && !string.IsNullOrWhiteSpace(txtNumber.Text) && !string.IsNullOrWhiteSpace(txtName.Text))//this makes sure that all the regular infomarion has been filed
            {
                VINCheck();
            }
            else
            {
                MessageBox.Show("Not all information has been inputed");
            }
            double price = double.Parse(lblPrice.Text);
            subtotal += price;
            txtSubtotal.Text = subtotal.ToString();
            txtTax.Text = (price * .13).ToString();//gets the tax partt
            txtTotal.Text = (price * 1.13).ToString();//gests the final total
            lblPrice.Text = "";//clears the label
        }
        public void autoVIN()//this method provides the VIN textbox with autocomplete abilities
        {
            try
            {
                txtVIN.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //autocomplete mode is initialised to the textbox
                txtVIN.AutoCompleteSource = AutoCompleteSource.CustomSource; //the source is custom since we are using the information in the databse
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection(); //the values read from the database is copied to the string initialised here  
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "Select VIN FROM tblhistory"; //reads the vin number
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string VIN = reader["VIN"].ToString();
                    collection.Add(VIN); //the vin is the string that is to be auto completed
                }
                txtVIN.AutoCompleteCustomSource = collection; 
                reader.Close();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }
        }

        public void checkSave()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to save this information?", " ", MessageBoxButtons.YesNo);//this is just a precaustion to make sure that the user makes the right information
            if (dialogResult == DialogResult.Yes)//if they pick yes
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT into catalogueref.tblhistory (Brand,Model,Service,Year,OilType,Cool,Warm,BrakeType,VIN,LicensePlate,CustomerName,PhoneNum) values('" + cmbBrand.Text + "','" + cmbModel.Text + "','" + cmbService.Text + "'," + txtYear.Text + ",'" + cmbOilType.Text + "','" + cmbCool.Text + "','" + cmbWarm.Text + "','" + cmbBrake.Text + "', '" + txtVIN.Text + "','" + txtPlate.Text + "','" + txtName.Text + "','" + txtNumber.Text + "');";//this inserts all the information needed for table history so that it can saved 
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Saved");
                    connection.Close();
                    cmbService.ResetText();//this onwards basically clears everything
                    serviceDisplay();
                    cmbOilType.Visible = false;
                    cmbBrake.Visible = false;
                    cmbCool.Visible = false;
                    cmbWarm.Visible = false;
                    lblTime.Text = "";
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                    connection.Close();
                }
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) & c != 8) //numbers, backspce, period? (ask if it is minutes or hours)
            {
                e.Handled = true;
            }
        }

        private void cmbBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;//this makes sure that a person cannot write on the combobox because we do not want the information written to be added to the database, we need one of the options
        }

        private void cmbModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbService_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbBrake_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbCool_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbWarm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbOilType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtVIN_KeyDown(object sender, KeyEventArgs e)//we put the vin in the keydown because we didnt want the other information to autofill unless the person actually clicked it
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandText = "Select Year,Brand,Model,LicensePlate FROM tblhistory WHERE VIN='" + txtVIN.Text + "'";//this information will autofill if the vin numbe ris choosen ,menaing it was a existing customer
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtYear.Text = reader["Year"].ToString();
                        cmbModel.Text = reader["Model"].ToString();
                        txtPlate.Text = reader["LicensePlate"].ToString();
                        cmbBrand.Text = reader["Brand"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch
                {
                    connection.Close();
                }

            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login Login = new Login();//goes to the login page
            Login.ShowDialog();
            this.Hide();
        }

    }
}
