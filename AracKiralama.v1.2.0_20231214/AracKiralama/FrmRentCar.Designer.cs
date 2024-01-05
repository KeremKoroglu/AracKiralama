namespace AracKiralama
{
    partial class FrmRentCar
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
            this.BtnRent = new System.Windows.Forms.Button();
            this.TbcRentCar = new System.Windows.Forms.TabControl();
            this.TbpRent = new System.Windows.Forms.TabPage();
            this.DtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.DtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.RtbDescription = new System.Windows.Forms.RichTextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblDeliveryDate = new System.Windows.Forms.Label();
            this.LblRentDate = new System.Windows.Forms.Label();
            this.LblRenter = new System.Windows.Forms.Label();
            this.LblModel = new System.Windows.Forms.Label();
            this.TbpRecall = new System.Windows.Forms.TabPage();
            this.LblCondition = new System.Windows.Forms.Label();
            this.CmbRecallModel = new System.Windows.Forms.ComboBox();
            this.CmbModel = new System.Windows.Forms.ComboBox();
            this.CmbRenter = new System.Windows.Forms.ComboBox();
            this.LblRecallRenter = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.LblKm = new System.Windows.Forms.Label();
            this.TxtKm = new System.Windows.Forms.TextBox();
            this.TbcRentCar.SuspendLayout();
            this.TbpRent.SuspendLayout();
            this.TbpRecall.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRent
            // 
            this.BtnRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRent.Location = new System.Drawing.Point(13, 476);
            this.BtnRent.Name = "BtnRent";
            this.BtnRent.Size = new System.Drawing.Size(100, 50);
            this.BtnRent.TabIndex = 15;
            this.BtnRent.Text = "Kirala";
            this.BtnRent.UseVisualStyleBackColor = true;
            // 
            // TbcRentCar
            // 
            this.TbcRentCar.Controls.Add(this.TbpRent);
            this.TbcRentCar.Controls.Add(this.TbpRecall);
            this.TbcRentCar.Location = new System.Drawing.Point(13, 11);
            this.TbcRentCar.Name = "TbcRentCar";
            this.TbcRentCar.SelectedIndex = 0;
            this.TbcRentCar.Size = new System.Drawing.Size(687, 459);
            this.TbcRentCar.TabIndex = 14;
            // 
            // TbpRent
            // 
            this.TbpRent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbpRent.Controls.Add(this.CmbRenter);
            this.TbpRent.Controls.Add(this.CmbModel);
            this.TbpRent.Controls.Add(this.DtpDeliveryDate);
            this.TbpRent.Controls.Add(this.DtpRentDate);
            this.TbpRent.Controls.Add(this.RtbDescription);
            this.TbpRent.Controls.Add(this.LblDescription);
            this.TbpRent.Controls.Add(this.LblDeliveryDate);
            this.TbpRent.Controls.Add(this.LblRentDate);
            this.TbpRent.Controls.Add(this.LblRenter);
            this.TbpRent.Controls.Add(this.LblModel);
            this.TbpRent.Location = new System.Drawing.Point(4, 25);
            this.TbpRent.Name = "TbpRent";
            this.TbpRent.Padding = new System.Windows.Forms.Padding(3);
            this.TbpRent.Size = new System.Drawing.Size(679, 430);
            this.TbpRent.TabIndex = 0;
            this.TbpRent.Text = "Kirala";
            // 
            // DtpDeliveryDate
            // 
            this.DtpDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDeliveryDate.Location = new System.Drawing.Point(460, 259);
            this.DtpDeliveryDate.Name = "DtpDeliveryDate";
            this.DtpDeliveryDate.Size = new System.Drawing.Size(208, 34);
            this.DtpDeliveryDate.TabIndex = 12;
            // 
            // DtpRentDate
            // 
            this.DtpRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpRentDate.Location = new System.Drawing.Point(460, 312);
            this.DtpRentDate.Name = "DtpRentDate";
            this.DtpRentDate.Size = new System.Drawing.Size(208, 34);
            this.DtpRentDate.TabIndex = 10;
            // 
            // RtbDescription
            // 
            this.RtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RtbDescription.Location = new System.Drawing.Point(13, 178);
            this.RtbDescription.Name = "RtbDescription";
            this.RtbDescription.Size = new System.Drawing.Size(230, 237);
            this.RtbDescription.TabIndex = 9;
            this.RtbDescription.Text = "";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDescription.Location = new System.Drawing.Point(8, 146);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(128, 29);
            this.LblDescription.TabIndex = 22;
            this.LblDescription.Text = "Açıklama : ";
            // 
            // LblDeliveryDate
            // 
            this.LblDeliveryDate.AutoSize = true;
            this.LblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDeliveryDate.Location = new System.Drawing.Point(260, 259);
            this.LblDeliveryDate.Name = "LblDeliveryDate";
            this.LblDeliveryDate.Size = new System.Drawing.Size(173, 29);
            this.LblDeliveryDate.TabIndex = 16;
            this.LblDeliveryDate.Text = "Teslim Tarihi : ";
            // 
            // LblRentDate
            // 
            this.LblRentDate.AutoSize = true;
            this.LblRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRentDate.Location = new System.Drawing.Point(260, 312);
            this.LblRentDate.Name = "LblRentDate";
            this.LblRentDate.Size = new System.Drawing.Size(194, 29);
            this.LblRentDate.TabIndex = 13;
            this.LblRentDate.Text = "Kiralanan Tarih : ";
            // 
            // LblRenter
            // 
            this.LblRenter.AutoSize = true;
            this.LblRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRenter.Location = new System.Drawing.Point(162, 88);
            this.LblRenter.Name = "LblRenter";
            this.LblRenter.Size = new System.Drawing.Size(130, 29);
            this.LblRenter.TabIndex = 12;
            this.LblRenter.Text = "Kiralayan : ";
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblModel.Location = new System.Drawing.Point(191, 32);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(99, 29);
            this.LblModel.TabIndex = 11;
            this.LblModel.Text = "Model : ";
            // 
            // TbpRecall
            // 
            this.TbpRecall.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbpRecall.Controls.Add(this.TxtKm);
            this.TbpRecall.Controls.Add(this.LblKm);
            this.TbpRecall.Controls.Add(this.dateTimePicker1);
            this.TbpRecall.Controls.Add(this.label1);
            this.TbpRecall.Controls.Add(this.LblRecallRenter);
            this.TbpRecall.Controls.Add(this.comboBox1);
            this.TbpRecall.Controls.Add(this.LblCondition);
            this.TbpRecall.Controls.Add(this.CmbRecallModel);
            this.TbpRecall.Location = new System.Drawing.Point(4, 25);
            this.TbpRecall.Name = "TbpRecall";
            this.TbpRecall.Padding = new System.Windows.Forms.Padding(3);
            this.TbpRecall.Size = new System.Drawing.Size(679, 430);
            this.TbpRecall.TabIndex = 1;
            this.TbpRecall.Text = "Çıkar";
            // 
            // LblCondition
            // 
            this.LblCondition.AutoSize = true;
            this.LblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCondition.Location = new System.Drawing.Point(162, 124);
            this.LblCondition.Name = "LblCondition";
            this.LblCondition.Size = new System.Drawing.Size(99, 29);
            this.LblCondition.TabIndex = 1;
            this.LblCondition.Text = "Model : ";
            // 
            // CmbRecallModel
            // 
            this.CmbRecallModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRecallModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbRecallModel.FormattingEnabled = true;
            this.CmbRecallModel.Items.AddRange(new object[] {
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
            this.CmbRecallModel.Location = new System.Drawing.Point(266, 121);
            this.CmbRecallModel.Name = "CmbRecallModel";
            this.CmbRecallModel.Size = new System.Drawing.Size(209, 37);
            this.CmbRecallModel.TabIndex = 0;
            // 
            // CmbModel
            // 
            this.CmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbModel.FormattingEnabled = true;
            this.CmbModel.Items.AddRange(new object[] {
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
            this.CmbModel.Location = new System.Drawing.Point(296, 29);
            this.CmbModel.Name = "CmbModel";
            this.CmbModel.Size = new System.Drawing.Size(235, 37);
            this.CmbModel.TabIndex = 23;
            // 
            // CmbRenter
            // 
            this.CmbRenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbRenter.FormattingEnabled = true;
            this.CmbRenter.Items.AddRange(new object[] {
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
            this.CmbRenter.Location = new System.Drawing.Point(296, 85);
            this.CmbRenter.Name = "CmbRenter";
            this.CmbRenter.Size = new System.Drawing.Size(235, 37);
            this.CmbRenter.TabIndex = 25;
            // 
            // LblRecallRenter
            // 
            this.LblRecallRenter.AutoSize = true;
            this.LblRecallRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRecallRenter.Location = new System.Drawing.Point(130, 179);
            this.LblRecallRenter.Name = "LblRecallRenter";
            this.LblRecallRenter.Size = new System.Drawing.Size(130, 29);
            this.LblRecallRenter.TabIndex = 3;
            this.LblRecallRenter.Text = "Kiralayan : ";
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
            this.comboBox1.Location = new System.Drawing.Point(266, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 37);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(266, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 34);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Teslim Tarihi : ";
            // 
            // LblKm
            // 
            this.LblKm.AutoSize = true;
            this.LblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKm.Location = new System.Drawing.Point(131, 282);
            this.LblKm.Name = "LblKm";
            this.LblKm.Size = new System.Drawing.Size(126, 29);
            this.LblKm.TabIndex = 19;
            this.LblKm.Text = "Km Artışı : ";
            // 
            // TxtKm
            // 
            this.TxtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKm.Location = new System.Drawing.Point(263, 282);
            this.TxtKm.Name = "TxtKm";
            this.TxtKm.Size = new System.Drawing.Size(212, 34);
            this.TxtKm.TabIndex = 20;
            // 
            // FrmRentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 536);
            this.Controls.Add(this.BtnRent);
            this.Controls.Add(this.TbcRentCar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRentCar";
            this.Text = "Araba Kirala";
            this.Load += new System.EventHandler(this.FrmRentCar_Load);
            this.TbcRentCar.ResumeLayout(false);
            this.TbpRent.ResumeLayout(false);
            this.TbpRent.PerformLayout();
            this.TbpRecall.ResumeLayout(false);
            this.TbpRecall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRent;
        private System.Windows.Forms.TabControl TbcRentCar;
        private System.Windows.Forms.TabPage TbpRent;
        private System.Windows.Forms.DateTimePicker DtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker DtpRentDate;
        private System.Windows.Forms.RichTextBox RtbDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblDeliveryDate;
        private System.Windows.Forms.Label LblRentDate;
        private System.Windows.Forms.Label LblRenter;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.TabPage TbpRecall;
        private System.Windows.Forms.Label LblCondition;
        private System.Windows.Forms.ComboBox CmbRecallModel;
        private System.Windows.Forms.ComboBox CmbModel;
        private System.Windows.Forms.ComboBox CmbRenter;
        private System.Windows.Forms.Label LblRecallRenter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKm;
        private System.Windows.Forms.Label LblKm;
    }
}