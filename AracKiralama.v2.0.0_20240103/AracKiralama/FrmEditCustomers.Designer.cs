namespace AracKiralama
{
    partial class FrmEditCustomers
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
            this.BtnFind = new System.Windows.Forms.Button();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.CmbID = new System.Windows.Forms.ComboBox();
            this.LblID = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.GrpEditCustomers = new System.Windows.Forms.GroupBox();
            this.ChbDeliveryDateNull = new System.Windows.Forms.CheckBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.LblTckn = new System.Windows.Forms.Label();
            this.LblRentDate = new System.Windows.Forms.Label();
            this.LblNumber = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LblDeliveredDate = new System.Windows.Forms.Label();
            this.LblDeliveryDate = new System.Windows.Forms.Label();
            this.TxtTckn = new System.Windows.Forms.TextBox();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.ChbRenter = new System.Windows.Forms.CheckBox();
            this.ChbDelivered = new System.Windows.Forms.CheckBox();
            this.RtbDescription = new System.Windows.Forms.RichTextBox();
            this.DtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.DtpDeliveredDate = new System.Windows.Forms.DateTimePicker();
            this.DtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.LblMakeNull = new System.Windows.Forms.Label();
            this.ChbRentDateNull = new System.Windows.Forms.CheckBox();
            this.ChbDeliveredDateNull = new System.Windows.Forms.CheckBox();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.LblMail = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.LblRentedModel = new System.Windows.Forms.Label();
            this.TxtRentedModel = new System.Windows.Forms.TextBox();
            this.TxtLastRentedModel = new System.Windows.Forms.TextBox();
            this.LblLastRenterModel = new System.Windows.Forms.Label();
            this.GrpEditCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFind
            // 
            this.BtnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFind.Location = new System.Drawing.Point(629, 15);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(75, 37);
            this.BtnFind.TabIndex = 59;
            this.BtnFind.Text = "Ara";
            this.BtnFind.UseVisualStyleBackColor = true;
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCustomer.Location = new System.Drawing.Point(385, 15);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(229, 34);
            this.TxtCustomer.TabIndex = 58;
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCustomer.Location = new System.Drawing.Point(269, 18);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(110, 29);
            this.LblCustomer.TabIndex = 57;
            this.LblCustomer.Text = "Müşteri : ";
            // 
            // CmbID
            // 
            this.CmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbID.FormattingEnabled = true;
            this.CmbID.Location = new System.Drawing.Point(113, 15);
            this.CmbID.Name = "CmbID";
            this.CmbID.Size = new System.Drawing.Size(121, 37);
            this.CmbID.TabIndex = 56;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblID.Location = new System.Drawing.Point(58, 18);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(54, 29);
            this.LblID.TabIndex = 55;
            this.LblID.Text = "ID : ";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Location = new System.Drawing.Point(12, 501);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 50);
            this.BtnSave.TabIndex = 54;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // GrpEditCustomers
            // 
            this.GrpEditCustomers.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GrpEditCustomers.Controls.Add(this.TxtLastRentedModel);
            this.GrpEditCustomers.Controls.Add(this.LblLastRenterModel);
            this.GrpEditCustomers.Controls.Add(this.DtpDateOfBirth);
            this.GrpEditCustomers.Controls.Add(this.ChbDeliveryDateNull);
            this.GrpEditCustomers.Controls.Add(this.ChbDeliveredDateNull);
            this.GrpEditCustomers.Controls.Add(this.ChbRentDateNull);
            this.GrpEditCustomers.Controls.Add(this.LblMakeNull);
            this.GrpEditCustomers.Controls.Add(this.DtpDeliveryDate);
            this.GrpEditCustomers.Controls.Add(this.DtpDeliveredDate);
            this.GrpEditCustomers.Controls.Add(this.DtpRentDate);
            this.GrpEditCustomers.Controls.Add(this.RtbDescription);
            this.GrpEditCustomers.Controls.Add(this.ChbDelivered);
            this.GrpEditCustomers.Controls.Add(this.ChbRenter);
            this.GrpEditCustomers.Controls.Add(this.TxtRentedModel);
            this.GrpEditCustomers.Controls.Add(this.TxtMail);
            this.GrpEditCustomers.Controls.Add(this.TxtName);
            this.GrpEditCustomers.Controls.Add(this.LblDescription);
            this.GrpEditCustomers.Controls.Add(this.LblRentedModel);
            this.GrpEditCustomers.Controls.Add(this.LblMail);
            this.GrpEditCustomers.Controls.Add(this.LblName);
            this.GrpEditCustomers.Controls.Add(this.TxtNumber);
            this.GrpEditCustomers.Controls.Add(this.TxtTckn);
            this.GrpEditCustomers.Controls.Add(this.LblDeliveryDate);
            this.GrpEditCustomers.Controls.Add(this.LblDeliveredDate);
            this.GrpEditCustomers.Controls.Add(this.TxtSurname);
            this.GrpEditCustomers.Controls.Add(this.LblNumber);
            this.GrpEditCustomers.Controls.Add(this.LblRentDate);
            this.GrpEditCustomers.Controls.Add(this.LblTckn);
            this.GrpEditCustomers.Controls.Add(this.LblDateOfBirth);
            this.GrpEditCustomers.Controls.Add(this.LblSurname);
            this.GrpEditCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpEditCustomers.Location = new System.Drawing.Point(12, 63);
            this.GrpEditCustomers.Name = "GrpEditCustomers";
            this.GrpEditCustomers.Size = new System.Drawing.Size(726, 432);
            this.GrpEditCustomers.TabIndex = 53;
            this.GrpEditCustomers.TabStop = false;
            this.GrpEditCustomers.Text = "Düzenle";
            // 
            // ChbDeliveryDateNull
            // 
            this.ChbDeliveryDateNull.AutoSize = true;
            this.ChbDeliveryDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDeliveryDateNull.Location = new System.Drawing.Point(678, 401);
            this.ChbDeliveryDateNull.Name = "ChbDeliveryDateNull";
            this.ChbDeliveryDateNull.Size = new System.Drawing.Size(18, 17);
            this.ChbDeliveryDateNull.TabIndex = 69;
            this.ChbDeliveryDateNull.UseVisualStyleBackColor = true;
            this.ChbDeliveryDateNull.CheckedChanged += new System.EventHandler(this.ChbDeliveryDateNull_CheckedChanged);
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSurname.Location = new System.Drawing.Point(61, 85);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(97, 25);
            this.LblSurname.TabIndex = 57;
            this.LblSurname.Text = "Soyisim : ";
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDateOfBirth.Location = new System.Drawing.Point(13, 134);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(145, 25);
            this.LblDateOfBirth.TabIndex = 64;
            this.LblDateOfBirth.Text = "Doğum Tarihi : ";
            // 
            // LblTckn
            // 
            this.LblTckn.AutoSize = true;
            this.LblTckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTckn.Location = new System.Drawing.Point(13, 180);
            this.LblTckn.Name = "LblTckn";
            this.LblTckn.Size = new System.Drawing.Size(143, 25);
            this.LblTckn.TabIndex = 59;
            this.LblTckn.Text = "TC Kimlik No : ";
            // 
            // LblRentDate
            // 
            this.LblRentDate.AutoSize = true;
            this.LblRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRentDate.Location = new System.Drawing.Point(317, 304);
            this.LblRentDate.Name = "LblRentDate";
            this.LblRentDate.Size = new System.Drawing.Size(161, 25);
            this.LblRentDate.TabIndex = 61;
            this.LblRentDate.Text = "Kiralanan Tarih : ";
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNumber.Location = new System.Drawing.Point(62, 228);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(94, 25);
            this.LblNumber.TabIndex = 59;
            this.LblNumber.Text = "Telefon : ";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSurname.Location = new System.Drawing.Point(164, 82);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(157, 30);
            this.TxtSurname.TabIndex = 47;
            // 
            // LblDeliveredDate
            // 
            this.LblDeliveredDate.AutoSize = true;
            this.LblDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDeliveredDate.Location = new System.Drawing.Point(283, 349);
            this.LblDeliveredDate.Name = "LblDeliveredDate";
            this.LblDeliveredDate.Size = new System.Drawing.Size(195, 25);
            this.LblDeliveredDate.TabIndex = 62;
            this.LblDeliveredDate.Text = "Teslim Edilen Tarih : ";
            // 
            // LblDeliveryDate
            // 
            this.LblDeliveryDate.AutoSize = true;
            this.LblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDeliveryDate.Location = new System.Drawing.Point(338, 393);
            this.LblDeliveryDate.Name = "LblDeliveryDate";
            this.LblDeliveryDate.Size = new System.Drawing.Size(140, 25);
            this.LblDeliveryDate.TabIndex = 63;
            this.LblDeliveryDate.Text = "Teslim Tarihi : ";
            // 
            // TxtTckn
            // 
            this.TxtTckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTckn.Location = new System.Drawing.Point(164, 179);
            this.TxtTckn.Name = "TxtTckn";
            this.TxtTckn.Size = new System.Drawing.Size(157, 30);
            this.TxtTckn.TabIndex = 49;
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNumber.Location = new System.Drawing.Point(164, 225);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(157, 30);
            this.TxtNumber.TabIndex = 49;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(95, 36);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(63, 25);
            this.LblName.TabIndex = 65;
            this.LblName.Text = "İsim : ";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDescription.Location = new System.Drawing.Point(18, 276);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(108, 25);
            this.LblDescription.TabIndex = 66;
            this.LblDescription.Text = "Açıklama : ";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Location = new System.Drawing.Point(164, 33);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(157, 30);
            this.TxtName.TabIndex = 46;
            // 
            // ChbRenter
            // 
            this.ChbRenter.AutoSize = true;
            this.ChbRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbRenter.Location = new System.Drawing.Point(395, 228);
            this.ChbRenter.Name = "ChbRenter";
            this.ChbRenter.Size = new System.Drawing.Size(83, 29);
            this.ChbRenter.TabIndex = 52;
            this.ChbRenter.Text = "Kiracı";
            this.ChbRenter.UseVisualStyleBackColor = true;
            // 
            // ChbDelivered
            // 
            this.ChbDelivered.AutoSize = true;
            this.ChbDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDelivered.Location = new System.Drawing.Point(535, 228);
            this.ChbDelivered.Name = "ChbDelivered";
            this.ChbDelivered.Size = new System.Drawing.Size(144, 29);
            this.ChbDelivered.TabIndex = 53;
            this.ChbDelivered.Text = "Teslim Edildi";
            this.ChbDelivered.UseVisualStyleBackColor = true;
            // 
            // RtbDescription
            // 
            this.RtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RtbDescription.Location = new System.Drawing.Point(21, 304);
            this.RtbDescription.Name = "RtbDescription";
            this.RtbDescription.Size = new System.Drawing.Size(230, 117);
            this.RtbDescription.TabIndex = 55;
            this.RtbDescription.Text = "";
            // 
            // DtpRentDate
            // 
            this.DtpRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpRentDate.Location = new System.Drawing.Point(484, 303);
            this.DtpRentDate.Name = "DtpRentDate";
            this.DtpRentDate.Size = new System.Drawing.Size(172, 27);
            this.DtpRentDate.TabIndex = 56;
            // 
            // DtpDeliveredDate
            // 
            this.DtpDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDeliveredDate.Location = new System.Drawing.Point(484, 348);
            this.DtpDeliveredDate.Name = "DtpDeliveredDate";
            this.DtpDeliveredDate.Size = new System.Drawing.Size(173, 27);
            this.DtpDeliveredDate.TabIndex = 58;
            // 
            // DtpDeliveryDate
            // 
            this.DtpDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDeliveryDate.Location = new System.Drawing.Point(484, 391);
            this.DtpDeliveryDate.Name = "DtpDeliveryDate";
            this.DtpDeliveryDate.Size = new System.Drawing.Size(172, 27);
            this.DtpDeliveryDate.TabIndex = 60;
            // 
            // LblMakeNull
            // 
            this.LblMakeNull.AutoSize = true;
            this.LblMakeNull.BackColor = System.Drawing.Color.Transparent;
            this.LblMakeNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMakeNull.Location = new System.Drawing.Point(656, 273);
            this.LblMakeNull.Name = "LblMakeNull";
            this.LblMakeNull.Size = new System.Drawing.Size(58, 16);
            this.LblMakeNull.TabIndex = 68;
            this.LblMakeNull.Text = "Null Yap";
            // 
            // ChbRentDateNull
            // 
            this.ChbRentDateNull.AutoSize = true;
            this.ChbRentDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbRentDateNull.Location = new System.Drawing.Point(678, 312);
            this.ChbRentDateNull.Name = "ChbRentDateNull";
            this.ChbRentDateNull.Size = new System.Drawing.Size(18, 17);
            this.ChbRentDateNull.TabIndex = 69;
            this.ChbRentDateNull.UseVisualStyleBackColor = true;
            this.ChbRentDateNull.CheckedChanged += new System.EventHandler(this.ChbRentDateNull_CheckedChanged);
            // 
            // ChbDeliveredDateNull
            // 
            this.ChbDeliveredDateNull.AutoSize = true;
            this.ChbDeliveredDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDeliveredDateNull.Location = new System.Drawing.Point(678, 357);
            this.ChbDeliveredDateNull.Name = "ChbDeliveredDateNull";
            this.ChbDeliveredDateNull.Size = new System.Drawing.Size(18, 17);
            this.ChbDeliveredDateNull.TabIndex = 69;
            this.ChbDeliveredDateNull.UseVisualStyleBackColor = true;
            this.ChbDeliveredDateNull.CheckedChanged += new System.EventHandler(this.ChbDeliveredDateNull_CheckedChanged);
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDateOfBirth.Location = new System.Drawing.Point(164, 134);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(157, 27);
            this.DtpDateOfBirth.TabIndex = 70;
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMail.Location = new System.Drawing.Point(480, 73);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(64, 25);
            this.LblMail.TabIndex = 65;
            this.LblMail.Text = "Mail : ";
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(549, 70);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(157, 30);
            this.TxtMail.TabIndex = 46;
            // 
            // LblRentedModel
            // 
            this.LblRentedModel.AutoSize = true;
            this.LblRentedModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRentedModel.Location = new System.Drawing.Point(374, 124);
            this.LblRentedModel.Name = "LblRentedModel";
            this.LblRentedModel.Size = new System.Drawing.Size(170, 25);
            this.LblRentedModel.TabIndex = 65;
            this.LblRentedModel.Text = "Kiralanan Model : ";
            // 
            // TxtRentedModel
            // 
            this.TxtRentedModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRentedModel.Location = new System.Drawing.Point(549, 121);
            this.TxtRentedModel.Name = "TxtRentedModel";
            this.TxtRentedModel.Size = new System.Drawing.Size(157, 30);
            this.TxtRentedModel.TabIndex = 46;
            // 
            // TxtLastRentedModel
            // 
            this.TxtLastRentedModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtLastRentedModel.Location = new System.Drawing.Point(549, 170);
            this.TxtLastRentedModel.Name = "TxtLastRentedModel";
            this.TxtLastRentedModel.Size = new System.Drawing.Size(157, 30);
            this.TxtLastRentedModel.TabIndex = 71;
            // 
            // LblLastRenterModel
            // 
            this.LblLastRenterModel.AutoSize = true;
            this.LblLastRenterModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLastRenterModel.Location = new System.Drawing.Point(333, 173);
            this.LblLastRenterModel.Name = "LblLastRenterModel";
            this.LblLastRenterModel.Size = new System.Drawing.Size(211, 25);
            this.LblLastRenterModel.TabIndex = 72;
            this.LblLastRenterModel.Text = "Son Kiralanan Model : ";
            // 
            // FrmEditCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 563);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.TxtCustomer);
            this.Controls.Add(this.LblCustomer);
            this.Controls.Add(this.CmbID);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GrpEditCustomers);
            this.Name = "FrmEditCustomers";
            this.Text = "Müşteri Düzenle";
            this.GrpEditCustomers.ResumeLayout(false);
            this.GrpEditCustomers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.TextBox TxtCustomer;
        private System.Windows.Forms.Label LblCustomer;
        private System.Windows.Forms.ComboBox CmbID;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox GrpEditCustomers;
        private System.Windows.Forms.CheckBox ChbDeliveryDateNull;
        private System.Windows.Forms.CheckBox ChbDeliveredDateNull;
        private System.Windows.Forms.CheckBox ChbRentDateNull;
        private System.Windows.Forms.Label LblMakeNull;
        private System.Windows.Forms.DateTimePicker DtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker DtpDeliveredDate;
        private System.Windows.Forms.DateTimePicker DtpRentDate;
        private System.Windows.Forms.RichTextBox RtbDescription;
        private System.Windows.Forms.CheckBox ChbDelivered;
        private System.Windows.Forms.CheckBox ChbRenter;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.TextBox TxtTckn;
        private System.Windows.Forms.Label LblDeliveryDate;
        private System.Windows.Forms.Label LblDeliveredDate;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label LblRentDate;
        private System.Windows.Forms.Label LblTckn;
        private System.Windows.Forms.Label LblDateOfBirth;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.TextBox TxtRentedModel;
        private System.Windows.Forms.Label LblRentedModel;
        private System.Windows.Forms.TextBox TxtLastRentedModel;
        private System.Windows.Forms.Label LblLastRenterModel;
    }
}