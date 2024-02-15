namespace AracKiralama
{
    partial class FrmAddCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TbcAddCustomer = new System.Windows.Forms.TabControl();
            this.TbpAdd = new System.Windows.Forms.TabPage();
            this.CmbRentedModel = new System.Windows.Forms.ComboBox();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.ChbDeliveryDateNull = new System.Windows.Forms.CheckBox();
            this.ChbDeliveredDateNull = new System.Windows.Forms.CheckBox();
            this.ChbRentDateNull = new System.Windows.Forms.CheckBox();
            this.LblMakeNull = new System.Windows.Forms.Label();
            this.DtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.DtpDeliveredDate = new System.Windows.Forms.DateTimePicker();
            this.DtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.ChbDelivered = new System.Windows.Forms.CheckBox();
            this.ChbRenter = new System.Windows.Forms.CheckBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblRentedModel = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.TxtTckn = new System.Windows.Forms.TextBox();
            this.LblDeliveryDate = new System.Windows.Forms.Label();
            this.LblDeliveredDate = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LblNumber = new System.Windows.Forms.Label();
            this.LblRentDate = new System.Windows.Forms.Label();
            this.LblTckn = new System.Windows.Forms.Label();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.TbpDelete = new System.Windows.Forms.TabPage();
            this.DgvCustomerList = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcknDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rentedModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deliveredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRentedModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracKiralamaDataSet = new AracKiralama.AracKiralamaDataSet();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.customersTableAdapter = new AracKiralama.AracKiralamaDataSetTableAdapters.CustomersTableAdapter();
            this.TbcAddCustomer.SuspendLayout();
            this.TbpAdd.SuspendLayout();
            this.TbpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcAddCustomer
            // 
            this.TbcAddCustomer.Controls.Add(this.TbpAdd);
            this.TbcAddCustomer.Controls.Add(this.TbpDelete);
            this.TbcAddCustomer.Location = new System.Drawing.Point(12, 12);
            this.TbcAddCustomer.Name = "TbcAddCustomer";
            this.TbcAddCustomer.SelectedIndex = 0;
            this.TbcAddCustomer.Size = new System.Drawing.Size(751, 473);
            this.TbcAddCustomer.TabIndex = 0;
            this.TbcAddCustomer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbcAddCustomer_MouseClick);
            // 
            // TbpAdd
            // 
            this.TbpAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbpAdd.Controls.Add(this.CmbRentedModel);
            this.TbpAdd.Controls.Add(this.DtpDateOfBirth);
            this.TbpAdd.Controls.Add(this.ChbDeliveryDateNull);
            this.TbpAdd.Controls.Add(this.ChbDeliveredDateNull);
            this.TbpAdd.Controls.Add(this.ChbRentDateNull);
            this.TbpAdd.Controls.Add(this.LblMakeNull);
            this.TbpAdd.Controls.Add(this.DtpDeliveryDate);
            this.TbpAdd.Controls.Add(this.DtpDeliveredDate);
            this.TbpAdd.Controls.Add(this.DtpRentDate);
            this.TbpAdd.Controls.Add(this.ChbDelivered);
            this.TbpAdd.Controls.Add(this.ChbRenter);
            this.TbpAdd.Controls.Add(this.TxtMail);
            this.TbpAdd.Controls.Add(this.TxtName);
            this.TbpAdd.Controls.Add(this.LblRentedModel);
            this.TbpAdd.Controls.Add(this.LblMail);
            this.TbpAdd.Controls.Add(this.LblName);
            this.TbpAdd.Controls.Add(this.TxtNumber);
            this.TbpAdd.Controls.Add(this.TxtTckn);
            this.TbpAdd.Controls.Add(this.LblDeliveryDate);
            this.TbpAdd.Controls.Add(this.LblDeliveredDate);
            this.TbpAdd.Controls.Add(this.TxtSurname);
            this.TbpAdd.Controls.Add(this.LblNumber);
            this.TbpAdd.Controls.Add(this.LblRentDate);
            this.TbpAdd.Controls.Add(this.LblTckn);
            this.TbpAdd.Controls.Add(this.LblDateOfBirth);
            this.TbpAdd.Controls.Add(this.LblSurname);
            this.TbpAdd.Location = new System.Drawing.Point(4, 25);
            this.TbpAdd.Name = "TbpAdd";
            this.TbpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.TbpAdd.Size = new System.Drawing.Size(743, 444);
            this.TbpAdd.TabIndex = 0;
            this.TbpAdd.Text = "Ekle";
            // 
            // CmbRentedModel
            // 
            this.CmbRentedModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRentedModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbRentedModel.FormattingEnabled = true;
            this.CmbRentedModel.Location = new System.Drawing.Point(523, 116);
            this.CmbRentedModel.Name = "CmbRentedModel";
            this.CmbRentedModel.Size = new System.Drawing.Size(167, 28);
            this.CmbRentedModel.TabIndex = 79;
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDateOfBirth.Location = new System.Drawing.Point(140, 119);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(194, 27);
            this.DtpDateOfBirth.TabIndex = 75;
            // 
            // ChbDeliveryDateNull
            // 
            this.ChbDeliveryDateNull.AutoSize = true;
            this.ChbDeliveryDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDeliveryDateNull.Location = new System.Drawing.Point(534, 415);
            this.ChbDeliveryDateNull.Name = "ChbDeliveryDateNull";
            this.ChbDeliveryDateNull.Size = new System.Drawing.Size(18, 17);
            this.ChbDeliveryDateNull.TabIndex = 88;
            this.ChbDeliveryDateNull.UseVisualStyleBackColor = true;
            this.ChbDeliveryDateNull.CheckedChanged += new System.EventHandler(this.ChbDeliveryDateNull_CheckedChanged);
            // 
            // ChbDeliveredDateNull
            // 
            this.ChbDeliveredDateNull.AutoSize = true;
            this.ChbDeliveredDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDeliveredDateNull.Location = new System.Drawing.Point(534, 371);
            this.ChbDeliveredDateNull.Name = "ChbDeliveredDateNull";
            this.ChbDeliveredDateNull.Size = new System.Drawing.Size(18, 17);
            this.ChbDeliveredDateNull.TabIndex = 86;
            this.ChbDeliveredDateNull.UseVisualStyleBackColor = true;
            this.ChbDeliveredDateNull.CheckedChanged += new System.EventHandler(this.ChbDeliveredDateNull_CheckedChanged);
            // 
            // ChbRentDateNull
            // 
            this.ChbRentDateNull.AutoSize = true;
            this.ChbRentDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbRentDateNull.Location = new System.Drawing.Point(534, 326);
            this.ChbRentDateNull.Name = "ChbRentDateNull";
            this.ChbRentDateNull.Size = new System.Drawing.Size(18, 17);
            this.ChbRentDateNull.TabIndex = 84;
            this.ChbRentDateNull.UseVisualStyleBackColor = true;
            this.ChbRentDateNull.CheckedChanged += new System.EventHandler(this.ChbRentDateNull_CheckedChanged);
            // 
            // LblMakeNull
            // 
            this.LblMakeNull.AutoSize = true;
            this.LblMakeNull.BackColor = System.Drawing.Color.Transparent;
            this.LblMakeNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMakeNull.Location = new System.Drawing.Point(503, 294);
            this.LblMakeNull.Name = "LblMakeNull";
            this.LblMakeNull.Size = new System.Drawing.Size(71, 20);
            this.LblMakeNull.TabIndex = 99;
            this.LblMakeNull.Text = "Null Yap";
            // 
            // DtpDeliveryDate
            // 
            this.DtpDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDeliveryDate.Location = new System.Drawing.Point(340, 405);
            this.DtpDeliveryDate.Name = "DtpDeliveryDate";
            this.DtpDeliveryDate.Size = new System.Drawing.Size(174, 27);
            this.DtpDeliveryDate.TabIndex = 87;
            // 
            // DtpDeliveredDate
            // 
            this.DtpDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDeliveredDate.Location = new System.Drawing.Point(340, 363);
            this.DtpDeliveredDate.Name = "DtpDeliveredDate";
            this.DtpDeliveredDate.Size = new System.Drawing.Size(174, 27);
            this.DtpDeliveredDate.TabIndex = 85;
            // 
            // DtpRentDate
            // 
            this.DtpRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpRentDate.Location = new System.Drawing.Point(340, 317);
            this.DtpRentDate.Name = "DtpRentDate";
            this.DtpRentDate.Size = new System.Drawing.Size(174, 27);
            this.DtpRentDate.TabIndex = 83;
            // 
            // ChbDelivered
            // 
            this.ChbDelivered.AutoSize = true;
            this.ChbDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDelivered.Location = new System.Drawing.Point(547, 163);
            this.ChbDelivered.Name = "ChbDelivered";
            this.ChbDelivered.Size = new System.Drawing.Size(127, 24);
            this.ChbDelivered.TabIndex = 82;
            this.ChbDelivered.Text = "Teslim Edildi";
            this.ChbDelivered.UseVisualStyleBackColor = true;
            // 
            // ChbRenter
            // 
            this.ChbRenter.AutoSize = true;
            this.ChbRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbRenter.Location = new System.Drawing.Point(424, 163);
            this.ChbRenter.Name = "ChbRenter";
            this.ChbRenter.Size = new System.Drawing.Size(74, 24);
            this.ChbRenter.TabIndex = 81;
            this.ChbRenter.Text = "Kiracı";
            this.ChbRenter.UseVisualStyleBackColor = true;
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(140, 256);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(194, 27);
            this.TxtMail.TabIndex = 78;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Location = new System.Drawing.Point(140, 18);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(194, 27);
            this.TxtName.TabIndex = 73;
            // 
            // LblRentedModel
            // 
            this.LblRentedModel.AutoSize = true;
            this.LblRentedModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRentedModel.Location = new System.Drawing.Point(370, 119);
            this.LblRentedModel.Name = "LblRentedModel";
            this.LblRentedModel.Size = new System.Drawing.Size(144, 20);
            this.LblRentedModel.TabIndex = 98;
            this.LblRentedModel.Text = "Kiralanan Model : ";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMail.Location = new System.Drawing.Point(79, 259);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(55, 20);
            this.LblMail.TabIndex = 97;
            this.LblMail.Text = "Mail : ";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(79, 21);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(61, 20);
            this.LblName.TabIndex = 96;
            this.LblName.Text = "*İsim : ";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNumber.Location = new System.Drawing.Point(140, 210);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(194, 27);
            this.TxtNumber.TabIndex = 77;
            // 
            // TxtTckn
            // 
            this.TxtTckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTckn.Location = new System.Drawing.Point(140, 164);
            this.TxtTckn.Name = "TxtTckn";
            this.TxtTckn.Size = new System.Drawing.Size(194, 27);
            this.TxtTckn.TabIndex = 76;
            // 
            // LblDeliveryDate
            // 
            this.LblDeliveryDate.AutoSize = true;
            this.LblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDeliveryDate.Location = new System.Drawing.Point(213, 410);
            this.LblDeliveryDate.Name = "LblDeliveryDate";
            this.LblDeliveryDate.Size = new System.Drawing.Size(121, 20);
            this.LblDeliveryDate.TabIndex = 94;
            this.LblDeliveryDate.Text = "Teslim Tarihi : ";
            // 
            // LblDeliveredDate
            // 
            this.LblDeliveredDate.AutoSize = true;
            this.LblDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDeliveredDate.Location = new System.Drawing.Point(166, 368);
            this.LblDeliveredDate.Name = "LblDeliveredDate";
            this.LblDeliveredDate.Size = new System.Drawing.Size(168, 20);
            this.LblDeliveredDate.TabIndex = 93;
            this.LblDeliveredDate.Text = "Teslim Edilen Tarih : ";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSurname.Location = new System.Drawing.Point(140, 67);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(194, 27);
            this.TxtSurname.TabIndex = 74;
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNumber.Location = new System.Drawing.Point(55, 213);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(85, 20);
            this.LblNumber.TabIndex = 91;
            this.LblNumber.Text = "*Telefon : ";
            // 
            // LblRentDate
            // 
            this.LblRentDate.AutoSize = true;
            this.LblRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRentDate.Location = new System.Drawing.Point(197, 322);
            this.LblRentDate.Name = "LblRentDate";
            this.LblRentDate.Size = new System.Drawing.Size(137, 20);
            this.LblRentDate.TabIndex = 92;
            this.LblRentDate.Text = "Kiralanan Tarih : ";
            // 
            // LblTckn
            // 
            this.LblTckn.AutoSize = true;
            this.LblTckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTckn.Location = new System.Drawing.Point(12, 167);
            this.LblTckn.Name = "LblTckn";
            this.LblTckn.Size = new System.Drawing.Size(128, 20);
            this.LblTckn.TabIndex = 90;
            this.LblTckn.Text = "*TC Kimlik No : ";
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDateOfBirth.Location = new System.Drawing.Point(9, 124);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(131, 20);
            this.LblDateOfBirth.TabIndex = 95;
            this.LblDateOfBirth.Text = "*Doğum Tarihi : ";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSurname.Location = new System.Drawing.Point(51, 70);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(89, 20);
            this.LblSurname.TabIndex = 89;
            this.LblSurname.Text = "*Soyisim : ";
            // 
            // TbpDelete
            // 
            this.TbpDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbpDelete.Controls.Add(this.DgvCustomerList);
            this.TbpDelete.Location = new System.Drawing.Point(4, 25);
            this.TbpDelete.Name = "TbpDelete";
            this.TbpDelete.Padding = new System.Windows.Forms.Padding(3);
            this.TbpDelete.Size = new System.Drawing.Size(743, 444);
            this.TbpDelete.TabIndex = 1;
            this.TbpDelete.Text = "Çıkar";
            // 
            // DgvCustomerList
            // 
            this.DgvCustomerList.AllowUserToAddRows = false;
            this.DgvCustomerList.AllowUserToOrderColumns = true;
            this.DgvCustomerList.AutoGenerateColumns = false;
            this.DgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvCustomerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.tcknDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.renterDataGridViewCheckBoxColumn,
            this.rentedModelDataGridViewTextBoxColumn,
            this.rentDateDataGridViewTextBoxColumn,
            this.deliveredDataGridViewCheckBoxColumn,
            this.deliveredDateDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.lastRentedModelDataGridViewTextBoxColumn});
            this.DgvCustomerList.DataSource = this.customersBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCustomerList.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvCustomerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvCustomerList.Location = new System.Drawing.Point(6, 6);
            this.DgvCustomerList.MultiSelect = false;
            this.DgvCustomerList.Name = "DgvCustomerList";
            this.DgvCustomerList.RowHeadersWidth = 5;
            this.DgvCustomerList.RowTemplate.Height = 50;
            this.DgvCustomerList.Size = new System.Drawing.Size(731, 435);
            this.DgvCustomerList.TabIndex = 5;
            this.DgvCustomerList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvCustomerList_RowPostPaint);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 47;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 73;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 90;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 104;
            // 
            // tcknDataGridViewTextBoxColumn
            // 
            this.tcknDataGridViewTextBoxColumn.DataPropertyName = "Tckn";
            this.tcknDataGridViewTextBoxColumn.HeaderText = "Tckn";
            this.tcknDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcknDataGridViewTextBoxColumn.Name = "tcknDataGridViewTextBoxColumn";
            this.tcknDataGridViewTextBoxColumn.Width = 66;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 84;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 61;
            // 
            // renterDataGridViewCheckBoxColumn
            // 
            this.renterDataGridViewCheckBoxColumn.DataPropertyName = "Renter";
            this.renterDataGridViewCheckBoxColumn.HeaderText = "Renter";
            this.renterDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.renterDataGridViewCheckBoxColumn.Name = "renterDataGridViewCheckBoxColumn";
            this.renterDataGridViewCheckBoxColumn.Width = 53;
            // 
            // rentedModelDataGridViewTextBoxColumn
            // 
            this.rentedModelDataGridViewTextBoxColumn.DataPropertyName = "RentedModel";
            this.rentedModelDataGridViewTextBoxColumn.HeaderText = "RentedModel";
            this.rentedModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentedModelDataGridViewTextBoxColumn.Name = "rentedModelDataGridViewTextBoxColumn";
            this.rentedModelDataGridViewTextBoxColumn.Width = 118;
            // 
            // rentDateDataGridViewTextBoxColumn
            // 
            this.rentDateDataGridViewTextBoxColumn.DataPropertyName = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.HeaderText = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentDateDataGridViewTextBoxColumn.Name = "rentDateDataGridViewTextBoxColumn";
            this.rentDateDataGridViewTextBoxColumn.Width = 93;
            // 
            // deliveredDataGridViewCheckBoxColumn
            // 
            this.deliveredDataGridViewCheckBoxColumn.DataPropertyName = "Delivered";
            this.deliveredDataGridViewCheckBoxColumn.HeaderText = "Delivered";
            this.deliveredDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.deliveredDataGridViewCheckBoxColumn.Name = "deliveredDataGridViewCheckBoxColumn";
            this.deliveredDataGridViewCheckBoxColumn.Width = 72;
            // 
            // deliveredDateDataGridViewTextBoxColumn
            // 
            this.deliveredDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveredDate";
            this.deliveredDateDataGridViewTextBoxColumn.HeaderText = "DeliveredDate";
            this.deliveredDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveredDateDataGridViewTextBoxColumn.Name = "deliveredDateDataGridViewTextBoxColumn";
            this.deliveredDateDataGridViewTextBoxColumn.Width = 124;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.Width = 115;
            // 
            // lastRentedModelDataGridViewTextBoxColumn
            // 
            this.lastRentedModelDataGridViewTextBoxColumn.DataPropertyName = "LastRentedModel";
            this.lastRentedModelDataGridViewTextBoxColumn.HeaderText = "LastRentedModel";
            this.lastRentedModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastRentedModelDataGridViewTextBoxColumn.Name = "lastRentedModelDataGridViewTextBoxColumn";
            this.lastRentedModelDataGridViewTextBoxColumn.Width = 143;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.aracKiralamaDataSet;
            // 
            // aracKiralamaDataSet
            // 
            this.aracKiralamaDataSet.DataSetName = "AracKiralamaDataSet";
            this.aracKiralamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Location = new System.Drawing.Point(10, 491);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 50);
            this.BtnClose.TabIndex = 23;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Location = new System.Drawing.Point(662, 491);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 50);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.BtnSave.MouseEnter += new System.EventHandler(this.BtnSave_MouseEnter);
            this.BtnSave.MouseLeave += new System.EventHandler(this.BtnSave_MouseLeave);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 549);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TbcAddCustomer);
            this.Name = "FrmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle\\Çıkar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddCustomer_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddCustomer_Load);
            this.TbcAddCustomer.ResumeLayout(false);
            this.TbpAdd.ResumeLayout(false);
            this.TbpAdd.PerformLayout();
            this.TbpDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcAddCustomer;
        private System.Windows.Forms.TabPage TbpAdd;
        private System.Windows.Forms.TabPage TbpDelete;
        private System.Windows.Forms.ComboBox CmbRentedModel;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.CheckBox ChbDeliveryDateNull;
        private System.Windows.Forms.CheckBox ChbDeliveredDateNull;
        private System.Windows.Forms.CheckBox ChbRentDateNull;
        private System.Windows.Forms.Label LblMakeNull;
        private System.Windows.Forms.DateTimePicker DtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker DtpDeliveredDate;
        private System.Windows.Forms.DateTimePicker DtpRentDate;
        private System.Windows.Forms.CheckBox ChbDelivered;
        private System.Windows.Forms.CheckBox ChbRenter;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblRentedModel;
        private System.Windows.Forms.Label LblMail;
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
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridView DgvCustomerList;
        private AracKiralamaDataSet aracKiralamaDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private AracKiralamaDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcknDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn renterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentedModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deliveredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastRentedModelDataGridViewTextBoxColumn;
    }
}