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
            this.BtnAddCar = new System.Windows.Forms.Button();
            this.BtnRentCar = new System.Windows.Forms.Button();
            this.BtnCustomerList = new System.Windows.Forms.Button();
            this.BtnRenterCustomers = new System.Windows.Forms.Button();
            this.BtnEditCars = new System.Windows.Forms.Button();
            this.BtnEditCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCarList
            // 
            this.BtnCarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCarList.Location = new System.Drawing.Point(17, 94);
            this.BtnCarList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCarList.Name = "BtnCarList";
            this.BtnCarList.Size = new System.Drawing.Size(133, 128);
            this.BtnCarList.TabIndex = 0;
            this.BtnCarList.Text = "Arabalar";
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
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1211, 10);
            this.label1.TabIndex = 2;
            // 
            // LblIdleCar
            // 
            this.LblIdleCar.AutoSize = true;
            this.LblIdleCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblIdleCar.Location = new System.Drawing.Point(517, 9);
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
            this.BtnIdleCarList.Location = new System.Drawing.Point(187, 94);
            this.BtnIdleCarList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIdleCarList.Name = "BtnIdleCarList";
            this.BtnIdleCarList.Size = new System.Drawing.Size(133, 128);
            this.BtnIdleCarList.TabIndex = 1;
            this.BtnIdleCarList.Text = "Boştaki Arabalar";
            this.BtnIdleCarList.UseVisualStyleBackColor = true;
            this.BtnIdleCarList.Click += new System.EventHandler(this.BtnIdleCarList_Click);
            // 
            // BtnRentedCarList
            // 
            this.BtnRentedCarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRentedCarList.Location = new System.Drawing.Point(368, 94);
            this.BtnRentedCarList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRentedCarList.Name = "BtnRentedCarList";
            this.BtnRentedCarList.Size = new System.Drawing.Size(133, 128);
            this.BtnRentedCarList.TabIndex = 2;
            this.BtnRentedCarList.Text = "Kiralanan Arabalar";
            this.BtnRentedCarList.UseVisualStyleBackColor = true;
            this.BtnRentedCarList.Click += new System.EventHandler(this.BtnRentedCarList_Click);
            // 
            // BtnAddCar
            // 
            this.BtnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddCar.Location = new System.Drawing.Point(17, 288);
            this.BtnAddCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddCar.Name = "BtnAddCar";
            this.BtnAddCar.Size = new System.Drawing.Size(133, 128);
            this.BtnAddCar.TabIndex = 4;
            this.BtnAddCar.Text = "Araba Ekle\\Çıkar";
            this.BtnAddCar.UseVisualStyleBackColor = true;
            this.BtnAddCar.Click += new System.EventHandler(this.BtnAddCar_Click);
            // 
            // BtnRentCar
            // 
            this.BtnRentCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRentCar.Location = new System.Drawing.Point(187, 288);
            this.BtnRentCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRentCar.Name = "BtnRentCar";
            this.BtnRentCar.Size = new System.Drawing.Size(133, 128);
            this.BtnRentCar.TabIndex = 5;
            this.BtnRentCar.Text = "Araba Kirala\\Çağır";
            this.BtnRentCar.UseVisualStyleBackColor = true;
            this.BtnRentCar.Click += new System.EventHandler(this.BtnRentCar_Click);
            // 
            // BtnCustomerList
            // 
            this.BtnCustomerList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomerList.Location = new System.Drawing.Point(541, 94);
            this.BtnCustomerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCustomerList.Name = "BtnCustomerList";
            this.BtnCustomerList.Size = new System.Drawing.Size(133, 128);
            this.BtnCustomerList.TabIndex = 3;
            this.BtnCustomerList.Text = "Müşteriler";
            this.BtnCustomerList.UseVisualStyleBackColor = true;
            this.BtnCustomerList.Click += new System.EventHandler(this.BtnCustomerList_Click);
            // 
            // BtnRenterCustomers
            // 
            this.BtnRenterCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRenterCustomers.Location = new System.Drawing.Point(712, 94);
            this.BtnRenterCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRenterCustomers.Name = "BtnRenterCustomers";
            this.BtnRenterCustomers.Size = new System.Drawing.Size(133, 128);
            this.BtnRenterCustomers.TabIndex = 3;
            this.BtnRenterCustomers.Text = "Kiracı Müşteriler";
            this.BtnRenterCustomers.UseVisualStyleBackColor = true;
            this.BtnRenterCustomers.Click += new System.EventHandler(this.BtnRenterCustomerList_Click);
            // 
            // BtnEditCars
            // 
            this.BtnEditCars.Location = new System.Drawing.Point(368, 288);
            this.BtnEditCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditCars.Name = "BtnEditCars";
            this.BtnEditCars.Size = new System.Drawing.Size(133, 128);
            this.BtnEditCars.TabIndex = 6;
            this.BtnEditCars.Text = "Arabaları Düzenle";
            this.BtnEditCars.UseVisualStyleBackColor = true;
            this.BtnEditCars.Click += new System.EventHandler(this.BtnEditCars_Click);
            // 
            // BtnEditCustomers
            // 
            this.BtnEditCustomers.Location = new System.Drawing.Point(541, 288);
            this.BtnEditCustomers.Name = "BtnEditCustomers";
            this.BtnEditCustomers.Size = new System.Drawing.Size(133, 128);
            this.BtnEditCustomers.TabIndex = 7;
            this.BtnEditCustomers.Text = "Müşterileri Düzenle";
            this.BtnEditCustomers.UseVisualStyleBackColor = true;
            this.BtnEditCustomers.Click += new System.EventHandler(this.BtnEditCustomers_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1212, 729);
            this.Controls.Add(this.BtnEditCustomers);
            this.Controls.Add(this.BtnEditCars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblRentedCar);
            this.Controls.Add(this.LblIdleCar);
            this.Controls.Add(this.LblTotalCar);
            this.Controls.Add(this.BtnRenterCustomers);
            this.Controls.Add(this.BtnCustomerList);
            this.Controls.Add(this.BtnRentedCarList);
            this.Controls.Add(this.BtnIdleCarList);
            this.Controls.Add(this.BtnRentCar);
            this.Controls.Add(this.BtnAddCar);
            this.Controls.Add(this.BtnCarList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIdleCarList;
        private System.Windows.Forms.Button BtnRentedCarList;
        private System.Windows.Forms.Button BtnAddCar;
        private System.Windows.Forms.Button BtnRentCar;
        private System.Windows.Forms.Button BtnCustomerList;
        private System.Windows.Forms.Button BtnRenterCustomers;
        private System.Windows.Forms.Button BtnEditCars;
        public System.Windows.Forms.Label LblTotalCar;
        public System.Windows.Forms.Label LblIdleCar;
        public System.Windows.Forms.Label LblRentedCar;
        private System.Windows.Forms.Button BtnEditCustomers;
    }
}