namespace AracKiralama
{
    partial class FrmMain
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
            this.BtnCarList = new System.Windows.Forms.Button();
            this.LblTotalCar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblIdleCar = new System.Windows.Forms.Label();
            this.LblRentedCar = new System.Windows.Forms.Label();
            this.BtnIdleCarList = new System.Windows.Forms.Button();
            this.BtnRentedCarList = new System.Windows.Forms.Button();
            this.BtnEditCar = new System.Windows.Forms.Button();
            this.BtnRentCar = new System.Windows.Forms.Button();
            this.BtnRecallCar = new System.Windows.Forms.Button();
            this.BtnCustomerList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCarList
            // 
            this.BtnCarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCarList.Location = new System.Drawing.Point(17, 93);
            this.BtnCarList.Name = "BtnCarList";
            this.BtnCarList.Size = new System.Drawing.Size(133, 128);
            this.BtnCarList.TabIndex = 0;
            this.BtnCarList.Text = "Araba Listesi";
            this.BtnCarList.UseVisualStyleBackColor = true;
            this.BtnCarList.Click += new System.EventHandler(this.BtnCarList_Click);
            // 
            // LblTotalCar
            // 
            this.LblTotalCar.AutoSize = true;
            this.LblTotalCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalCar.Location = new System.Drawing.Point(12, 9);
            this.LblTotalCar.Name = "LblTotalCar";
            this.LblTotalCar.Size = new System.Drawing.Size(196, 29);
            this.LblTotalCar.TabIndex = 1;
            this.LblTotalCar.Text = "Toplam Araba : 0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(2, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1210, 10);
            this.label1.TabIndex = 2;
            // 
            // LblIdleCar
            // 
            this.LblIdleCar.AutoSize = true;
            this.LblIdleCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblIdleCar.Location = new System.Drawing.Point(518, 9);
            this.LblIdleCar.Name = "LblIdleCar";
            this.LblIdleCar.Size = new System.Drawing.Size(174, 29);
            this.LblIdleCar.TabIndex = 1;
            this.LblIdleCar.Text = "Boşta Araba : 0";
            // 
            // LblRentedCar
            // 
            this.LblRentedCar.AutoSize = true;
            this.LblRentedCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRentedCar.Location = new System.Drawing.Point(979, 9);
            this.LblRentedCar.Name = "LblRentedCar";
            this.LblRentedCar.Size = new System.Drawing.Size(214, 29);
            this.LblRentedCar.TabIndex = 1;
            this.LblRentedCar.Text = "Kiralanan Araba : 0";
            // 
            // BtnIdleCarList
            // 
            this.BtnIdleCarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIdleCarList.Location = new System.Drawing.Point(186, 93);
            this.BtnIdleCarList.Name = "BtnIdleCarList";
            this.BtnIdleCarList.Size = new System.Drawing.Size(133, 128);
            this.BtnIdleCarList.TabIndex = 1;
            this.BtnIdleCarList.Text = "Boştaki Araba Listesi";
            this.BtnIdleCarList.UseVisualStyleBackColor = true;
            this.BtnIdleCarList.Click += new System.EventHandler(this.BtnIdleCarList_Click);
            // 
            // BtnRentedCarList
            // 
            this.BtnRentedCarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRentedCarList.Location = new System.Drawing.Point(368, 93);
            this.BtnRentedCarList.Name = "BtnRentedCarList";
            this.BtnRentedCarList.Size = new System.Drawing.Size(133, 128);
            this.BtnRentedCarList.TabIndex = 2;
            this.BtnRentedCarList.Text = "Kiralanan Araba Listesi";
            this.BtnRentedCarList.UseVisualStyleBackColor = true;
            this.BtnRentedCarList.Click += new System.EventHandler(this.BtnRentedCarList_Click);
            // 
            // BtnEditCar
            // 
            this.BtnEditCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditCar.Location = new System.Drawing.Point(17, 288);
            this.BtnEditCar.Name = "BtnEditCar";
            this.BtnEditCar.Size = new System.Drawing.Size(133, 128);
            this.BtnEditCar.TabIndex = 4;
            this.BtnEditCar.Text = "Araba Ekle\\Çıkar";
            this.BtnEditCar.UseVisualStyleBackColor = true;
            this.BtnEditCar.Click += new System.EventHandler(this.BtnEditCar_Click);
            // 
            // BtnRentCar
            // 
            this.BtnRentCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRentCar.Location = new System.Drawing.Point(186, 288);
            this.BtnRentCar.Name = "BtnRentCar";
            this.BtnRentCar.Size = new System.Drawing.Size(133, 128);
            this.BtnRentCar.TabIndex = 5;
            this.BtnRentCar.Text = "Araba Kirala";
            this.BtnRentCar.UseVisualStyleBackColor = true;
            // 
            // BtnRecallCar
            // 
            this.BtnRecallCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecallCar.Location = new System.Drawing.Point(368, 288);
            this.BtnRecallCar.Name = "BtnRecallCar";
            this.BtnRecallCar.Size = new System.Drawing.Size(133, 128);
            this.BtnRecallCar.TabIndex = 6;
            this.BtnRecallCar.Text = "Arabayı Geri Çağır";
            this.BtnRecallCar.UseVisualStyleBackColor = true;
            // 
            // BtnCustomerList
            // 
            this.BtnCustomerList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomerList.Location = new System.Drawing.Point(541, 93);
            this.BtnCustomerList.Name = "BtnCustomerList";
            this.BtnCustomerList.Size = new System.Drawing.Size(133, 128);
            this.BtnCustomerList.TabIndex = 3;
            this.BtnCustomerList.Text = "Müşteri Listesi";
            this.BtnCustomerList.UseVisualStyleBackColor = true;
            this.BtnCustomerList.Click += new System.EventHandler(this.BtnCustomerList_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1212, 728);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblRentedCar);
            this.Controls.Add(this.LblIdleCar);
            this.Controls.Add(this.LblTotalCar);
            this.Controls.Add(this.BtnCustomerList);
            this.Controls.Add(this.BtnRentedCarList);
            this.Controls.Add(this.BtnIdleCarList);
            this.Controls.Add(this.BtnRecallCar);
            this.Controls.Add(this.BtnRentCar);
            this.Controls.Add(this.BtnEditCar);
            this.Controls.Add(this.BtnCarList);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCarList;
        private System.Windows.Forms.Label LblTotalCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblIdleCar;
        private System.Windows.Forms.Label LblRentedCar;
        private System.Windows.Forms.Button BtnIdleCarList;
        private System.Windows.Forms.Button BtnRentedCarList;
        private System.Windows.Forms.Button BtnEditCar;
        private System.Windows.Forms.Button BtnRentCar;
        private System.Windows.Forms.Button BtnRecallCar;
        private System.Windows.Forms.Button BtnCustomerList;
    }
}