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
            this.BtnSave = new System.Windows.Forms.Button();
            this.TbcRentCar = new System.Windows.Forms.TabControl();
            this.TbpRent = new System.Windows.Forms.TabPage();
            this.CmbRenter = new System.Windows.Forms.ComboBox();
            this.CmbModel = new System.Windows.Forms.ComboBox();
            this.DtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.DtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.RtbDescription = new System.Windows.Forms.RichTextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblDeliveryDate = new System.Windows.Forms.Label();
            this.LblRentDate = new System.Windows.Forms.Label();
            this.LblRenter = new System.Windows.Forms.Label();
            this.LblModel = new System.Windows.Forms.Label();
            this.TbpRecall = new System.Windows.Forms.TabPage();
            this.ChbDamaged = new System.Windows.Forms.CheckBox();
            this.LblRecallDescription = new System.Windows.Forms.Label();
            this.RtbRecallDescription = new System.Windows.Forms.RichTextBox();
            this.TxtKm = new System.Windows.Forms.TextBox();
            this.LblKm = new System.Windows.Forms.Label();
            this.DtpRecallDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.LblRecallDeliveryDate = new System.Windows.Forms.Label();
            this.DtpDeliveredDate = new System.Windows.Forms.DateTimePicker();
            this.LblDeliveredDate = new System.Windows.Forms.Label();
            this.LblRecallRenter = new System.Windows.Forms.Label();
            this.CmbRecallRenter = new System.Windows.Forms.ComboBox();
            this.LblCondition = new System.Windows.Forms.Label();
            this.CmbRecallModel = new System.Windows.Forms.ComboBox();
            this.TbcRentCar.SuspendLayout();
            this.TbpRent.SuspendLayout();
            this.TbpRecall.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Location = new System.Drawing.Point(13, 476);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 50);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Kirala";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.TbcRentCar.Click += new System.EventHandler(this.TbcRentCar_Click);
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
            // CmbRenter
            // 
            this.CmbRenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbRenter.FormattingEnabled = true;
            this.CmbRenter.Location = new System.Drawing.Point(270, 81);
            this.CmbRenter.Name = "CmbRenter";
            this.CmbRenter.Size = new System.Drawing.Size(257, 37);
            this.CmbRenter.TabIndex = 25;
            // 
            // CmbModel
            // 
            this.CmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbModel.FormattingEnabled = true;
            this.CmbModel.Location = new System.Drawing.Point(270, 25);
            this.CmbModel.Name = "CmbModel";
            this.CmbModel.Size = new System.Drawing.Size(257, 37);
            this.CmbModel.TabIndex = 23;
            // 
            // DtpDeliveryDate
            // 
            this.DtpDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDeliveryDate.Location = new System.Drawing.Point(449, 297);
            this.DtpDeliveryDate.Name = "DtpDeliveryDate";
            this.DtpDeliveryDate.Size = new System.Drawing.Size(210, 34);
            this.DtpDeliveryDate.TabIndex = 12;
            this.DtpDeliveryDate.Value = new System.DateTime(2023, 12, 15, 8, 47, 33, 0);
            // 
            // DtpRentDate
            // 
            this.DtpRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpRentDate.Location = new System.Drawing.Point(449, 244);
            this.DtpRentDate.Name = "DtpRentDate";
            this.DtpRentDate.Size = new System.Drawing.Size(210, 34);
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
            this.RtbDescription.TextChanged += new System.EventHandler(this.RtbDescription_TextChanged);
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
            this.LblDeliveryDate.Location = new System.Drawing.Point(270, 297);
            this.LblDeliveryDate.Name = "LblDeliveryDate";
            this.LblDeliveryDate.Size = new System.Drawing.Size(173, 29);
            this.LblDeliveryDate.TabIndex = 16;
            this.LblDeliveryDate.Text = "Teslim Tarihi : ";
            // 
            // LblRentDate
            // 
            this.LblRentDate.AutoSize = true;
            this.LblRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRentDate.Location = new System.Drawing.Point(249, 244);
            this.LblRentDate.Name = "LblRentDate";
            this.LblRentDate.Size = new System.Drawing.Size(194, 29);
            this.LblRentDate.TabIndex = 13;
            this.LblRentDate.Text = "Kiralanan Tarih : ";
            // 
            // LblRenter
            // 
            this.LblRenter.AutoSize = true;
            this.LblRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRenter.Location = new System.Drawing.Point(136, 84);
            this.LblRenter.Name = "LblRenter";
            this.LblRenter.Size = new System.Drawing.Size(130, 29);
            this.LblRenter.TabIndex = 12;
            this.LblRenter.Text = "Kiralayan : ";
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblModel.Location = new System.Drawing.Point(165, 28);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(99, 29);
            this.LblModel.TabIndex = 11;
            this.LblModel.Text = "Model : ";
            // 
            // TbpRecall
            // 
            this.TbpRecall.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbpRecall.Controls.Add(this.ChbDamaged);
            this.TbpRecall.Controls.Add(this.LblRecallDescription);
            this.TbpRecall.Controls.Add(this.RtbRecallDescription);
            this.TbpRecall.Controls.Add(this.TxtKm);
            this.TbpRecall.Controls.Add(this.LblKm);
            this.TbpRecall.Controls.Add(this.DtpRecallDeliveryDate);
            this.TbpRecall.Controls.Add(this.LblRecallDeliveryDate);
            this.TbpRecall.Controls.Add(this.DtpDeliveredDate);
            this.TbpRecall.Controls.Add(this.LblDeliveredDate);
            this.TbpRecall.Controls.Add(this.LblRecallRenter);
            this.TbpRecall.Controls.Add(this.CmbRecallRenter);
            this.TbpRecall.Controls.Add(this.LblCondition);
            this.TbpRecall.Controls.Add(this.CmbRecallModel);
            this.TbpRecall.Location = new System.Drawing.Point(4, 25);
            this.TbpRecall.Name = "TbpRecall";
            this.TbpRecall.Padding = new System.Windows.Forms.Padding(3);
            this.TbpRecall.Size = new System.Drawing.Size(679, 430);
            this.TbpRecall.TabIndex = 1;
            this.TbpRecall.Text = "Çağır";
            // 
            // ChbDamaged
            // 
            this.ChbDamaged.AutoSize = true;
            this.ChbDamaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDamaged.Location = new System.Drawing.Point(256, 318);
            this.ChbDamaged.Name = "ChbDamaged";
            this.ChbDamaged.Size = new System.Drawing.Size(94, 29);
            this.ChbDamaged.TabIndex = 23;
            this.ChbDamaged.Text = "Hasarlı";
            this.ChbDamaged.UseVisualStyleBackColor = true;
            // 
            // LblRecallDescription
            // 
            this.LblRecallDescription.AutoSize = true;
            this.LblRecallDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRecallDescription.Location = new System.Drawing.Point(427, 63);
            this.LblRecallDescription.Name = "LblRecallDescription";
            this.LblRecallDescription.Size = new System.Drawing.Size(108, 25);
            this.LblRecallDescription.TabIndex = 22;
            this.LblRecallDescription.Text = "Açıklama : ";
            // 
            // RtbRecallDescription
            // 
            this.RtbRecallDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RtbRecallDescription.Location = new System.Drawing.Point(432, 91);
            this.RtbRecallDescription.Name = "RtbRecallDescription";
            this.RtbRecallDescription.Size = new System.Drawing.Size(231, 221);
            this.RtbRecallDescription.TabIndex = 21;
            this.RtbRecallDescription.Text = "";
            this.RtbRecallDescription.TextChanged += new System.EventHandler(this.RtbRecallDescription_TextChanged);
            // 
            // TxtKm
            // 
            this.TxtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKm.Location = new System.Drawing.Point(204, 190);
            this.TxtKm.Name = "TxtKm";
            this.TxtKm.Size = new System.Drawing.Size(212, 30);
            this.TxtKm.TabIndex = 20;
            this.TxtKm.Text = "0";
            this.TxtKm.TextChanged += new System.EventHandler(this.TxtKm_TextChanged);
            // 
            // LblKm
            // 
            this.LblKm.AutoSize = true;
            this.LblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKm.Location = new System.Drawing.Point(73, 193);
            this.LblKm.Name = "LblKm";
            this.LblKm.Size = new System.Drawing.Size(125, 25);
            this.LblKm.TabIndex = 19;
            this.LblKm.Text = "Güncel Km : ";
            // 
            // DtpRecallDeliveryDate
            // 
            this.DtpRecallDeliveryDate.Enabled = false;
            this.DtpRecallDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpRecallDeliveryDate.Location = new System.Drawing.Point(204, 282);
            this.DtpRecallDeliveryDate.Name = "DtpRecallDeliveryDate";
            this.DtpRecallDeliveryDate.Size = new System.Drawing.Size(212, 30);
            this.DtpRecallDeliveryDate.TabIndex = 17;
            // 
            // LblRecallDeliveryDate
            // 
            this.LblRecallDeliveryDate.AutoSize = true;
            this.LblRecallDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRecallDeliveryDate.Location = new System.Drawing.Point(58, 287);
            this.LblRecallDeliveryDate.Name = "LblRecallDeliveryDate";
            this.LblRecallDeliveryDate.Size = new System.Drawing.Size(140, 25);
            this.LblRecallDeliveryDate.TabIndex = 18;
            this.LblRecallDeliveryDate.Text = "Teslim Tarihi : ";
            // 
            // DtpDeliveredDate
            // 
            this.DtpDeliveredDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDeliveredDate.Location = new System.Drawing.Point(204, 236);
            this.DtpDeliveredDate.Name = "DtpDeliveredDate";
            this.DtpDeliveredDate.Size = new System.Drawing.Size(212, 30);
            this.DtpDeliveredDate.TabIndex = 17;
            // 
            // LblDeliveredDate
            // 
            this.LblDeliveredDate.AutoSize = true;
            this.LblDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDeliveredDate.Location = new System.Drawing.Point(-1, 236);
            this.LblDeliveredDate.Name = "LblDeliveredDate";
            this.LblDeliveredDate.Size = new System.Drawing.Size(199, 25);
            this.LblDeliveredDate.TabIndex = 18;
            this.LblDeliveredDate.Text = "Teslim Edilen Tarihi : ";
            // 
            // LblRecallRenter
            // 
            this.LblRecallRenter.AutoSize = true;
            this.LblRecallRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRecallRenter.Location = new System.Drawing.Point(88, 144);
            this.LblRecallRenter.Name = "LblRecallRenter";
            this.LblRecallRenter.Size = new System.Drawing.Size(110, 25);
            this.LblRecallRenter.TabIndex = 3;
            this.LblRecallRenter.Text = "Kiralayan : ";
            // 
            // CmbRecallRenter
            // 
            this.CmbRecallRenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRecallRenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbRecallRenter.FormattingEnabled = true;
            this.CmbRecallRenter.Location = new System.Drawing.Point(204, 141);
            this.CmbRecallRenter.Name = "CmbRecallRenter";
            this.CmbRecallRenter.Size = new System.Drawing.Size(212, 33);
            this.CmbRecallRenter.TabIndex = 2;
            this.CmbRecallRenter.SelectedIndexChanged += new System.EventHandler(this.CmbRecallRenter_SelectedIndexChanged);
            // 
            // LblCondition
            // 
            this.LblCondition.AutoSize = true;
            this.LblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCondition.Location = new System.Drawing.Point(116, 94);
            this.LblCondition.Name = "LblCondition";
            this.LblCondition.Size = new System.Drawing.Size(82, 25);
            this.LblCondition.TabIndex = 1;
            this.LblCondition.Text = "Model : ";
            // 
            // CmbRecallModel
            // 
            this.CmbRecallModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRecallModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbRecallModel.FormattingEnabled = true;
            this.CmbRecallModel.Location = new System.Drawing.Point(204, 91);
            this.CmbRecallModel.Name = "CmbRecallModel";
            this.CmbRecallModel.Size = new System.Drawing.Size(212, 33);
            this.CmbRecallModel.TabIndex = 0;
            this.CmbRecallModel.SelectedIndexChanged += new System.EventHandler(this.CmbRecallModel_SelectedIndexChanged);
            // 
            // FrmRentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 536);
            this.Controls.Add(this.BtnSave);
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

        private System.Windows.Forms.Button BtnSave;
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
        private System.Windows.Forms.ComboBox CmbRecallRenter;
        private System.Windows.Forms.DateTimePicker DtpDeliveredDate;
        private System.Windows.Forms.Label LblDeliveredDate;
        private System.Windows.Forms.TextBox TxtKm;
        private System.Windows.Forms.Label LblKm;
        private System.Windows.Forms.RichTextBox RtbRecallDescription;
        private System.Windows.Forms.Label LblRecallDescription;
        private System.Windows.Forms.CheckBox ChbDamaged;
        private System.Windows.Forms.DateTimePicker DtpRecallDeliveryDate;
        private System.Windows.Forms.Label LblRecallDeliveryDate;
    }
}