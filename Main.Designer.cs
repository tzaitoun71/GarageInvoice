namespace GoetzGarage_Invoice
{
    partial class Main
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
            System.Windows.Forms.Label customer_NameLabel;
            System.Windows.Forms.Label vehicle_YearLabel;
            System.Windows.Forms.Label vehicle_MakeLabel;
            System.Windows.Forms.Label vehicle_Model_Label;
            System.Windows.Forms.Label v_I_NLabel;
            System.Windows.Forms.Label lic__PlateLabel;
            System.Windows.Forms.Label date_of_Completed_WorkLabel;
            System.Windows.Forms.Label kmLabel;
            System.Windows.Forms.Label engine_SizeLabel;
            System.Windows.Forms.Label supplierLabel;
            System.Windows.Forms.Label supplier_InvoiceLabel;
            System.Windows.Forms.Label invoice_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.main_CustomerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.main_CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDBDataSet = new GoetzGarage_Invoice.MainDBDataSet();
            this.toolStripBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.btn_Prodemand = new System.Windows.Forms.ToolStripButton();
            this.main_PartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backupDBDataSet = new GoetzGarage_Invoice.BackupDBDataSet();
            this.temp_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.main_CustomerTableAdapter = new GoetzGarage_Invoice.MainDBDataSetTableAdapters.Main_CustomerTableAdapter();
            this.tableAdapterManager = new GoetzGarage_Invoice.MainDBDataSetTableAdapters.TableAdapterManager();
            this.temp_TableTableAdapter = new GoetzGarage_Invoice.MainDBDataSetTableAdapters.Temp_TableTableAdapter();
            this.main_PartsTableAdapter = new GoetzGarage_Invoice.MainDBDataSetTableAdapters.Main_PartsTableAdapter();
            this.customerTableAdapter = new GoetzGarage_Invoice.BackupDBDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager1 = new GoetzGarage_Invoice.BackupDBDataSetTableAdapters.TableAdapterManager();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl_SchoolName = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_PostalCode = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.date_of_Completed_WorkDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.engine_SizeTextBox = new System.Windows.Forms.TextBox();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.supplier_InvoiceTextBox = new System.Windows.Forms.TextBox();
            this.txtinvoice = new System.Windows.Forms.TextBox();
            this.lbl_WorkPerformed = new System.Windows.Forms.Label();
            this.lblRecomm = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lbl_ProgramSupport = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbl_Technicians = new System.Windows.Forms.Label();
            this.txt_tech1 = new System.Windows.Forms.TextBox();
            this.txt_tech2 = new System.Windows.Forms.TextBox();
            this.txt_tech3 = new System.Windows.Forms.TextBox();
            this.txt_tech4 = new System.Windows.Forms.TextBox();
            this.pnlPaperDisplay = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.txt_Recommendations = new System.Windows.Forms.TextBox();
            this.txt_WorkPerformed = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.customerTableAdapter1 = new GoetzGarage_Invoice.BackupDBDataSetTableAdapters.CustomerTableAdapter();
            this.lbl_PhoneNumber2 = new System.Windows.Forms.Label();
            this.lbl_Comment2 = new System.Windows.Forms.Label();
            this.txt_Com = new System.Windows.Forms.TextBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.cmbOilType = new System.Windows.Forms.ComboBox();
            this.cmbCool = new System.Windows.Forms.ComboBox();
            this.cmbWarm = new System.Windows.Forms.ComboBox();
            this.cmbBrake = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblchoose = new System.Windows.Forms.Label();
            this.lblTtime = new System.Windows.Forms.Label();
            this.lblTprice = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            customer_NameLabel = new System.Windows.Forms.Label();
            vehicle_YearLabel = new System.Windows.Forms.Label();
            vehicle_MakeLabel = new System.Windows.Forms.Label();
            vehicle_Model_Label = new System.Windows.Forms.Label();
            v_I_NLabel = new System.Windows.Forms.Label();
            lic__PlateLabel = new System.Windows.Forms.Label();
            date_of_Completed_WorkLabel = new System.Windows.Forms.Label();
            kmLabel = new System.Windows.Forms.Label();
            engine_SizeLabel = new System.Windows.Forms.Label();
            supplierLabel = new System.Windows.Forms.Label();
            supplier_InvoiceLabel = new System.Windows.Forms.Label();
            invoice_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.main_CustomerBindingNavigator)).BeginInit();
            this.main_CustomerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_PartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_TableBindingSource)).BeginInit();
            this.pnlPaperDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_NameLabel
            // 
            customer_NameLabel.AutoSize = true;
            customer_NameLabel.Location = new System.Drawing.Point(321, 55);
            customer_NameLabel.Name = "customer_NameLabel";
            customer_NameLabel.Size = new System.Drawing.Size(85, 13);
            customer_NameLabel.TabIndex = 6;
            customer_NameLabel.Text = "Customer Name:";
            // 
            // vehicle_YearLabel
            // 
            vehicle_YearLabel.AutoSize = true;
            vehicle_YearLabel.Location = new System.Drawing.Point(336, 171);
            vehicle_YearLabel.Name = "vehicle_YearLabel";
            vehicle_YearLabel.Size = new System.Drawing.Size(70, 13);
            vehicle_YearLabel.TabIndex = 8;
            vehicle_YearLabel.Text = "Vehicle Year:";
            // 
            // vehicle_MakeLabel
            // 
            vehicle_MakeLabel.AutoSize = true;
            vehicle_MakeLabel.Location = new System.Drawing.Point(331, 117);
            vehicle_MakeLabel.Name = "vehicle_MakeLabel";
            vehicle_MakeLabel.Size = new System.Drawing.Size(75, 13);
            vehicle_MakeLabel.TabIndex = 10;
            vehicle_MakeLabel.Text = "Vehicle Make:";
            // 
            // vehicle_Model_Label
            // 
            vehicle_Model_Label.AutoSize = true;
            vehicle_Model_Label.Location = new System.Drawing.Point(326, 143);
            vehicle_Model_Label.Name = "vehicle_Model_Label";
            vehicle_Model_Label.Size = new System.Drawing.Size(80, 13);
            vehicle_Model_Label.TabIndex = 12;
            vehicle_Model_Label.Text = "Vehicle Model :";
            // 
            // v_I_NLabel
            // 
            v_I_NLabel.AutoSize = true;
            v_I_NLabel.Location = new System.Drawing.Point(372, 86);
            v_I_NLabel.Name = "v_I_NLabel";
            v_I_NLabel.Size = new System.Drawing.Size(34, 13);
            v_I_NLabel.TabIndex = 14;
            v_I_NLabel.Text = "V I N:";
            // 
            // lic__PlateLabel
            // 
            lic__PlateLabel.AutoSize = true;
            lic__PlateLabel.Location = new System.Drawing.Point(332, 201);
            lic__PlateLabel.Name = "lic__PlateLabel";
            lic__PlateLabel.Size = new System.Drawing.Size(74, 13);
            lic__PlateLabel.TabIndex = 16;
            lic__PlateLabel.Text = "License Plate:";
            // 
            // date_of_Completed_WorkLabel
            // 
            date_of_Completed_WorkLabel.AutoSize = true;
            date_of_Completed_WorkLabel.Location = new System.Drawing.Point(279, 230);
            date_of_Completed_WorkLabel.Name = "date_of_Completed_WorkLabel";
            date_of_Completed_WorkLabel.Size = new System.Drawing.Size(127, 13);
            date_of_Completed_WorkLabel.TabIndex = 18;
            date_of_Completed_WorkLabel.Text = "Date of Completed Work:";
            // 
            // kmLabel
            // 
            kmLabel.AutoSize = true;
            kmLabel.Location = new System.Drawing.Point(381, 257);
            kmLabel.Name = "kmLabel";
            kmLabel.Size = new System.Drawing.Size(25, 13);
            kmLabel.TabIndex = 20;
            kmLabel.Text = "Km:";
            // 
            // engine_SizeLabel
            // 
            engine_SizeLabel.AutoSize = true;
            engine_SizeLabel.Location = new System.Drawing.Point(340, 286);
            engine_SizeLabel.Name = "engine_SizeLabel";
            engine_SizeLabel.Size = new System.Drawing.Size(66, 13);
            engine_SizeLabel.TabIndex = 22;
            engine_SizeLabel.Text = "Engine Size:";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Location = new System.Drawing.Point(54, 272);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new System.Drawing.Size(48, 13);
            supplierLabel.TabIndex = 25;
            supplierLabel.Text = "Supplier:";
            // 
            // supplier_InvoiceLabel
            // 
            supplier_InvoiceLabel.AutoSize = true;
            supplier_InvoiceLabel.Location = new System.Drawing.Point(16, 303);
            supplier_InvoiceLabel.Name = "supplier_InvoiceLabel";
            supplier_InvoiceLabel.Size = new System.Drawing.Size(86, 13);
            supplier_InvoiceLabel.TabIndex = 27;
            supplier_InvoiceLabel.Text = "Supplier Invoice:";
            // 
            // invoice_NumberLabel
            // 
            invoice_NumberLabel.AutoSize = true;
            invoice_NumberLabel.Location = new System.Drawing.Point(321, 345);
            invoice_NumberLabel.Name = "invoice_NumberLabel";
            invoice_NumberLabel.Size = new System.Drawing.Size(85, 13);
            invoice_NumberLabel.TabIndex = 29;
            invoice_NumberLabel.Text = "Invoice Number:";
            // 
            // main_CustomerBindingNavigator
            // 
            this.main_CustomerBindingNavigator.AddNewItem = null;
            this.main_CustomerBindingNavigator.BindingSource = this.main_CustomerBindingSource;
            this.main_CustomerBindingNavigator.CountItem = null;
            this.main_CustomerBindingNavigator.DeleteItem = null;
            this.main_CustomerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.main_CustomerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnPrint,
            this.btn_Prodemand});
            this.main_CustomerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.main_CustomerBindingNavigator.MoveFirstItem = null;
            this.main_CustomerBindingNavigator.MoveLastItem = null;
            this.main_CustomerBindingNavigator.MoveNextItem = null;
            this.main_CustomerBindingNavigator.MovePreviousItem = null;
            this.main_CustomerBindingNavigator.Name = "main_CustomerBindingNavigator";
            this.main_CustomerBindingNavigator.PositionItem = null;
            this.main_CustomerBindingNavigator.Size = new System.Drawing.Size(1239, 27);
            this.main_CustomerBindingNavigator.TabIndex = 0;
            this.main_CustomerBindingNavigator.Text = "bindingNavigator1";
            // 
            // main_CustomerBindingSource
            // 
            this.main_CustomerBindingSource.DataMember = "Main_Customer";
            this.main_CustomerBindingSource.DataSource = this.mainDBDataSet;
            // 
            // mainDBDataSet
            // 
            this.mainDBDataSet.DataSetName = "MainDBDataSet";
            this.mainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripBtnPrint
            // 
            this.toolStripBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPrint.Image")));
            this.toolStripBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPrint.Name = "toolStripBtnPrint";
            this.toolStripBtnPrint.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnPrint.Text = "btnPrint";
            this.toolStripBtnPrint.Click += new System.EventHandler(this.toolStripBtnPrint_Click);
            // 
            // btn_Prodemand
            // 
            this.btn_Prodemand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Prodemand.Image = ((System.Drawing.Image)(resources.GetObject("btn_Prodemand.Image")));
            this.btn_Prodemand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Prodemand.Name = "btn_Prodemand";
            this.btn_Prodemand.Size = new System.Drawing.Size(24, 24);
            this.btn_Prodemand.Text = "toolStripButton2";
            this.btn_Prodemand.Click += new System.EventHandler(this.btn_Prodemand_Click);
            // 
            // main_PartsBindingSource
            // 
            this.main_PartsBindingSource.DataMember = "Main_Parts";
            this.main_PartsBindingSource.DataSource = this.mainDBDataSet;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.backupDBDataSet;
            // 
            // backupDBDataSet
            // 
            this.backupDBDataSet.DataSetName = "BackupDBDataSet";
            this.backupDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temp_TableBindingSource
            // 
            this.temp_TableBindingSource.DataMember = "Temp_Table";
            this.temp_TableBindingSource.DataSource = this.mainDBDataSet;
            // 
            // main_CustomerTableAdapter
            // 
            this.main_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Main_CustomerTableAdapter = this.main_CustomerTableAdapter;
            this.tableAdapterManager.Main_InvoiceFormTableAdapter = null;
            this.tableAdapterManager.Main_PartsTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.Temp_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GoetzGarage_Invoice.MainDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // temp_TableTableAdapter
            // 
            this.temp_TableTableAdapter.ClearBeforeFill = true;
            // 
            // main_PartsTableAdapter
            // 
            this.main_PartsTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager1.PartsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = GoetzGarage_Invoice.BackupDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(46, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Goetz Garage";
            // 
            // lbl_SchoolName
            // 
            this.lbl_SchoolName.AutoSize = true;
            this.lbl_SchoolName.Location = new System.Drawing.Point(92, 73);
            this.lbl_SchoolName.Name = "lbl_SchoolName";
            this.lbl_SchoolName.Size = new System.Drawing.Size(134, 13);
            this.lbl_SchoolName.TabIndex = 1;
            this.lbl_SchoolName.Text = "Father Micheal Goetz S. S.";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(92, 86);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(133, 13);
            this.lbl_Address.TabIndex = 2;
            this.lbl_Address.Text = "330 Central Parkway West";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(104, 99);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(104, 13);
            this.lbl_Location.TabIndex = 3;
            this.lbl_Location.Text = "Mississauga, Ontario";
            // 
            // lbl_PostalCode
            // 
            this.lbl_PostalCode.AutoSize = true;
            this.lbl_PostalCode.Location = new System.Drawing.Point(130, 112);
            this.lbl_PostalCode.Name = "lbl_PostalCode";
            this.lbl_PostalCode.Size = new System.Drawing.Size(48, 13);
            this.lbl_PostalCode.TabIndex = 4;
            this.lbl_PostalCode.Text = "L5B 3K6";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(92, 125);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(126, 13);
            this.lbl_PhoneNumber.TabIndex = 5;
            this.lbl_PhoneNumber.Text = "905-277-0326 ext: 63122";
            // 
            // date_of_Completed_WorkDateTimePicker
            // 
            this.date_of_Completed_WorkDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.main_CustomerBindingSource, "Date of Completed Work", true));
            this.date_of_Completed_WorkDateTimePicker.Location = new System.Drawing.Point(412, 224);
            this.date_of_Completed_WorkDateTimePicker.Name = "date_of_Completed_WorkDateTimePicker";
            this.date_of_Completed_WorkDateTimePicker.Size = new System.Drawing.Size(415, 20);
            this.date_of_Completed_WorkDateTimePicker.TabIndex = 19;
            // 
            // engine_SizeTextBox
            // 
            this.engine_SizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.main_CustomerBindingSource, "Engine Size", true));
            this.engine_SizeTextBox.Location = new System.Drawing.Point(412, 282);
            this.engine_SizeTextBox.Name = "engine_SizeTextBox";
            this.engine_SizeTextBox.Size = new System.Drawing.Size(415, 20);
            this.engine_SizeTextBox.TabIndex = 23;
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.main_CustomerBindingSource, "Supplier", true));
            this.supplierTextBox.Location = new System.Drawing.Point(107, 269);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(175, 20);
            this.supplierTextBox.TabIndex = 26;
            // 
            // supplier_InvoiceTextBox
            // 
            this.supplier_InvoiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.main_CustomerBindingSource, "Supplier Invoice", true));
            this.supplier_InvoiceTextBox.Location = new System.Drawing.Point(107, 300);
            this.supplier_InvoiceTextBox.Name = "supplier_InvoiceTextBox";
            this.supplier_InvoiceTextBox.Size = new System.Drawing.Size(175, 20);
            this.supplier_InvoiceTextBox.TabIndex = 28;
            // 
            // txtinvoice
            // 
            this.txtinvoice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.main_CustomerBindingSource, "Invoice Number", true));
            this.txtinvoice.Location = new System.Drawing.Point(412, 342);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.ReadOnly = true;
            this.txtinvoice.Size = new System.Drawing.Size(253, 20);
            this.txtinvoice.TabIndex = 30;
            // 
            // lbl_WorkPerformed
            // 
            this.lbl_WorkPerformed.AutoSize = true;
            this.lbl_WorkPerformed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WorkPerformed.Location = new System.Drawing.Point(19, 352);
            this.lbl_WorkPerformed.Name = "lbl_WorkPerformed";
            this.lbl_WorkPerformed.Size = new System.Drawing.Size(181, 25);
            this.lbl_WorkPerformed.TabIndex = 31;
            this.lbl_WorkPerformed.Text = "Work Performed";
            // 
            // lblRecomm
            // 
            this.lblRecomm.AutoSize = true;
            this.lblRecomm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomm.Location = new System.Drawing.Point(408, 520);
            this.lblRecomm.Name = "lblRecomm";
            this.lblRecomm.Size = new System.Drawing.Size(158, 20);
            this.lblRecomm.TabIndex = 33;
            this.lblRecomm.Text = "Recommendations";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(40, 685);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(87, 20);
            this.lblSubtotal.TabIndex = 35;
            this.lblSubtotal.Text = "Subtotal :";
            // 
            // lbl_ProgramSupport
            // 
            this.lbl_ProgramSupport.AutoSize = true;
            this.lbl_ProgramSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProgramSupport.Location = new System.Drawing.Point(80, 709);
            this.lbl_ProgramSupport.Name = "lbl_ProgramSupport";
            this.lbl_ProgramSupport.Size = new System.Drawing.Size(47, 20);
            this.lbl_ProgramSupport.TabIndex = 36;
            this.lbl_ProgramSupport.Text = "Tax :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(30, 729);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 25);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "TOTAL :";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(133, 685);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 38;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(133, 711);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 39;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(133, 737);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 40;
            // 
            // lbl_Technicians
            // 
            this.lbl_Technicians.AutoSize = true;
            this.lbl_Technicians.Location = new System.Drawing.Point(448, 685);
            this.lbl_Technicians.Name = "lbl_Technicians";
            this.lbl_Technicians.Size = new System.Drawing.Size(245, 13);
            this.lbl_Technicians.TabIndex = 41;
            this.lbl_Technicians.Text = "Technician(s) which performed the work described";
            // 
            // txt_tech1
            // 
            this.txt_tech1.Location = new System.Drawing.Point(403, 703);
            this.txt_tech1.Name = "txt_tech1";
            this.txt_tech1.Size = new System.Drawing.Size(193, 20);
            this.txt_tech1.TabIndex = 42;
            // 
            // txt_tech2
            // 
            this.txt_tech2.Location = new System.Drawing.Point(403, 737);
            this.txt_tech2.Name = "txt_tech2";
            this.txt_tech2.Size = new System.Drawing.Size(193, 20);
            this.txt_tech2.TabIndex = 43;
            // 
            // txt_tech3
            // 
            this.txt_tech3.Location = new System.Drawing.Point(622, 703);
            this.txt_tech3.Name = "txt_tech3";
            this.txt_tech3.Size = new System.Drawing.Size(204, 20);
            this.txt_tech3.TabIndex = 44;
            // 
            // txt_tech4
            // 
            this.txt_tech4.Location = new System.Drawing.Point(622, 737);
            this.txt_tech4.Name = "txt_tech4";
            this.txt_tech4.Size = new System.Drawing.Size(204, 20);
            this.txt_tech4.TabIndex = 45;
            // 
            // pnlPaperDisplay
            // 
            this.pnlPaperDisplay.AutoScroll = true;
            this.pnlPaperDisplay.BackColor = System.Drawing.Color.White;
            this.pnlPaperDisplay.Controls.Add(this.txtName);
            this.pnlPaperDisplay.Controls.Add(this.txtPlate);
            this.pnlPaperDisplay.Controls.Add(this.txtVIN);
            this.pnlPaperDisplay.Controls.Add(this.txtKm);
            this.pnlPaperDisplay.Controls.Add(this.txtYear);
            this.pnlPaperDisplay.Controls.Add(this.cmbBrand);
            this.pnlPaperDisplay.Controls.Add(this.cmbModel);
            this.pnlPaperDisplay.Controls.Add(this.txt_Recommendations);
            this.pnlPaperDisplay.Controls.Add(this.txt_WorkPerformed);
            this.pnlPaperDisplay.Controls.Add(this.txt_tech4);
            this.pnlPaperDisplay.Controls.Add(this.txt_tech3);
            this.pnlPaperDisplay.Controls.Add(this.txt_tech2);
            this.pnlPaperDisplay.Controls.Add(this.txt_tech1);
            this.pnlPaperDisplay.Controls.Add(this.lbl_Technicians);
            this.pnlPaperDisplay.Controls.Add(this.txtTotal);
            this.pnlPaperDisplay.Controls.Add(this.txtTax);
            this.pnlPaperDisplay.Controls.Add(this.txtSubtotal);
            this.pnlPaperDisplay.Controls.Add(this.lblTotal);
            this.pnlPaperDisplay.Controls.Add(this.lbl_ProgramSupport);
            this.pnlPaperDisplay.Controls.Add(this.lblSubtotal);
            this.pnlPaperDisplay.Controls.Add(this.lblRecomm);
            this.pnlPaperDisplay.Controls.Add(this.lbl_WorkPerformed);
            this.pnlPaperDisplay.Controls.Add(invoice_NumberLabel);
            this.pnlPaperDisplay.Controls.Add(this.txtinvoice);
            this.pnlPaperDisplay.Controls.Add(supplier_InvoiceLabel);
            this.pnlPaperDisplay.Controls.Add(this.supplier_InvoiceTextBox);
            this.pnlPaperDisplay.Controls.Add(supplierLabel);
            this.pnlPaperDisplay.Controls.Add(this.supplierTextBox);
            this.pnlPaperDisplay.Controls.Add(engine_SizeLabel);
            this.pnlPaperDisplay.Controls.Add(this.engine_SizeTextBox);
            this.pnlPaperDisplay.Controls.Add(kmLabel);
            this.pnlPaperDisplay.Controls.Add(date_of_Completed_WorkLabel);
            this.pnlPaperDisplay.Controls.Add(this.date_of_Completed_WorkDateTimePicker);
            this.pnlPaperDisplay.Controls.Add(lic__PlateLabel);
            this.pnlPaperDisplay.Controls.Add(v_I_NLabel);
            this.pnlPaperDisplay.Controls.Add(vehicle_Model_Label);
            this.pnlPaperDisplay.Controls.Add(vehicle_MakeLabel);
            this.pnlPaperDisplay.Controls.Add(vehicle_YearLabel);
            this.pnlPaperDisplay.Controls.Add(customer_NameLabel);
            this.pnlPaperDisplay.Controls.Add(this.lbl_PhoneNumber);
            this.pnlPaperDisplay.Controls.Add(this.lbl_PostalCode);
            this.pnlPaperDisplay.Controls.Add(this.lbl_Location);
            this.pnlPaperDisplay.Controls.Add(this.lbl_Address);
            this.pnlPaperDisplay.Controls.Add(this.lbl_SchoolName);
            this.pnlPaperDisplay.Controls.Add(this.lblTitle);
            this.pnlPaperDisplay.Location = new System.Drawing.Point(13, 47);
            this.pnlPaperDisplay.Name = "pnlPaperDisplay";
            this.pnlPaperDisplay.Size = new System.Drawing.Size(869, 795);
            this.pnlPaperDisplay.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(412, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(414, 20);
            this.txtName.TabIndex = 60;
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(413, 198);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(414, 20);
            this.txtPlate.TabIndex = 59;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(412, 83);
            this.txtVIN.MaxLength = 17;
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(415, 20);
            this.txtVIN.TabIndex = 58;
            this.txtVIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVIN_KeyDown);
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(412, 253);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(415, 20);
            this.txtKm.TabIndex = 57;
            this.txtKm.TextChanged += new System.EventHandler(this.txtKm_TextChanged);
            this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(412, 168);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(415, 20);
            this.txtYear.TabIndex = 56;
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(412, 112);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(415, 21);
            this.cmbBrand.TabIndex = 54;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            this.cmbBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBrand_KeyPress);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(412, 139);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(415, 21);
            this.cmbModel.TabIndex = 52;
            this.cmbModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbModel_KeyPress);
            // 
            // txt_Recommendations
            // 
            this.txt_Recommendations.Location = new System.Drawing.Point(384, 554);
            this.txt_Recommendations.Multiline = true;
            this.txt_Recommendations.Name = "txt_Recommendations";
            this.txt_Recommendations.Size = new System.Drawing.Size(461, 113);
            this.txt_Recommendations.TabIndex = 49;
            // 
            // txt_WorkPerformed
            // 
            this.txt_WorkPerformed.Location = new System.Drawing.Point(26, 390);
            this.txt_WorkPerformed.Multiline = true;
            this.txt_WorkPerformed.Name = "txt_WorkPerformed";
            this.txt_WorkPerformed.Size = new System.Drawing.Size(806, 112);
            this.txt_WorkPerformed.TabIndex = 48;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_PhoneNumber2
            // 
            this.lbl_PhoneNumber2.AutoSize = true;
            this.lbl_PhoneNumber2.Location = new System.Drawing.Point(887, 195);
            this.lbl_PhoneNumber2.Name = "lbl_PhoneNumber2";
            this.lbl_PhoneNumber2.Size = new System.Drawing.Size(81, 13);
            this.lbl_PhoneNumber2.TabIndex = 5;
            this.lbl_PhoneNumber2.Text = "Phone Number:";
            // 
            // lbl_Comment2
            // 
            this.lbl_Comment2.AutoSize = true;
            this.lbl_Comment2.Location = new System.Drawing.Point(914, 234);
            this.lbl_Comment2.Name = "lbl_Comment2";
            this.lbl_Comment2.Size = new System.Drawing.Size(54, 13);
            this.lbl_Comment2.TabIndex = 6;
            this.lbl_Comment2.Text = "Comment:";
            // 
            // txt_Com
            // 
            this.txt_Com.Location = new System.Drawing.Point(974, 231);
            this.txt_Com.Name = "txt_Com";
            this.txt_Com.Size = new System.Drawing.Size(202, 20);
            this.txt_Com.TabIndex = 8;
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(974, 344);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(202, 21);
            this.cmbService.TabIndex = 55;
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            this.cmbService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbService_KeyPress);
            // 
            // cmbOilType
            // 
            this.cmbOilType.FormattingEnabled = true;
            this.cmbOilType.Location = new System.Drawing.Point(974, 377);
            this.cmbOilType.Name = "cmbOilType";
            this.cmbOilType.Size = new System.Drawing.Size(202, 21);
            this.cmbOilType.TabIndex = 58;
            this.cmbOilType.Visible = false;
            this.cmbOilType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOilType_KeyPress);
            // 
            // cmbCool
            // 
            this.cmbCool.FormattingEnabled = true;
            this.cmbCool.Location = new System.Drawing.Point(974, 418);
            this.cmbCool.Name = "cmbCool";
            this.cmbCool.Size = new System.Drawing.Size(93, 21);
            this.cmbCool.TabIndex = 59;
            this.cmbCool.Visible = false;
            this.cmbCool.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCool_KeyPress);
            // 
            // cmbWarm
            // 
            this.cmbWarm.FormattingEnabled = true;
            this.cmbWarm.Location = new System.Drawing.Point(1083, 418);
            this.cmbWarm.Name = "cmbWarm";
            this.cmbWarm.Size = new System.Drawing.Size(93, 21);
            this.cmbWarm.TabIndex = 60;
            this.cmbWarm.Visible = false;
            this.cmbWarm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbWarm_KeyPress);
            // 
            // cmbBrake
            // 
            this.cmbBrake.FormattingEnabled = true;
            this.cmbBrake.Location = new System.Drawing.Point(974, 377);
            this.cmbBrake.Name = "cmbBrake";
            this.cmbBrake.Size = new System.Drawing.Size(202, 21);
            this.cmbBrake.TabIndex = 61;
            this.cmbBrake.Visible = false;
            this.cmbBrake.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBrake_KeyPress);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1010, 307);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 62;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(1130, 307);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 63;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1035, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblchoose
            // 
            this.lblchoose.AutoSize = true;
            this.lblchoose.Location = new System.Drawing.Point(1016, 269);
            this.lblchoose.Name = "lblchoose";
            this.lblchoose.Size = new System.Drawing.Size(114, 13);
            this.lblchoose.TabIndex = 65;
            this.lblchoose.Text = "Choose Service Below";
            // 
            // lblTtime
            // 
            this.lblTtime.AutoSize = true;
            this.lblTtime.Location = new System.Drawing.Point(971, 307);
            this.lblTtime.Name = "lblTtime";
            this.lblTtime.Size = new System.Drawing.Size(33, 13);
            this.lblTtime.TabIndex = 66;
            this.lblTtime.Text = "Time:";
            // 
            // lblTprice
            // 
            this.lblTprice.AutoSize = true;
            this.lblTprice.Location = new System.Drawing.Point(1083, 306);
            this.lblTprice.Name = "lblTprice";
            this.lblTprice.Size = new System.Drawing.Size(43, 13);
            this.lblTprice.TabIndex = 67;
            this.lblTprice.Text = "Price: $";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(974, 192);
            this.txtNumber.MaxLength = 10;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(202, 20);
            this.txtNumber.TabIndex = 68;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(1035, 81);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 69;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1239, 881);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblTprice);
            this.Controls.Add(this.lblTtime);
            this.Controls.Add(this.lblchoose);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt_Com);
            this.Controls.Add(this.cmbWarm);
            this.Controls.Add(this.cmbBrake);
            this.Controls.Add(this.lbl_Comment2);
            this.Controls.Add(this.cmbCool);
            this.Controls.Add(this.lbl_PhoneNumber2);
            this.Controls.Add(this.cmbOilType);
            this.Controls.Add(this.pnlPaperDisplay);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.main_CustomerBindingNavigator);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.main_CustomerBindingNavigator)).EndInit();
            this.main_CustomerBindingNavigator.ResumeLayout(false);
            this.main_CustomerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_PartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_TableBindingSource)).EndInit();
            this.pnlPaperDisplay.ResumeLayout(false);
            this.pnlPaperDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainDBDataSet mainDBDataSet;
        private System.Windows.Forms.BindingSource main_CustomerBindingSource;
        private MainDBDataSetTableAdapters.Main_CustomerTableAdapter main_CustomerTableAdapter;
        private MainDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator main_CustomerBindingNavigator;
        private System.Windows.Forms.BindingSource temp_TableBindingSource;
        private MainDBDataSetTableAdapters.Temp_TableTableAdapter temp_TableTableAdapter;
        private System.Windows.Forms.BindingSource main_PartsBindingSource;
        private MainDBDataSetTableAdapters.Main_PartsTableAdapter main_PartsTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripBtnPrint;
        private BackupDBDataSet backupDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BackupDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private BackupDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl_SchoolName;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_PostalCode;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.DateTimePicker date_of_Completed_WorkDateTimePicker;
        private System.Windows.Forms.TextBox engine_SizeTextBox;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.TextBox supplier_InvoiceTextBox;
        private System.Windows.Forms.TextBox txtinvoice;
        private System.Windows.Forms.Label lbl_WorkPerformed;
        private System.Windows.Forms.Label lblRecomm;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lbl_ProgramSupport;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbl_Technicians;
        private System.Windows.Forms.TextBox txt_tech1;
        private System.Windows.Forms.TextBox txt_tech2;
        private System.Windows.Forms.TextBox txt_tech3;
        private System.Windows.Forms.TextBox txt_tech4;
        private System.Windows.Forms.Panel pnlPaperDisplay;
        private System.Windows.Forms.TextBox txt_Recommendations;
        private System.Windows.Forms.TextBox txt_WorkPerformed;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton btn_Prodemand;
        private BackupDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.Label lbl_PhoneNumber2;
        private System.Windows.Forms.Label lbl_Comment2;
        private System.Windows.Forms.TextBox txt_Com;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbWarm;
        private System.Windows.Forms.ComboBox cmbCool;
        private System.Windows.Forms.ComboBox cmbOilType;
        private System.Windows.Forms.ComboBox cmbBrake;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblchoose;
        private System.Windows.Forms.Label lblTtime;
        private System.Windows.Forms.Label lblTprice;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAdmin;
    }
}