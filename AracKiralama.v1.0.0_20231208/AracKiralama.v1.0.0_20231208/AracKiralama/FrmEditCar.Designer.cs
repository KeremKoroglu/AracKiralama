namespace AracKiralama
{
    partial class FrmEditCar
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
            this.TbcEditCar = new System.Windows.Forms.TabControl();
            this.TbpAdd = new System.Windows.Forms.TabPage();
            this.BtnSave = new System.Windows.Forms.Button();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtKm = new System.Windows.Forms.TextBox();
            this.LblDeliveryDate = new System.Windows.Forms.Label();
            this.LblDeliveredDate = new System.Windows.Forms.Label();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.LblRentDate = new System.Windows.Forms.Label();
            this.LblRenter = new System.Windows.Forms.Label();
            this.LblKm = new System.Windows.Forms.Label();
            this.LblModel = new System.Windows.Forms.Label();
            this.TbpDelete = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblDelete = new System.Windows.Forms.Label();
            this.TbcEditCar.SuspendLayout();
            this.TbpAdd.SuspendLayout();
            this.TbpDelete.SuspendLayout();
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
            // 
            // TbpAdd
            // 
            this.TbpAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.TbpAdd.Controls.Add(this.textBox1);
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
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Location = new System.Drawing.Point(12, 477);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 50);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = true;
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
            this.DtpDeliveryDate.Location = new System.Drawing.Point(457, 343);
            this.DtpDeliveryDate.Name = "DtpDeliveryDate";
            this.DtpDeliveryDate.Size = new System.Drawing.Size(172, 27);
            this.DtpDeliveryDate.TabIndex = 12;
            this.DtpDeliveryDate.Visible = false;
            // 
            // DtpDeliveredDate
            // 
            this.DtpDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDeliveredDate.Location = new System.Drawing.Point(457, 300);
            this.DtpDeliveredDate.Name = "DtpDeliveredDate";
            this.DtpDeliveredDate.Size = new System.Drawing.Size(173, 27);
            this.DtpDeliveredDate.TabIndex = 11;
            this.DtpDeliveredDate.Visible = false;
            // 
            // DtpRentDate
            // 
            this.DtpRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpRentDate.Location = new System.Drawing.Point(457, 255);
            this.DtpRentDate.Name = "DtpRentDate";
            this.DtpRentDate.Size = new System.Drawing.Size(172, 27);
            this.DtpRentDate.TabIndex = 10;
            this.DtpRentDate.Visible = false;
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
            this.ChbDelivered.Location = new System.Drawing.Point(448, 66);
            this.ChbDelivered.Name = "ChbDelivered";
            this.ChbDelivered.Size = new System.Drawing.Size(152, 29);
            this.ChbDelivered.TabIndex = 7;
            this.ChbDelivered.Text = "*Teslim Edildi";
            this.ChbDelivered.UseVisualStyleBackColor = true;
            // 
            // ChbRented
            // 
            this.ChbRented.AutoSize = true;
            this.ChbRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbRented.Location = new System.Drawing.Point(448, 31);
            this.ChbRented.Name = "ChbRented";
            this.ChbRented.Size = new System.Drawing.Size(118, 29);
            this.ChbRented.TabIndex = 6;
            this.ChbRented.Text = "*Kiralandı";
            this.ChbRented.UseVisualStyleBackColor = true;
            // 
            // ChbDamaged
            // 
            this.ChbDamaged.AutoSize = true;
            this.ChbDamaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDamaged.Location = new System.Drawing.Point(315, 66);
            this.ChbDamaged.Name = "ChbDamaged";
            this.ChbDamaged.Size = new System.Drawing.Size(102, 29);
            this.ChbDamaged.TabIndex = 5;
            this.ChbDamaged.Text = "*Hasarlı";
            this.ChbDamaged.UseVisualStyleBackColor = true;
            // 
            // ChbAutoGear
            // 
            this.ChbAutoGear.AutoSize = true;
            this.ChbAutoGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbAutoGear.Location = new System.Drawing.Point(315, 31);
            this.ChbAutoGear.Name = "ChbAutoGear";
            this.ChbAutoGear.Size = new System.Drawing.Size(123, 29);
            this.ChbAutoGear.TabIndex = 4;
            this.ChbAutoGear.Text = "*Oto Vites";
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
            this.CmbSeat.Location = new System.Drawing.Point(448, 124);
            this.CmbSeat.Name = "CmbSeat";
            this.CmbSeat.Size = new System.Drawing.Size(55, 33);
            this.CmbSeat.TabIndex = 8;
            // 
            // LblSeat
            // 
            this.LblSeat.AutoSize = true;
            this.LblSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSeat.Location = new System.Drawing.Point(302, 127);
            this.LblSeat.Name = "LblSeat";
            this.LblSeat.Size = new System.Drawing.Size(149, 25);
            this.LblSeat.TabIndex = 23;
            this.LblSeat.Text = "*Koltuk Sayısı : ";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPrice.Location = new System.Drawing.Point(124, 29);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(151, 30);
            this.TxtPrice.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(123, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 30);
            this.textBox1.TabIndex = 3;
            // 
            // TxtKm
            // 
            this.TxtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKm.Location = new System.Drawing.Point(124, 124);
            this.TxtKm.Name = "TxtKm";
            this.TxtKm.Size = new System.Drawing.Size(151, 30);
            this.TxtKm.TabIndex = 2;
            // 
            // LblDeliveryDate
            // 
            this.LblDeliveryDate.AutoSize = true;
            this.LblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDeliveryDate.Location = new System.Drawing.Point(311, 345);
            this.LblDeliveryDate.Name = "LblDeliveryDate";
            this.LblDeliveryDate.Size = new System.Drawing.Size(140, 25);
            this.LblDeliveryDate.TabIndex = 16;
            this.LblDeliveryDate.Text = "Teslim Tarihi : ";
            this.LblDeliveryDate.Visible = false;
            // 
            // LblDeliveredDate
            // 
            this.LblDeliveredDate.AutoSize = true;
            this.LblDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDeliveredDate.Location = new System.Drawing.Point(256, 301);
            this.LblDeliveredDate.Name = "LblDeliveredDate";
            this.LblDeliveredDate.Size = new System.Drawing.Size(195, 25);
            this.LblDeliveredDate.TabIndex = 15;
            this.LblDeliveredDate.Text = "Teslim Edilen Tarih : ";
            this.LblDeliveredDate.Visible = false;
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
            this.LblRentDate.Location = new System.Drawing.Point(290, 256);
            this.LblRentDate.Name = "LblRentDate";
            this.LblRentDate.Size = new System.Drawing.Size(161, 25);
            this.LblRentDate.TabIndex = 13;
            this.LblRentDate.Text = "Kiralanan Tarih : ";
            this.LblRentDate.Visible = false;
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
            this.LblKm.Size = new System.Drawing.Size(66, 25);
            this.LblKm.TabIndex = 19;
            this.LblKm.Text = "*Km : ";
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
            this.TbpDelete.Controls.Add(this.LblDelete);
            this.TbpDelete.Controls.Add(this.comboBox1);
            this.TbpDelete.Location = new System.Drawing.Point(4, 25);
            this.TbpDelete.Name = "TbpDelete";
            this.TbpDelete.Padding = new System.Windows.Forms.Padding(3);
            this.TbpDelete.Size = new System.Drawing.Size(679, 430);
            this.TbpDelete.TabIndex = 1;
            this.TbpDelete.Text = "Çıkar";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Id",
            "Price",
            "Model",
            "Km",
            "Seat",
            "AutoGear",
            "Damaged",
            "Description",
            "Rented",
            "Renter",
            "RentDate",
            "Delivered",
            "DeliveredDate",
            "DeliveryDate"});
            this.comboBox1.Location = new System.Drawing.Point(302, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 37);
            this.comboBox1.TabIndex = 0;
            // 
            // LblDelete
            // 
            this.LblDelete.AutoSize = true;
            this.LblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDelete.Location = new System.Drawing.Point(123, 126);
            this.LblDelete.Name = "LblDelete";
            this.LblDelete.Size = new System.Drawing.Size(173, 29);
            this.LblDelete.TabIndex = 1;
            this.LblDelete.Text = "Silme Koşulu : ";
            // 
            // FrmEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 536);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TbcEditCar);
            this.Name = "FrmEditCar";
            this.Text = "Araç Ekle\\Çıkar";
            this.TbcEditCar.ResumeLayout(false);
            this.TbpAdd.ResumeLayout(false);
            this.TbpAdd.PerformLayout();
            this.TbpDelete.ResumeLayout(false);
            this.TbpDelete.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtKm;
        private System.Windows.Forms.Label LblDeliveryDate;
        private System.Windows.Forms.Label LblDeliveredDate;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.Label LblRentDate;
        private System.Windows.Forms.Label LblRenter;
        private System.Windows.Forms.Label LblKm;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.TabPage TbpDelete;
        private System.Windows.Forms.Label LblDelete;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}