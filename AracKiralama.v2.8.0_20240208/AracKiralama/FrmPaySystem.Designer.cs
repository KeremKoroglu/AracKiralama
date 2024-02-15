namespace AracKiralama
{
    partial class FrmPaySystem
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
            this.TbcPaySystem = new System.Windows.Forms.TabControl();
            this.TbpPickUpDropOff = new System.Windows.Forms.TabPage();
            this.MtbDropOffTime = new System.Windows.Forms.MaskedTextBox();
            this.MtbPickUpTime = new System.Windows.Forms.MaskedTextBox();
            this.DtpDropOffDate = new System.Windows.Forms.DateTimePicker();
            this.DtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.LblDropOffDate = new System.Windows.Forms.Label();
            this.LblPickUpDate = new System.Windows.Forms.Label();
            this.CmbDropOffOffice = new System.Windows.Forms.ComboBox();
            this.LblDropOffOffice = new System.Windows.Forms.Label();
            this.CmbPickUpOffice = new System.Windows.Forms.ComboBox();
            this.LblPickUpOffice = new System.Windows.Forms.Label();
            this.TbpCarSelection = new System.Windows.Forms.TabPage();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LlbCarList = new System.Windows.Forms.LinkLabel();
            this.LlbAddCustomer = new System.Windows.Forms.LinkLabel();
            this.CmbCustomers = new System.Windows.Forms.ComboBox();
            this.LblCustomers = new System.Windows.Forms.Label();
            this.CmbCars = new System.Windows.Forms.ComboBox();
            this.LblCars = new System.Windows.Forms.Label();
            this.TbpAdditionalProducts = new System.Windows.Forms.TabPage();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.ChbBabyChair = new System.Windows.Forms.CheckBox();
            this.ChbAdditionalDriver = new System.Windows.Forms.CheckBox();
            this.TbpPay = new System.Windows.Forms.TabPage();
            this.LblInfo = new System.Windows.Forms.Label();
            this.LlbRentalConditions = new System.Windows.Forms.LinkLabel();
            this.ChbRentalConditions = new System.Windows.Forms.CheckBox();
            this.LlbPreliminaryInfoForm = new System.Windows.Forms.LinkLabel();
            this.ChbPreliminaryInfoForm = new System.Windows.Forms.CheckBox();
            this.TxtDrivingLicence = new System.Windows.Forms.TextBox();
            this.LblDrivingLicence = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MtbCvv = new System.Windows.Forms.MaskedTextBox();
            this.LblCvv = new System.Windows.Forms.Label();
            this.MtbExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.LblExpirationDate = new System.Windows.Forms.Label();
            this.MtbCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.MtbNumber = new System.Windows.Forms.MaskedTextBox();
            this.MtbTckn = new System.Windows.Forms.MaskedTextBox();
            this.LblCardNumber = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblNumber = new System.Windows.Forms.Label();
            this.LblTckn = new System.Windows.Forms.Label();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.TbcPaySystem.SuspendLayout();
            this.TbpPickUpDropOff.SuspendLayout();
            this.TbpCarSelection.SuspendLayout();
            this.TbpAdditionalProducts.SuspendLayout();
            this.TbpPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbcPaySystem
            // 
            this.TbcPaySystem.Controls.Add(this.TbpPickUpDropOff);
            this.TbcPaySystem.Controls.Add(this.TbpCarSelection);
            this.TbcPaySystem.Controls.Add(this.TbpAdditionalProducts);
            this.TbcPaySystem.Controls.Add(this.TbpPay);
            this.TbcPaySystem.Location = new System.Drawing.Point(12, 12);
            this.TbcPaySystem.Name = "TbcPaySystem";
            this.TbcPaySystem.SelectedIndex = 0;
            this.TbcPaySystem.Size = new System.Drawing.Size(776, 492);
            this.TbcPaySystem.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TbcPaySystem.TabIndex = 0;
            this.TbcPaySystem.Click += new System.EventHandler(this.TbcPaySystem_Click);
            // 
            // TbpPickUpDropOff
            // 
            this.TbpPickUpDropOff.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbpPickUpDropOff.Controls.Add(this.MtbDropOffTime);
            this.TbpPickUpDropOff.Controls.Add(this.MtbPickUpTime);
            this.TbpPickUpDropOff.Controls.Add(this.DtpDropOffDate);
            this.TbpPickUpDropOff.Controls.Add(this.DtpPickUpDate);
            this.TbpPickUpDropOff.Controls.Add(this.LblDropOffDate);
            this.TbpPickUpDropOff.Controls.Add(this.LblPickUpDate);
            this.TbpPickUpDropOff.Controls.Add(this.CmbDropOffOffice);
            this.TbpPickUpDropOff.Controls.Add(this.LblDropOffOffice);
            this.TbpPickUpDropOff.Controls.Add(this.CmbPickUpOffice);
            this.TbpPickUpDropOff.Controls.Add(this.LblPickUpOffice);
            this.TbpPickUpDropOff.Location = new System.Drawing.Point(4, 25);
            this.TbpPickUpDropOff.Name = "TbpPickUpDropOff";
            this.TbpPickUpDropOff.Padding = new System.Windows.Forms.Padding(3);
            this.TbpPickUpDropOff.Size = new System.Drawing.Size(768, 463);
            this.TbpPickUpDropOff.TabIndex = 0;
            this.TbpPickUpDropOff.Text = "Alış ve İade Ofisi";
            // 
            // MtbDropOffTime
            // 
            this.MtbDropOffTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MtbDropOffTime.Location = new System.Drawing.Point(400, 310);
            this.MtbDropOffTime.Mask = "00:00";
            this.MtbDropOffTime.Name = "MtbDropOffTime";
            this.MtbDropOffTime.Size = new System.Drawing.Size(100, 30);
            this.MtbDropOffTime.TabIndex = 6;
            this.MtbDropOffTime.Text = "0000";
            this.MtbDropOffTime.ValidatingType = typeof(System.DateTime);
            // 
            // MtbPickUpTime
            // 
            this.MtbPickUpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MtbPickUpTime.Location = new System.Drawing.Point(398, 165);
            this.MtbPickUpTime.Mask = "00:00";
            this.MtbPickUpTime.Name = "MtbPickUpTime";
            this.MtbPickUpTime.Size = new System.Drawing.Size(100, 30);
            this.MtbPickUpTime.TabIndex = 6;
            this.MtbPickUpTime.Text = "0000";
            this.MtbPickUpTime.ValidatingType = typeof(System.DateTime);
            // 
            // DtpDropOffDate
            // 
            this.DtpDropOffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDropOffDate.Location = new System.Drawing.Point(400, 274);
            this.DtpDropOffDate.Name = "DtpDropOffDate";
            this.DtpDropOffDate.Size = new System.Drawing.Size(286, 30);
            this.DtpDropOffDate.TabIndex = 5;
            // 
            // DtpPickUpDate
            // 
            this.DtpPickUpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpPickUpDate.Location = new System.Drawing.Point(398, 129);
            this.DtpPickUpDate.Name = "DtpPickUpDate";
            this.DtpPickUpDate.Size = new System.Drawing.Size(286, 30);
            this.DtpPickUpDate.TabIndex = 5;
            this.DtpPickUpDate.Value = new System.DateTime(2024, 2, 8, 0, 0, 0, 0);
            // 
            // LblDropOffDate
            // 
            this.LblDropOffDate.AutoSize = true;
            this.LblDropOffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDropOffDate.Location = new System.Drawing.Point(395, 246);
            this.LblDropOffDate.Name = "LblDropOffDate";
            this.LblDropOffDate.Size = new System.Drawing.Size(104, 25);
            this.LblDropOffDate.TabIndex = 4;
            this.LblDropOffDate.Text = "İade Tarihi";
            // 
            // LblPickUpDate
            // 
            this.LblPickUpDate.AutoSize = true;
            this.LblPickUpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPickUpDate.Location = new System.Drawing.Point(393, 101);
            this.LblPickUpDate.Name = "LblPickUpDate";
            this.LblPickUpDate.Size = new System.Drawing.Size(98, 25);
            this.LblPickUpDate.TabIndex = 4;
            this.LblPickUpDate.Text = "Alış Tarihi";
            // 
            // CmbDropOffOffice
            // 
            this.CmbDropOffOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDropOffOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDropOffOffice.FormattingEnabled = true;
            this.CmbDropOffOffice.Items.AddRange(new object[] {
            "Tekirdağ\\Çorlu",
            "Tekirdağ\\Merkez",
            "İstanbul\\Beşiktaş",
            "Zonguldak\\Gökçebey"});
            this.CmbDropOffOffice.Location = new System.Drawing.Point(87, 274);
            this.CmbDropOffOffice.Name = "CmbDropOffOffice";
            this.CmbDropOffOffice.Size = new System.Drawing.Size(249, 33);
            this.CmbDropOffOffice.TabIndex = 3;
            // 
            // LblDropOffOffice
            // 
            this.LblDropOffOffice.AutoSize = true;
            this.LblDropOffOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDropOffOffice.Location = new System.Drawing.Point(82, 246);
            this.LblDropOffOffice.Name = "LblDropOffOffice";
            this.LblDropOffOffice.Size = new System.Drawing.Size(101, 25);
            this.LblDropOffOffice.TabIndex = 2;
            this.LblDropOffOffice.Text = "Varış Ofisi";
            // 
            // CmbPickUpOffice
            // 
            this.CmbPickUpOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPickUpOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbPickUpOffice.FormattingEnabled = true;
            this.CmbPickUpOffice.Items.AddRange(new object[] {
            "Tekirdağ\\Çorlu",
            "Tekirdağ\\Merkez",
            "İstanbul\\Beşiktaş",
            "Zonguldak\\Gökçebey"});
            this.CmbPickUpOffice.Location = new System.Drawing.Point(87, 129);
            this.CmbPickUpOffice.Name = "CmbPickUpOffice";
            this.CmbPickUpOffice.Size = new System.Drawing.Size(249, 33);
            this.CmbPickUpOffice.TabIndex = 1;
            // 
            // LblPickUpOffice
            // 
            this.LblPickUpOffice.AutoSize = true;
            this.LblPickUpOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPickUpOffice.Location = new System.Drawing.Point(82, 101);
            this.LblPickUpOffice.Name = "LblPickUpOffice";
            this.LblPickUpOffice.Size = new System.Drawing.Size(88, 25);
            this.LblPickUpOffice.TabIndex = 0;
            this.LblPickUpOffice.Text = "Alış Ofisi";
            // 
            // TbpCarSelection
            // 
            this.TbpCarSelection.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbpCarSelection.Controls.Add(this.TxtPrice);
            this.TbpCarSelection.Controls.Add(this.LlbCarList);
            this.TbpCarSelection.Controls.Add(this.LlbAddCustomer);
            this.TbpCarSelection.Controls.Add(this.CmbCustomers);
            this.TbpCarSelection.Controls.Add(this.LblCustomers);
            this.TbpCarSelection.Controls.Add(this.CmbCars);
            this.TbpCarSelection.Controls.Add(this.LblCars);
            this.TbpCarSelection.Location = new System.Drawing.Point(4, 25);
            this.TbpCarSelection.Name = "TbpCarSelection";
            this.TbpCarSelection.Padding = new System.Windows.Forms.Padding(3);
            this.TbpCarSelection.Size = new System.Drawing.Size(768, 463);
            this.TbpCarSelection.TabIndex = 1;
            this.TbpCarSelection.Text = "Araç Seçimi";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Enabled = false;
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPrice.Location = new System.Drawing.Point(348, 172);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(71, 30);
            this.TxtPrice.TabIndex = 9;
            this.TxtPrice.Text = "0₺";
            // 
            // LlbCarList
            // 
            this.LlbCarList.AutoSize = true;
            this.LlbCarList.Location = new System.Drawing.Point(99, 205);
            this.LlbCarList.Name = "LlbCarList";
            this.LlbCarList.Size = new System.Drawing.Size(138, 16);
            this.LlbCarList.TabIndex = 6;
            this.LlbCarList.TabStop = true;
            this.LlbCarList.Text = "Araba Listesine Gözat";
            this.LlbCarList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbCarList_LinkClicked);
            // 
            // LlbAddCustomer
            // 
            this.LlbAddCustomer.AutoSize = true;
            this.LlbAddCustomer.Location = new System.Drawing.Point(436, 205);
            this.LlbAddCustomer.Name = "LlbAddCustomer";
            this.LlbAddCustomer.Size = new System.Drawing.Size(80, 16);
            this.LlbAddCustomer.TabIndex = 6;
            this.LlbAddCustomer.TabStop = true;
            this.LlbAddCustomer.Text = "Müşteri Ekle";
            this.LlbAddCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbAddCustomer_LinkClicked);
            // 
            // CmbCustomers
            // 
            this.CmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbCustomers.FormattingEnabled = true;
            this.CmbCustomers.Location = new System.Drawing.Point(439, 169);
            this.CmbCustomers.Name = "CmbCustomers";
            this.CmbCustomers.Size = new System.Drawing.Size(244, 33);
            this.CmbCustomers.TabIndex = 5;
            this.CmbCustomers.SelectedIndexChanged += new System.EventHandler(this.CmbCustomers_SelectedIndexChanged);
            // 
            // LblCustomers
            // 
            this.LblCustomers.AutoSize = true;
            this.LblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCustomers.Location = new System.Drawing.Point(434, 141);
            this.LblCustomers.Name = "LblCustomers";
            this.LblCustomers.Size = new System.Drawing.Size(97, 25);
            this.LblCustomers.TabIndex = 4;
            this.LblCustomers.Text = "Müşteriler";
            // 
            // CmbCars
            // 
            this.CmbCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbCars.FormattingEnabled = true;
            this.CmbCars.Location = new System.Drawing.Point(98, 169);
            this.CmbCars.Name = "CmbCars";
            this.CmbCars.Size = new System.Drawing.Size(244, 33);
            this.CmbCars.TabIndex = 3;
            this.CmbCars.SelectedIndexChanged += new System.EventHandler(this.CmbCars_SelectedIndexChanged);
            // 
            // LblCars
            // 
            this.LblCars.AutoSize = true;
            this.LblCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCars.Location = new System.Drawing.Point(93, 141);
            this.LblCars.Name = "LblCars";
            this.LblCars.Size = new System.Drawing.Size(86, 25);
            this.LblCars.TabIndex = 2;
            this.LblCars.Text = "Arabalar";
            // 
            // TbpAdditionalProducts
            // 
            this.TbpAdditionalProducts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbpAdditionalProducts.Controls.Add(this.TxtTotal);
            this.TbpAdditionalProducts.Controls.Add(this.LblTotal);
            this.TbpAdditionalProducts.Controls.Add(this.ChbBabyChair);
            this.TbpAdditionalProducts.Controls.Add(this.ChbAdditionalDriver);
            this.TbpAdditionalProducts.Location = new System.Drawing.Point(4, 25);
            this.TbpAdditionalProducts.Name = "TbpAdditionalProducts";
            this.TbpAdditionalProducts.Padding = new System.Windows.Forms.Padding(3);
            this.TbpAdditionalProducts.Size = new System.Drawing.Size(768, 463);
            this.TbpAdditionalProducts.TabIndex = 2;
            this.TbpAdditionalProducts.Text = "Ek Ürünler";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTotal.Location = new System.Drawing.Point(315, 412);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(138, 30);
            this.TxtTotal.TabIndex = 10;
            this.TxtTotal.Text = "0₺";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotal.Location = new System.Drawing.Point(344, 384);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(78, 25);
            this.LblTotal.TabIndex = 9;
            this.LblTotal.Text = "Toplam";
            // 
            // ChbBabyChair
            // 
            this.ChbBabyChair.AutoSize = true;
            this.ChbBabyChair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbBabyChair.Location = new System.Drawing.Point(398, 179);
            this.ChbBabyChair.Name = "ChbBabyChair";
            this.ChbBabyChair.Size = new System.Drawing.Size(222, 68);
            this.ChbBabyChair.TabIndex = 1;
            this.ChbBabyChair.Text = "Bebek Koltuğu\r\n250₺";
            this.ChbBabyChair.UseVisualStyleBackColor = true;
            this.ChbBabyChair.CheckedChanged += new System.EventHandler(this.ChbBabyChair_CheckedChanged);
            // 
            // ChbAdditionalDriver
            // 
            this.ChbAdditionalDriver.AutoSize = true;
            this.ChbAdditionalDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbAdditionalDriver.Location = new System.Drawing.Point(191, 179);
            this.ChbAdditionalDriver.Name = "ChbAdditionalDriver";
            this.ChbAdditionalDriver.Size = new System.Drawing.Size(185, 68);
            this.ChbAdditionalDriver.TabIndex = 0;
            this.ChbAdditionalDriver.Text = "Şoför Kirala\r\n450₺";
            this.ChbAdditionalDriver.UseVisualStyleBackColor = true;
            this.ChbAdditionalDriver.CheckedChanged += new System.EventHandler(this.ChbAdditionalDriver_CheckedChanged);
            // 
            // TbpPay
            // 
            this.TbpPay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbpPay.Controls.Add(this.LblInfo);
            this.TbpPay.Controls.Add(this.LlbRentalConditions);
            this.TbpPay.Controls.Add(this.ChbRentalConditions);
            this.TbpPay.Controls.Add(this.LlbPreliminaryInfoForm);
            this.TbpPay.Controls.Add(this.ChbPreliminaryInfoForm);
            this.TbpPay.Controls.Add(this.TxtDrivingLicence);
            this.TbpPay.Controls.Add(this.LblDrivingLicence);
            this.TbpPay.Controls.Add(this.textBox1);
            this.TbpPay.Controls.Add(this.label1);
            this.TbpPay.Controls.Add(this.MtbCvv);
            this.TbpPay.Controls.Add(this.LblCvv);
            this.TbpPay.Controls.Add(this.MtbExpirationDate);
            this.TbpPay.Controls.Add(this.LblExpirationDate);
            this.TbpPay.Controls.Add(this.MtbCardNumber);
            this.TbpPay.Controls.Add(this.MtbNumber);
            this.TbpPay.Controls.Add(this.MtbTckn);
            this.TbpPay.Controls.Add(this.LblCardNumber);
            this.TbpPay.Controls.Add(this.TxtMail);
            this.TbpPay.Controls.Add(this.LblMail);
            this.TbpPay.Controls.Add(this.LblNumber);
            this.TbpPay.Controls.Add(this.LblTckn);
            this.TbpPay.Controls.Add(this.DtpDateOfBirth);
            this.TbpPay.Controls.Add(this.TxtSurname);
            this.TbpPay.Controls.Add(this.LblDateOfBirth);
            this.TbpPay.Controls.Add(this.LblSurname);
            this.TbpPay.Controls.Add(this.TxtName);
            this.TbpPay.Controls.Add(this.LblName);
            this.TbpPay.Location = new System.Drawing.Point(4, 25);
            this.TbpPay.Name = "TbpPay";
            this.TbpPay.Padding = new System.Windows.Forms.Padding(3);
            this.TbpPay.Size = new System.Drawing.Size(768, 463);
            this.TbpPay.TabIndex = 3;
            this.TbpPay.Text = "Ödeme";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(11, 435);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(440, 16);
            this.LblInfo.TabIndex = 41;
            this.LblInfo.Text = "Şu anda - modelini hiçbir ek ürün satın almadan kiralıyorsunuz. Toplam 0₺";
            // 
            // LlbRentalConditions
            // 
            this.LlbRentalConditions.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LlbRentalConditions.AutoSize = true;
            this.LlbRentalConditions.LinkColor = System.Drawing.Color.Black;
            this.LlbRentalConditions.Location = new System.Drawing.Point(446, 288);
            this.LlbRentalConditions.Name = "LlbRentalConditions";
            this.LlbRentalConditions.Size = new System.Drawing.Size(184, 32);
            this.LlbRentalConditions.TabIndex = 40;
            this.LlbRentalConditions.TabStop = true;
            this.LlbRentalConditions.Text = "Kiralama Koşulları\'nı okudum, \r\nkabul ediyorum";
            // 
            // ChbRentalConditions
            // 
            this.ChbRentalConditions.AutoSize = true;
            this.ChbRentalConditions.Location = new System.Drawing.Point(422, 287);
            this.ChbRentalConditions.Name = "ChbRentalConditions";
            this.ChbRentalConditions.Size = new System.Drawing.Size(18, 17);
            this.ChbRentalConditions.TabIndex = 39;
            this.ChbRentalConditions.UseVisualStyleBackColor = true;
            // 
            // LlbPreliminaryInfoForm
            // 
            this.LlbPreliminaryInfoForm.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LlbPreliminaryInfoForm.AutoSize = true;
            this.LlbPreliminaryInfoForm.LinkColor = System.Drawing.Color.Black;
            this.LlbPreliminaryInfoForm.Location = new System.Drawing.Point(446, 242);
            this.LlbPreliminaryInfoForm.Name = "LlbPreliminaryInfoForm";
            this.LlbPreliminaryInfoForm.Size = new System.Drawing.Size(217, 32);
            this.LlbPreliminaryInfoForm.TabIndex = 38;
            this.LlbPreliminaryInfoForm.TabStop = true;
            this.LlbPreliminaryInfoForm.Text = "Ön Bilgilendirme Formu\'nu okudum,\r\n kabul ediyorum";
            // 
            // ChbPreliminaryInfoForm
            // 
            this.ChbPreliminaryInfoForm.AutoSize = true;
            this.ChbPreliminaryInfoForm.Location = new System.Drawing.Point(423, 245);
            this.ChbPreliminaryInfoForm.Name = "ChbPreliminaryInfoForm";
            this.ChbPreliminaryInfoForm.Size = new System.Drawing.Size(18, 17);
            this.ChbPreliminaryInfoForm.TabIndex = 37;
            this.ChbPreliminaryInfoForm.UseVisualStyleBackColor = true;
            // 
            // TxtDrivingLicence
            // 
            this.TxtDrivingLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDrivingLicence.Location = new System.Drawing.Point(135, 319);
            this.TxtDrivingLicence.Name = "TxtDrivingLicence";
            this.TxtDrivingLicence.Size = new System.Drawing.Size(170, 27);
            this.TxtDrivingLicence.TabIndex = 36;
            // 
            // LblDrivingLicence
            // 
            this.LblDrivingLicence.AutoSize = true;
            this.LblDrivingLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDrivingLicence.Location = new System.Drawing.Point(29, 322);
            this.LblDrivingLicence.Name = "LblDrivingLicence";
            this.LblDrivingLicence.Size = new System.Drawing.Size(100, 20);
            this.LblDrivingLicence.TabIndex = 35;
            this.LblDrivingLicence.Text = "Ehliyet No : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(423, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 27);
            this.textBox1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(419, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kart Üzerindeki İsim : ";
            // 
            // MtbCvv
            // 
            this.MtbCvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MtbCvv.Location = new System.Drawing.Point(559, 189);
            this.MtbCvv.Mask = "000";
            this.MtbCvv.Name = "MtbCvv";
            this.MtbCvv.Size = new System.Drawing.Size(118, 27);
            this.MtbCvv.TabIndex = 32;
            // 
            // LblCvv
            // 
            this.LblCvv.AutoSize = true;
            this.LblCvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCvv.Location = new System.Drawing.Point(557, 166);
            this.LblCvv.Name = "LblCvv";
            this.LblCvv.Size = new System.Drawing.Size(47, 20);
            this.LblCvv.TabIndex = 31;
            this.LblCvv.Text = "Cvv :";
            // 
            // MtbExpirationDate
            // 
            this.MtbExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MtbExpirationDate.Location = new System.Drawing.Point(422, 189);
            this.MtbExpirationDate.Mask = "00/00";
            this.MtbExpirationDate.Name = "MtbExpirationDate";
            this.MtbExpirationDate.Size = new System.Drawing.Size(118, 27);
            this.MtbExpirationDate.TabIndex = 30;
            // 
            // LblExpirationDate
            // 
            this.LblExpirationDate.AutoSize = true;
            this.LblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblExpirationDate.Location = new System.Drawing.Point(418, 166);
            this.LblExpirationDate.Name = "LblExpirationDate";
            this.LblExpirationDate.Size = new System.Drawing.Size(133, 20);
            this.LblExpirationDate.TabIndex = 29;
            this.LblExpirationDate.Text = "Son Kul. Tarihi : ";
            // 
            // MtbCardNumber
            // 
            this.MtbCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MtbCardNumber.Location = new System.Drawing.Point(422, 136);
            this.MtbCardNumber.Mask = "0000 0000 0000 0000";
            this.MtbCardNumber.Name = "MtbCardNumber";
            this.MtbCardNumber.Size = new System.Drawing.Size(255, 27);
            this.MtbCardNumber.TabIndex = 28;
            this.MtbCardNumber.ValidatingType = typeof(int);
            // 
            // MtbNumber
            // 
            this.MtbNumber.Enabled = false;
            this.MtbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MtbNumber.Location = new System.Drawing.Point(135, 235);
            this.MtbNumber.Mask = "(999) 000-0000";
            this.MtbNumber.Name = "MtbNumber";
            this.MtbNumber.Size = new System.Drawing.Size(170, 27);
            this.MtbNumber.TabIndex = 27;
            // 
            // MtbTckn
            // 
            this.MtbTckn.Enabled = false;
            this.MtbTckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MtbTckn.Location = new System.Drawing.Point(135, 193);
            this.MtbTckn.Mask = "00000000000";
            this.MtbTckn.Name = "MtbTckn";
            this.MtbTckn.Size = new System.Drawing.Size(170, 27);
            this.MtbTckn.TabIndex = 26;
            this.MtbTckn.ValidatingType = typeof(int);
            // 
            // LblCardNumber
            // 
            this.LblCardNumber.AutoSize = true;
            this.LblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCardNumber.Location = new System.Drawing.Point(419, 113);
            this.LblCardNumber.Name = "LblCardNumber";
            this.LblCardNumber.Size = new System.Drawing.Size(132, 20);
            this.LblCardNumber.TabIndex = 24;
            this.LblCardNumber.Text = "Kart Numarası : ";
            // 
            // TxtMail
            // 
            this.TxtMail.Enabled = false;
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(135, 277);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(170, 27);
            this.TxtMail.TabIndex = 23;
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMail.Location = new System.Drawing.Point(74, 280);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(55, 20);
            this.LblMail.TabIndex = 22;
            this.LblMail.Text = "Mail : ";
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNumber.Location = new System.Drawing.Point(46, 238);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(83, 20);
            this.LblNumber.TabIndex = 20;
            this.LblNumber.Text = "Number : ";
            // 
            // LblTckn
            // 
            this.LblTckn.AutoSize = true;
            this.LblTckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTckn.Location = new System.Drawing.Point(69, 196);
            this.LblTckn.Name = "LblTckn";
            this.LblTckn.Size = new System.Drawing.Size(60, 20);
            this.LblTckn.TabIndex = 18;
            this.LblTckn.Text = "Tckn : ";
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Enabled = false;
            this.DtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDateOfBirth.Location = new System.Drawing.Point(135, 148);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(170, 27);
            this.DtpDateOfBirth.TabIndex = 17;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Enabled = false;
            this.TxtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSurname.Location = new System.Drawing.Point(135, 102);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(170, 27);
            this.TxtSurname.TabIndex = 16;
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDateOfBirth.Location = new System.Drawing.Point(4, 148);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(125, 20);
            this.LblDateOfBirth.TabIndex = 15;
            this.LblDateOfBirth.Text = "Doğum Tarihi : ";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSurname.Location = new System.Drawing.Point(46, 105);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(83, 20);
            this.LblSurname.TabIndex = 15;
            this.LblSurname.Text = "Soyisim : ";
            // 
            // TxtName
            // 
            this.TxtName.Enabled = false;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Location = new System.Drawing.Point(135, 57);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(170, 27);
            this.TxtName.TabIndex = 14;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(74, 60);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(55, 20);
            this.LblName.TabIndex = 13;
            this.LblName.Text = "İsim : ";
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Location = new System.Drawing.Point(12, 510);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(133, 50);
            this.BtnClose.TabIndex = 22;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNext.Location = new System.Drawing.Point(655, 510);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(133, 50);
            this.BtnNext.TabIndex = 23;
            this.BtnNext.Text = "İleri";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // FrmPaySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TbcPaySystem);
            this.Name = "FrmPaySystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Sistemi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPaySystem_FormClosing);
            this.Load += new System.EventHandler(this.FrmPaySystem_Load);
            this.TbcPaySystem.ResumeLayout(false);
            this.TbpPickUpDropOff.ResumeLayout(false);
            this.TbpPickUpDropOff.PerformLayout();
            this.TbpCarSelection.ResumeLayout(false);
            this.TbpCarSelection.PerformLayout();
            this.TbpAdditionalProducts.ResumeLayout(false);
            this.TbpAdditionalProducts.PerformLayout();
            this.TbpPay.ResumeLayout(false);
            this.TbpPay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcPaySystem;
        private System.Windows.Forms.TabPage TbpPickUpDropOff;
        private System.Windows.Forms.TabPage TbpCarSelection;
        private System.Windows.Forms.TabPage TbpAdditionalProducts;
        private System.Windows.Forms.TabPage TbpPay;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label LblPickUpOffice;
        private System.Windows.Forms.Label LblPickUpDate;
        private System.Windows.Forms.ComboBox CmbDropOffOffice;
        private System.Windows.Forms.Label LblDropOffOffice;
        private System.Windows.Forms.ComboBox CmbPickUpOffice;
        private System.Windows.Forms.DateTimePicker DtpPickUpDate;
        private System.Windows.Forms.DateTimePicker DtpDropOffDate;
        private System.Windows.Forms.Label LblDropOffDate;
        private System.Windows.Forms.MaskedTextBox MtbPickUpTime;
        private System.Windows.Forms.MaskedTextBox MtbDropOffTime;
        private System.Windows.Forms.ComboBox CmbCars;
        private System.Windows.Forms.Label LblCars;
        private System.Windows.Forms.LinkLabel LlbAddCustomer;
        private System.Windows.Forms.ComboBox CmbCustomers;
        private System.Windows.Forms.Label LblCustomers;
        private System.Windows.Forms.LinkLabel LlbCarList;
        private System.Windows.Forms.CheckBox ChbBabyChair;
        private System.Windows.Forms.CheckBox ChbAdditionalDriver;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label LblDateOfBirth;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label LblTckn;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.MaskedTextBox MtbNumber;
        private System.Windows.Forms.MaskedTextBox MtbTckn;
        private System.Windows.Forms.Label LblCardNumber;
        private System.Windows.Forms.MaskedTextBox MtbCardNumber;
        private System.Windows.Forms.Label LblExpirationDate;
        private System.Windows.Forms.MaskedTextBox MtbExpirationDate;
        private System.Windows.Forms.MaskedTextBox MtbCvv;
        private System.Windows.Forms.Label LblCvv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDrivingLicence;
        private System.Windows.Forms.Label LblDrivingLicence;
        private System.Windows.Forms.CheckBox ChbPreliminaryInfoForm;
        private System.Windows.Forms.LinkLabel LlbPreliminaryInfoForm;
        private System.Windows.Forms.LinkLabel LlbRentalConditions;
        private System.Windows.Forms.CheckBox ChbRentalConditions;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblInfo;
    }
}