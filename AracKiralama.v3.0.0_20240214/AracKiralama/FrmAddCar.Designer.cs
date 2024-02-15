namespace AracKiralama
{
    partial class FrmAddCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TbcEditCar = new System.Windows.Forms.TabControl();
            this.TbpAdd = new System.Windows.Forms.TabPage();
            this.ChbDeliveryDateNull = new System.Windows.Forms.CheckBox();
            this.ChbDeliveredDateNull = new System.Windows.Forms.CheckBox();
            this.ChbRentDateNull = new System.Windows.Forms.CheckBox();
            this.LblMakeNull = new System.Windows.Forms.Label();
            this.LblWarning = new System.Windows.Forms.Label();
            this.DtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.DtpDeliveredDate = new System.Windows.Forms.DateTimePicker();
            this.DtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.RtbDescription = new System.Windows.Forms.RichTextBox();
            this.ChbDelivered = new System.Windows.Forms.CheckBox();
            this.ChbRented = new System.Windows.Forms.CheckBox();
            this.ChbDamaged = new System.Windows.Forms.CheckBox();
            this.ChbAutoGear = new System.Windows.Forms.CheckBox();
            this.CmbSeat = new System.Windows.Forms.ComboBox();
            this.LblSeat = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtRenter = new System.Windows.Forms.TextBox();
            this.TxtKm = new System.Windows.Forms.TextBox();
            this.LblDeliveryDate = new System.Windows.Forms.Label();
            this.LblDeliveredDate = new System.Windows.Forms.Label();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.LblRentDate = new System.Windows.Forms.Label();
            this.LblRenter = new System.Windows.Forms.Label();
            this.LblKm = new System.Windows.Forms.Label();
            this.LblModel = new System.Windows.Forms.Label();
            this.TbpDelete = new System.Windows.Forms.TabPage();
            this.DgvCarList = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoGearDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.damagedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.renterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deliveredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRenterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracKiralamaDataSet = new AracKiralama.AracKiralamaDataSet();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.carsTableAdapter = new AracKiralama.AracKiralamaDataSetTableAdapters.CarsTableAdapter();
            this.TbcEditCar.SuspendLayout();
            this.TbpAdd.SuspendLayout();
            this.TbpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcEditCar
            // 
            this.TbcEditCar.Controls.Add(this.TbpAdd);
            this.TbcEditCar.Controls.Add(this.TbpDelete);
            this.TbcEditCar.Location = new System.Drawing.Point(12, 12);
            this.TbcEditCar.Name = "TbcEditCar";
            this.TbcEditCar.SelectedIndex = 0;
            this.TbcEditCar.Size = new System.Drawing.Size(687, 459);
            this.TbcEditCar.TabIndex = 0;
            this.TbcEditCar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbcEditCar_MouseClick);
            // 
            // TbpAdd
            // 
            this.TbpAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbpAdd.Controls.Add(this.ChbDeliveryDateNull);
            this.TbpAdd.Controls.Add(this.ChbDeliveredDateNull);
            this.TbpAdd.Controls.Add(this.ChbRentDateNull);
            this.TbpAdd.Controls.Add(this.LblMakeNull);
            this.TbpAdd.Controls.Add(this.LblWarning);
            this.TbpAdd.Controls.Add(this.DtpDeliveryDate);
            this.TbpAdd.Controls.Add(this.DtpDeliveredDate);
            this.TbpAdd.Controls.Add(this.DtpRentDate);
            this.TbpAdd.Controls.Add(this.RtbDescription);
            this.TbpAdd.Controls.Add(this.ChbDelivered);
            this.TbpAdd.Controls.Add(this.ChbRented);
            this.TbpAdd.Controls.Add(this.ChbDamaged);
            this.TbpAdd.Controls.Add(this.ChbAutoGear);
            this.TbpAdd.Controls.Add(this.CmbSeat);
            this.TbpAdd.Controls.Add(this.LblSeat);
            this.TbpAdd.Controls.Add(this.TxtPrice);
            this.TbpAdd.Controls.Add(this.LblDescription);
            this.TbpAdd.Controls.Add(this.LblPrice);
            this.TbpAdd.Controls.Add(this.TxtRenter);
            this.TbpAdd.Controls.Add(this.TxtKm);
            this.TbpAdd.Controls.Add(this.LblDeliveryDate);
            this.TbpAdd.Controls.Add(this.LblDeliveredDate);
            this.TbpAdd.Controls.Add(this.TxtModel);
            this.TbpAdd.Controls.Add(this.LblRentDate);
            this.TbpAdd.Controls.Add(this.LblRenter);
            this.TbpAdd.Controls.Add(this.LblKm);
            this.TbpAdd.Controls.Add(this.LblModel);
            this.TbpAdd.Location = new System.Drawing.Point(4, 25);
            this.TbpAdd.Name = "TbpAdd";
            this.TbpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.TbpAdd.Size = new System.Drawing.Size(679, 430);
            this.TbpAdd.TabIndex = 0;
            this.TbpAdd.Text = "Ekle";
            // 
            // ChbDeliveryDateNull
            // 
            this.ChbDeliveryDateNull.AutoSize = true;
            this.ChbDeliveryDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDeliveryDateNull.Location = new System.Drawing.Point(637, 353);
            this.ChbDeliveryDateNull.Name = "ChbDeliveryDateNull";
            this.ChbDeliveryDateNull.Size = new System.Drawing.Size(18, 17);
            this.ChbDeliveryDateNull.TabIndex = 15;
            this.ChbDeliveryDateNull.UseVisualStyleBackColor = true;
            this.ChbDeliveryDateNull.CheckedChanged += new System.EventHandler(this.ChbDeliveryDateNull_CheckedChanged);
            // 
            // ChbDeliveredDateNull
            // 
            this.ChbDeliveredDateNull.AutoSize = true;
            this.ChbDeliveredDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDeliveredDateNull.Location = new System.Drawing.Point(637, 309);
            this.ChbDeliveredDateNull.Name = "ChbDeliveredDateNull";
            this.ChbDeliveredDateNull.Size = new System.Drawing.Size(18, 17);
            this.ChbDeliveredDateNull.TabIndex = 13;
            this.ChbDeliveredDateNull.UseVisualStyleBackColor = true;
            this.ChbDeliveredDateNull.CheckedChanged += new System.EventHandler(this.ChbDeliveredDateNull_CheckedChanged);
            // 
            // ChbRentDateNull
            // 
            this.ChbRentDateNull.AutoSize = true;
            this.ChbRentDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbRentDateNull.Location = new System.Drawing.Point(637, 264);
            this.ChbRentDateNull.Name = "ChbRentDateNull";
            this.ChbRentDateNull.Size = new System.Drawing.Size(18, 17);
            this.ChbRentDateNull.TabIndex = 11;
            this.ChbRentDateNull.UseVisualStyleBackColor = true;
            this.ChbRentDateNull.CheckedChanged += new System.EventHandler(this.ChbRentDateNull_CheckedChanged);
            // 
            // LblMakeNull
            // 
            this.LblMakeNull.AutoSize = true;
            this.LblMakeNull.BackColor = System.Drawing.Color.Transparent;
            this.LblMakeNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMakeNull.Location = new System.Drawing.Point(615, 232);
            this.LblMakeNull.Name = "LblMakeNull";
            this.LblMakeNull.Size = new System.Drawing.Size(58, 16);
            this.LblMakeNull.TabIndex = 70;
            this.LblMakeNull.Text = "Null Yap";
            // 
            // LblWarning
            // 
            this.LblWarning.AutoSize = true;
            this.LblWarning.Location = new System.Drawing.Point(10, 400);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(260, 16);
            this.LblWarning.TabIndex = 33;
            this.LblWarning.Text = "* İle İşaretlenenler Doldurulmak Zorundadır";
            // 
            // DtpDeliveryDate
            // 
            this.DtpDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDeliveryDate.Location = new System.Drawing.Point(453, 343);
            this.DtpDeliveryDate.Name = "DtpDeliveryDate";
            this.DtpDeliveryDate.Size = new System.Drawing.Size(172, 27);
            this.DtpDeliveryDate.TabIndex = 14;
            // 
            // DtpDeliveredDate
            // 
            this.DtpDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDeliveredDate.Location = new System.Drawing.Point(453, 300);
            this.DtpDeliveredDate.Name = "DtpDeliveredDate";
            this.DtpDeliveredDate.Size = new System.Drawing.Size(173, 27);
            this.DtpDeliveredDate.TabIndex = 12;
            // 
            // DtpRentDate
            // 
            this.DtpRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpRentDate.Location = new System.Drawing.Point(453, 255);
            this.DtpRentDate.Name = "DtpRentDate";
            this.DtpRentDate.Size = new System.Drawing.Size(172, 27);
            this.DtpRentDate.TabIndex = 10;
            // 
            // RtbDescription
            // 
            this.RtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RtbDescription.Location = new System.Drawing.Point(13, 253);
            this.RtbDescription.Name = "RtbDescription";
            this.RtbDescription.Size = new System.Drawing.Size(230, 117);
            this.RtbDescription.TabIndex = 9;
            this.RtbDescription.Text = "";
            // 
            // ChbDelivered
            // 
            this.ChbDelivered.AutoSize = true;
            this.ChbDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDelivered.Location = new System.Drawing.Point(465, 86);
            this.ChbDelivered.Name = "ChbDelivered";
            this.ChbDelivered.Size = new System.Drawing.Size(144, 29);
            this.ChbDelivered.TabIndex = 7;
            this.ChbDelivered.Text = "Teslim Edildi";
            this.ChbDelivered.UseVisualStyleBackColor = true;
            // 
            // ChbRented
            // 
            this.ChbRented.AutoSize = true;
            this.ChbRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbRented.Location = new System.Drawing.Point(465, 51);
            this.ChbRented.Name = "ChbRented";
            this.ChbRented.Size = new System.Drawing.Size(110, 29);
            this.ChbRented.TabIndex = 6;
            this.ChbRented.Text = "Kiralandı";
            this.ChbRented.UseVisualStyleBackColor = true;
            // 
            // ChbDamaged
            // 
            this.ChbDamaged.AutoSize = true;
            this.ChbDamaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDamaged.Location = new System.Drawing.Point(332, 86);
            this.ChbDamaged.Name = "ChbDamaged";
            this.ChbDamaged.Size = new System.Drawing.Size(94, 29);
            this.ChbDamaged.TabIndex = 5;
            this.ChbDamaged.Text = "Hasarlı";
            this.ChbDamaged.UseVisualStyleBackColor = true;
            // 
            // ChbAutoGear
            // 
            this.ChbAutoGear.AutoSize = true;
            this.ChbAutoGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbAutoGear.Location = new System.Drawing.Point(332, 51);
            this.ChbAutoGear.Name = "ChbAutoGear";
            this.ChbAutoGear.Size = new System.Drawing.Size(115, 29);
            this.ChbAutoGear.TabIndex = 4;
            this.ChbAutoGear.Text = "Oto Vites";
            this.ChbAutoGear.UseVisualStyleBackColor = true;
            // 
            // CmbSeat
            // 
            this.CmbSeat.DisplayMember = "4";
            this.CmbSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbSeat.FormattingEnabled = true;
            this.CmbSeat.Items.AddRange(new object[] {
            "2",
            "4",
            "5"});
            this.CmbSeat.Location = new System.Drawing.Point(503, 144);
            this.CmbSeat.Name = "CmbSeat";
            this.CmbSeat.Size = new System.Drawing.Size(55, 33);
            this.CmbSeat.TabIndex = 8;
            // 
            // LblSeat
            // 
            this.LblSeat.AutoSize = true;
            this.LblSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSeat.Location = new System.Drawing.Point(357, 147);
            this.LblSeat.Name = "LblSeat";
            this.LblSeat.Size = new System.Drawing.Size(141, 25);
            this.LblSeat.TabIndex = 23;
            this.LblSeat.Text = "Koltuk Sayısı : ";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPrice.Location = new System.Drawing.Point(124, 29);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(151, 30);
            this.TxtPrice.TabIndex = 0;
            this.TxtPrice.TextChanged += new System.EventHandler(this.TxtPrice_TextChanged);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDescription.Location = new System.Drawing.Point(8, 225);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(108, 25);
            this.LblDescription.TabIndex = 22;
            this.LblDescription.Text = "Açıklama : ";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPrice.Location = new System.Drawing.Point(40, 32);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(78, 25);
            this.LblPrice.TabIndex = 21;
            this.LblPrice.Text = "*Fiyat : ";
            // 
            // TxtRenter
            // 
            this.TxtRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRenter.Location = new System.Drawing.Point(123, 174);
            this.TxtRenter.Name = "TxtRenter";
            this.TxtRenter.Size = new System.Drawing.Size(151, 30);
            this.TxtRenter.TabIndex = 3;
            // 
            // TxtKm
            // 
            this.TxtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKm.Location = new System.Drawing.Point(124, 124);
            this.TxtKm.Name = "TxtKm";
            this.TxtKm.Size = new System.Drawing.Size(151, 30);
            this.TxtKm.TabIndex = 2;
            this.TxtKm.TextChanged += new System.EventHandler(this.TxtKm_TextChanged);
            // 
            // LblDeliveryDate
            // 
            this.LblDeliveryDate.AutoSize = true;
            this.LblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDeliveryDate.Location = new System.Drawing.Point(307, 345);
            this.LblDeliveryDate.Name = "LblDeliveryDate";
            this.LblDeliveryDate.Size = new System.Drawing.Size(140, 25);
            this.LblDeliveryDate.TabIndex = 16;
            this.LblDeliveryDate.Text = "Teslim Tarihi : ";
            // 
            // LblDeliveredDate
            // 
            this.LblDeliveredDate.AutoSize = true;
            this.LblDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDeliveredDate.Location = new System.Drawing.Point(252, 301);
            this.LblDeliveredDate.Name = "LblDeliveredDate";
            this.LblDeliveredDate.Size = new System.Drawing.Size(195, 25);
            this.LblDeliveredDate.TabIndex = 15;
            this.LblDeliveredDate.Text = "Teslim Edilen Tarih : ";
            // 
            // TxtModel
            // 
            this.TxtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtModel.Location = new System.Drawing.Point(124, 78);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(151, 30);
            this.TxtModel.TabIndex = 1;
            // 
            // LblRentDate
            // 
            this.LblRentDate.AutoSize = true;
            this.LblRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRentDate.Location = new System.Drawing.Point(286, 256);
            this.LblRentDate.Name = "LblRentDate";
            this.LblRentDate.Size = new System.Drawing.Size(161, 25);
            this.LblRentDate.TabIndex = 13;
            this.LblRentDate.Text = "Kiralanan Tarih : ";
            // 
            // LblRenter
            // 
            this.LblRenter.AutoSize = true;
            this.LblRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRenter.Location = new System.Drawing.Point(8, 177);
            this.LblRenter.Name = "LblRenter";
            this.LblRenter.Size = new System.Drawing.Size(110, 25);
            this.LblRenter.TabIndex = 12;
            this.LblRenter.Text = "Kiralayan : ";
            // 
            // LblKm
            // 
            this.LblKm.AutoSize = true;
            this.LblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKm.Location = new System.Drawing.Point(52, 127);
            this.LblKm.Name = "LblKm";
            this.LblKm.Size = new System.Drawing.Size(58, 25);
            this.LblKm.TabIndex = 19;
            this.LblKm.Text = "Km : ";
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblModel.Location = new System.Drawing.Point(28, 81);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(90, 25);
            this.LblModel.TabIndex = 11;
            this.LblModel.Text = "*Model : ";
            // 
            // TbpDelete
            // 
            this.TbpDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbpDelete.Controls.Add(this.DgvCarList);
            this.TbpDelete.Location = new System.Drawing.Point(4, 25);
            this.TbpDelete.Name = "TbpDelete";
            this.TbpDelete.Padding = new System.Windows.Forms.Padding(3);
            this.TbpDelete.Size = new System.Drawing.Size(679, 430);
            this.TbpDelete.TabIndex = 1;
            this.TbpDelete.Text = "Çıkar";
            // 
            // DgvCarList
            // 
            this.DgvCarList.AllowUserToAddRows = false;
            this.DgvCarList.AllowUserToOrderColumns = true;
            this.DgvCarList.AutoGenerateColumns = false;
            this.DgvCarList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvCarList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn,
            this.seatDataGridViewTextBoxColumn,
            this.autoGearDataGridViewCheckBoxColumn,
            this.damagedDataGridViewCheckBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.rentedDataGridViewCheckBoxColumn,
            this.renterDataGridViewTextBoxColumn,
            this.rentDateDataGridViewTextBoxColumn,
            this.deliveredDataGridViewCheckBoxColumn,
            this.deliveredDateDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.lastRenterDataGridViewTextBoxColumn});
            this.DgvCarList.DataSource = this.carsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCarList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCarList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvCarList.Location = new System.Drawing.Point(6, 6);
            this.DgvCarList.MultiSelect = false;
            this.DgvCarList.Name = "DgvCarList";
            this.DgvCarList.RowHeadersWidth = 5;
            this.DgvCarList.RowTemplate.Height = 50;
            this.DgvCarList.Size = new System.Drawing.Size(667, 418);
            this.DgvCarList.TabIndex = 6;
            this.DgvCarList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvCarList_RowPostPaint);
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 67;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 74;
            // 
            // kmDataGridViewTextBoxColumn
            // 
            this.kmDataGridViewTextBoxColumn.DataPropertyName = "Km";
            this.kmDataGridViewTextBoxColumn.HeaderText = "Km";
            this.kmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kmDataGridViewTextBoxColumn.Name = "kmDataGridViewTextBoxColumn";
            this.kmDataGridViewTextBoxColumn.Width = 55;
            // 
            // seatDataGridViewTextBoxColumn
            // 
            this.seatDataGridViewTextBoxColumn.DataPropertyName = "Seat";
            this.seatDataGridViewTextBoxColumn.HeaderText = "Seat";
            this.seatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatDataGridViewTextBoxColumn.Name = "seatDataGridViewTextBoxColumn";
            this.seatDataGridViewTextBoxColumn.Width = 64;
            // 
            // autoGearDataGridViewCheckBoxColumn
            // 
            this.autoGearDataGridViewCheckBoxColumn.DataPropertyName = "AutoGear";
            this.autoGearDataGridViewCheckBoxColumn.HeaderText = "AutoGear";
            this.autoGearDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.autoGearDataGridViewCheckBoxColumn.Name = "autoGearDataGridViewCheckBoxColumn";
            this.autoGearDataGridViewCheckBoxColumn.Width = 70;
            // 
            // damagedDataGridViewCheckBoxColumn
            // 
            this.damagedDataGridViewCheckBoxColumn.DataPropertyName = "Damaged";
            this.damagedDataGridViewCheckBoxColumn.HeaderText = "Damaged";
            this.damagedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.damagedDataGridViewCheckBoxColumn.Name = "damagedDataGridViewCheckBoxColumn";
            this.damagedDataGridViewCheckBoxColumn.Width = 74;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 104;
            // 
            // rentedDataGridViewCheckBoxColumn
            // 
            this.rentedDataGridViewCheckBoxColumn.DataPropertyName = "Rented";
            this.rentedDataGridViewCheckBoxColumn.HeaderText = "Rented";
            this.rentedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rentedDataGridViewCheckBoxColumn.Name = "rentedDataGridViewCheckBoxColumn";
            this.rentedDataGridViewCheckBoxColumn.Width = 57;
            // 
            // renterDataGridViewTextBoxColumn
            // 
            this.renterDataGridViewTextBoxColumn.DataPropertyName = "Renter";
            this.renterDataGridViewTextBoxColumn.HeaderText = "Renter";
            this.renterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.renterDataGridViewTextBoxColumn.Name = "renterDataGridViewTextBoxColumn";
            this.renterDataGridViewTextBoxColumn.Width = 76;
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
            // lastRenterDataGridViewTextBoxColumn
            // 
            this.lastRenterDataGridViewTextBoxColumn.DataPropertyName = "LastRenter";
            this.lastRenterDataGridViewTextBoxColumn.HeaderText = "LastRenter";
            this.lastRenterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastRenterDataGridViewTextBoxColumn.Name = "lastRenterDataGridViewTextBoxColumn";
            this.lastRenterDataGridViewTextBoxColumn.Width = 101;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.aracKiralamaDataSet;
            // 
            // aracKiralamaDataSet
            // 
            this.aracKiralamaDataSet.DataSetName = "AracKiralamaDataSet";
            this.aracKiralamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Location = new System.Drawing.Point(600, 477);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 50);
            this.BtnSave.TabIndex = 20;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.BtnSave.MouseEnter += new System.EventHandler(this.BtnSave_MouseEnter);
            this.BtnSave.MouseLeave += new System.EventHandler(this.BtnSave_MouseLeave);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Location = new System.Drawing.Point(12, 477);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 50);
            this.BtnClose.TabIndex = 21;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 536);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TbcEditCar);
            this.Name = "FrmAddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Ekle\\Çıkar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddCar_FormClosing);
            this.Load += new System.EventHandler(this.FrmEditCar_Load);
            this.TbcEditCar.ResumeLayout(false);
            this.TbpAdd.ResumeLayout(false);
            this.TbpAdd.PerformLayout();
            this.TbpDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcEditCar;
        private System.Windows.Forms.TabPage TbpAdd;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblWarning;
        private System.Windows.Forms.DateTimePicker DtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker DtpDeliveredDate;
        private System.Windows.Forms.DateTimePicker DtpRentDate;
        private System.Windows.Forms.RichTextBox RtbDescription;
        private System.Windows.Forms.CheckBox ChbDelivered;
        private System.Windows.Forms.CheckBox ChbRented;
        private System.Windows.Forms.CheckBox ChbDamaged;
        private System.Windows.Forms.CheckBox ChbAutoGear;
        private System.Windows.Forms.ComboBox CmbSeat;
        private System.Windows.Forms.Label LblSeat;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtRenter;
        private System.Windows.Forms.TextBox TxtKm;
        private System.Windows.Forms.Label LblDeliveryDate;
        private System.Windows.Forms.Label LblDeliveredDate;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.Label LblRentDate;
        private System.Windows.Forms.Label LblRenter;
        private System.Windows.Forms.Label LblKm;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.TabPage TbpDelete;
        private System.Windows.Forms.CheckBox ChbDeliveryDateNull;
        private System.Windows.Forms.CheckBox ChbDeliveredDateNull;
        private System.Windows.Forms.CheckBox ChbRentDateNull;
        private System.Windows.Forms.Label LblMakeNull;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView DgvCarList;
        private AracKiralamaDataSet aracKiralamaDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private AracKiralamaDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoGearDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn damagedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rentedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deliveredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastRenterDataGridViewTextBoxColumn;
    }
}