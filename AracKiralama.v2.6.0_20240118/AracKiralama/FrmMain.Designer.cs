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
            this.BtnPaySystem = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCarList
            // 
            this.BtnCarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCarList.Location = new System.Drawing.Point(185, 195);
            this.BtnCarList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCarList.Name = "BtnCarList";
            this.BtnCarList.Size = new System.Drawing.Size(133, 128);
            this.BtnCarList.TabIndex = 0;
            this.BtnCarList.Text = "Arabalar";
            this.BtnCarList.UseVisualStyleBackColor = true;
            this.BtnCarList.Click += new System.EventHandler(this.BtnCarList_Click);
            this.BtnCarList.MouseEnter += new System.EventHandler(this.BtnCarList_MouseEnter);
            this.BtnCarList.MouseLeave += new System.EventHandler(this.BtnCarList_MouseLeave);
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
            this.BtnIdleCarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIdleCarList.Location = new System.Drawing.Point(355, 195);
            this.BtnIdleCarList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIdleCarList.Name = "BtnIdleCarList";
            this.BtnIdleCarList.Size = new System.Drawing.Size(133, 128);
            this.BtnIdleCarList.TabIndex = 1;
            this.BtnIdleCarList.Text = "Boştaki Arabalar";
            this.BtnIdleCarList.UseVisualStyleBackColor = true;
            this.BtnIdleCarList.Click += new System.EventHandler(this.BtnIdleCarList_Click);
            this.BtnIdleCarList.MouseEnter += new System.EventHandler(this.BtnIdleCarList_MouseEnter);
            this.BtnIdleCarList.MouseLeave += new System.EventHandler(this.BtnIdleCarList_MouseLeave);
            // 
            // BtnRentedCarList
            // 
            this.BtnRentedCarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRentedCarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRentedCarList.Location = new System.Drawing.Point(536, 195);
            this.BtnRentedCarList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRentedCarList.Name = "BtnRentedCarList";
            this.BtnRentedCarList.Size = new System.Drawing.Size(133, 128);
            this.BtnRentedCarList.TabIndex = 2;
            this.BtnRentedCarList.Text = "Kiralanan Arabalar";
            this.BtnRentedCarList.UseVisualStyleBackColor = true;
            this.BtnRentedCarList.Click += new System.EventHandler(this.BtnRentedCarList_Click);
            this.BtnRentedCarList.MouseEnter += new System.EventHandler(this.BtnRentedCarList_MouseEnter);
            this.BtnRentedCarList.MouseLeave += new System.EventHandler(this.BtnRentedCarList_MouseLeave);
            // 
            // BtnAddCar
            // 
            this.BtnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddCar.Location = new System.Drawing.Point(185, 389);
            this.BtnAddCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddCar.Name = "BtnAddCar";
            this.BtnAddCar.Size = new System.Drawing.Size(133, 128);
            this.BtnAddCar.TabIndex = 5;
            this.BtnAddCar.Text = "Araba Ekle\\Çıkar";
            this.BtnAddCar.UseVisualStyleBackColor = true;
            this.BtnAddCar.Click += new System.EventHandler(this.BtnAddCar_Click);
            this.BtnAddCar.MouseEnter += new System.EventHandler(this.BtnAddCar_MouseEnter);
            this.BtnAddCar.MouseLeave += new System.EventHandler(this.BtnAddCar_MouseLeave);
            // 
            // BtnRentCar
            // 
            this.BtnRentCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRentCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRentCar.Location = new System.Drawing.Point(355, 389);
            this.BtnRentCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRentCar.Name = "BtnRentCar";
            this.BtnRentCar.Size = new System.Drawing.Size(133, 128);
            this.BtnRentCar.TabIndex = 6;
            this.BtnRentCar.Text = "Araba Kirala\\Çağır";
            this.BtnRentCar.UseVisualStyleBackColor = true;
            this.BtnRentCar.Click += new System.EventHandler(this.BtnRentCar_Click);
            this.BtnRentCar.MouseEnter += new System.EventHandler(this.BtnRentCar_MouseEnter);
            this.BtnRentCar.MouseLeave += new System.EventHandler(this.BtnRentCar_MouseLeave);
            // 
            // BtnCustomerList
            // 
            this.BtnCustomerList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCustomerList.Location = new System.Drawing.Point(709, 195);
            this.BtnCustomerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCustomerList.Name = "BtnCustomerList";
            this.BtnCustomerList.Size = new System.Drawing.Size(133, 128);
            this.BtnCustomerList.TabIndex = 3;
            this.BtnCustomerList.Text = "Müşteriler";
            this.BtnCustomerList.UseVisualStyleBackColor = true;
            this.BtnCustomerList.Click += new System.EventHandler(this.BtnCustomerList_Click);
            this.BtnCustomerList.MouseEnter += new System.EventHandler(this.BtnCustomerList_MouseEnter);
            this.BtnCustomerList.MouseLeave += new System.EventHandler(this.BtnCustomerList_MouseLeave);
            // 
            // BtnRenterCustomers
            // 
            this.BtnRenterCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRenterCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRenterCustomers.Location = new System.Drawing.Point(880, 195);
            this.BtnRenterCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRenterCustomers.Name = "BtnRenterCustomers";
            this.BtnRenterCustomers.Size = new System.Drawing.Size(133, 128);
            this.BtnRenterCustomers.TabIndex = 4;
            this.BtnRenterCustomers.Text = "Kiracı Müşteriler";
            this.BtnRenterCustomers.UseVisualStyleBackColor = true;
            this.BtnRenterCustomers.Click += new System.EventHandler(this.BtnRenterCustomerList_Click);
            this.BtnRenterCustomers.MouseEnter += new System.EventHandler(this.BtnRenterCustomers_MouseEnter);
            this.BtnRenterCustomers.MouseLeave += new System.EventHandler(this.BtnRenterCustomers_MouseLeave);
            // 
            // BtnEditCars
            // 
            this.BtnEditCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEditCars.Location = new System.Drawing.Point(536, 389);
            this.BtnEditCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditCars.Name = "BtnEditCars";
            this.BtnEditCars.Size = new System.Drawing.Size(133, 128);
            this.BtnEditCars.TabIndex = 7;
            this.BtnEditCars.Text = "Arabaları Düzenle";
            this.BtnEditCars.UseVisualStyleBackColor = true;
            this.BtnEditCars.Click += new System.EventHandler(this.BtnEditCars_Click);
            this.BtnEditCars.MouseEnter += new System.EventHandler(this.BtnEditCars_MouseEnter);
            this.BtnEditCars.MouseLeave += new System.EventHandler(this.BtnEditCars_MouseLeave);
            // 
            // BtnEditCustomers
            // 
            this.BtnEditCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEditCustomers.Location = new System.Drawing.Point(709, 389);
            this.BtnEditCustomers.Name = "BtnEditCustomers";
            this.BtnEditCustomers.Size = new System.Drawing.Size(133, 128);
            this.BtnEditCustomers.TabIndex = 8;
            this.BtnEditCustomers.Text = "Müşterileri Düzenle";
            this.BtnEditCustomers.UseVisualStyleBackColor = true;
            this.BtnEditCustomers.Click += new System.EventHandler(this.BtnEditCustomers_Click);
            this.BtnEditCustomers.MouseEnter += new System.EventHandler(this.BtnEditCustomers_MouseEnter);
            this.BtnEditCustomers.MouseLeave += new System.EventHandler(this.BtnEditCustomers_MouseLeave);
            // 
            // BtnPaySystem
            // 
            this.BtnPaySystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPaySystem.Location = new System.Drawing.Point(880, 389);
            this.BtnPaySystem.Name = "BtnPaySystem";
            this.BtnPaySystem.Size = new System.Drawing.Size(133, 128);
            this.BtnPaySystem.TabIndex = 9;
            this.BtnPaySystem.Text = "Ödeme Sistemi";
            this.BtnPaySystem.UseVisualStyleBackColor = true;
            this.BtnPaySystem.Click += new System.EventHandler(this.BtnPaySystem_Click);
            this.BtnPaySystem.MouseEnter += new System.EventHandler(this.BtnPaySystem_MouseEnter);
            this.BtnPaySystem.MouseLeave += new System.EventHandler(this.BtnPaySystem_MouseLeave);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBack.Location = new System.Drawing.Point(12, 666);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(133, 51);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Geri";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.BtnBack.MouseEnter += new System.EventHandler(this.BtnBack_MouseEnter);
            this.BtnBack.MouseLeave += new System.EventHandler(this.BtnBack_MouseLeave);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExit.Location = new System.Drawing.Point(1067, 666);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(133, 51);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Çıkış";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.BtnExit.MouseEnter += new System.EventHandler(this.BtnExit_MouseEnter);
            this.BtnExit.MouseLeave += new System.EventHandler(this.BtnExit_MouseLeave);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1212, 729);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnPaySystem);
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
        private System.Windows.Forms.Button BtnPaySystem;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
    }
}