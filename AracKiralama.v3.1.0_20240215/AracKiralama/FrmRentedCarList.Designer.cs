namespace AracKiralama
{
    partial class FrmRentedCarList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblRentedCarList = new System.Windows.Forms.Label();
            this.DgvRentedCarList = new System.Windows.Forms.DataGridView();
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.carsTableAdapter = new AracKiralama.AracKiralamaDataSetTableAdapters.CarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRentedCarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRentedCarList
            // 
            this.LblRentedCarList.AutoSize = true;
            this.LblRentedCarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRentedCarList.Location = new System.Drawing.Point(12, 9);
            this.LblRentedCarList.Name = "LblRentedCarList";
            this.LblRentedCarList.Size = new System.Drawing.Size(428, 46);
            this.LblRentedCarList.TabIndex = 2;
            this.LblRentedCarList.Text = "Kiralanan Araba Listesi";
            // 
            // DgvRentedCarList
            // 
            this.DgvRentedCarList.AllowUserToOrderColumns = true;
            this.DgvRentedCarList.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRentedCarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvRentedCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRentedCarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DgvRentedCarList.DataSource = this.carsBindingSource;
            this.DgvRentedCarList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvRentedCarList.Location = new System.Drawing.Point(12, 58);
            this.DgvRentedCarList.Name = "DgvRentedCarList";
            this.DgvRentedCarList.RowHeadersWidth = 5;
            this.DgvRentedCarList.RowTemplate.Height = 50;
            this.DgvRentedCarList.Size = new System.Drawing.Size(1324, 640);
            this.DgvRentedCarList.TabIndex = 7;
            this.DgvRentedCarList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvRentedCarList_RowPostPaint);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // kmDataGridViewTextBoxColumn
            // 
            this.kmDataGridViewTextBoxColumn.DataPropertyName = "Km";
            this.kmDataGridViewTextBoxColumn.HeaderText = "Km";
            this.kmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kmDataGridViewTextBoxColumn.Name = "kmDataGridViewTextBoxColumn";
            this.kmDataGridViewTextBoxColumn.Width = 125;
            // 
            // seatDataGridViewTextBoxColumn
            // 
            this.seatDataGridViewTextBoxColumn.DataPropertyName = "Seat";
            this.seatDataGridViewTextBoxColumn.HeaderText = "Seat";
            this.seatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatDataGridViewTextBoxColumn.Name = "seatDataGridViewTextBoxColumn";
            this.seatDataGridViewTextBoxColumn.Width = 125;
            // 
            // autoGearDataGridViewCheckBoxColumn
            // 
            this.autoGearDataGridViewCheckBoxColumn.DataPropertyName = "AutoGear";
            this.autoGearDataGridViewCheckBoxColumn.HeaderText = "AutoGear";
            this.autoGearDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.autoGearDataGridViewCheckBoxColumn.Name = "autoGearDataGridViewCheckBoxColumn";
            this.autoGearDataGridViewCheckBoxColumn.Width = 125;
            // 
            // damagedDataGridViewCheckBoxColumn
            // 
            this.damagedDataGridViewCheckBoxColumn.DataPropertyName = "Damaged";
            this.damagedDataGridViewCheckBoxColumn.HeaderText = "Damaged";
            this.damagedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.damagedDataGridViewCheckBoxColumn.Name = "damagedDataGridViewCheckBoxColumn";
            this.damagedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentedDataGridViewCheckBoxColumn
            // 
            this.rentedDataGridViewCheckBoxColumn.DataPropertyName = "Rented";
            this.rentedDataGridViewCheckBoxColumn.HeaderText = "Rented";
            this.rentedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rentedDataGridViewCheckBoxColumn.Name = "rentedDataGridViewCheckBoxColumn";
            this.rentedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // renterDataGridViewTextBoxColumn
            // 
            this.renterDataGridViewTextBoxColumn.DataPropertyName = "Renter";
            this.renterDataGridViewTextBoxColumn.HeaderText = "Renter";
            this.renterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.renterDataGridViewTextBoxColumn.Name = "renterDataGridViewTextBoxColumn";
            this.renterDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentDateDataGridViewTextBoxColumn
            // 
            this.rentDateDataGridViewTextBoxColumn.DataPropertyName = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.HeaderText = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentDateDataGridViewTextBoxColumn.Name = "rentDateDataGridViewTextBoxColumn";
            this.rentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveredDataGridViewCheckBoxColumn
            // 
            this.deliveredDataGridViewCheckBoxColumn.DataPropertyName = "Delivered";
            this.deliveredDataGridViewCheckBoxColumn.HeaderText = "Delivered";
            this.deliveredDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.deliveredDataGridViewCheckBoxColumn.Name = "deliveredDataGridViewCheckBoxColumn";
            this.deliveredDataGridViewCheckBoxColumn.Width = 125;
            // 
            // deliveredDateDataGridViewTextBoxColumn
            // 
            this.deliveredDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveredDate";
            this.deliveredDateDataGridViewTextBoxColumn.HeaderText = "DeliveredDate";
            this.deliveredDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveredDateDataGridViewTextBoxColumn.Name = "deliveredDateDataGridViewTextBoxColumn";
            this.deliveredDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastRenterDataGridViewTextBoxColumn
            // 
            this.lastRenterDataGridViewTextBoxColumn.DataPropertyName = "LastRenter";
            this.lastRenterDataGridViewTextBoxColumn.HeaderText = "LastRenter";
            this.lastRenterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastRenterDataGridViewTextBoxColumn.Name = "lastRenterDataGridViewTextBoxColumn";
            this.lastRenterDataGridViewTextBoxColumn.Width = 125;
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
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Location = new System.Drawing.Point(12, 720);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(148, 55);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRentedCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1352, 787);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DgvRentedCarList);
            this.Controls.Add(this.LblRentedCarList);
            this.Name = "FrmRentedCarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiralanan Araba Listesi";
            this.Activated += new System.EventHandler(this.FrmRentedCarList_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRentedCarList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRentedCarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRentedCarList;
        private System.Windows.Forms.DataGridView DgvRentedCarList;
        private System.Windows.Forms.Button BtnClose;
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