﻿namespace AracKiralama
{
    partial class FrmCarList
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.aracKiralamaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracKiralamaDataSet = new AracKiralama.AracKiralamaDataSet();
            this.carsTableAdapter = new AracKiralama.AracKiralamaDataSetTableAdapters.CarsTableAdapter();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Araba Listesi";
            // 
            // DgvCarList
            // 
            this.DgvCarList.AllowUserToOrderColumns = true;
            this.DgvCarList.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.DgvCarList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvCarList.Location = new System.Drawing.Point(12, 58);
            this.DgvCarList.Name = "DgvCarList";
            this.DgvCarList.RowHeadersWidth = 5;
            this.DgvCarList.RowTemplate.Height = 50;
            this.DgvCarList.Size = new System.Drawing.Size(1324, 640);
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
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Fiyat";
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
            this.seatDataGridViewTextBoxColumn.HeaderText = "Koltuk";
            this.seatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatDataGridViewTextBoxColumn.Name = "seatDataGridViewTextBoxColumn";
            this.seatDataGridViewTextBoxColumn.Width = 125;
            // 
            // autoGearDataGridViewCheckBoxColumn
            // 
            this.autoGearDataGridViewCheckBoxColumn.DataPropertyName = "AutoGear";
            this.autoGearDataGridViewCheckBoxColumn.HeaderText = "Oto Vites";
            this.autoGearDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.autoGearDataGridViewCheckBoxColumn.Name = "autoGearDataGridViewCheckBoxColumn";
            this.autoGearDataGridViewCheckBoxColumn.Width = 125;
            // 
            // damagedDataGridViewCheckBoxColumn
            // 
            this.damagedDataGridViewCheckBoxColumn.DataPropertyName = "Damaged";
            this.damagedDataGridViewCheckBoxColumn.HeaderText = "Hasarlı";
            this.damagedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.damagedDataGridViewCheckBoxColumn.Name = "damagedDataGridViewCheckBoxColumn";
            this.damagedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentedDataGridViewCheckBoxColumn
            // 
            this.rentedDataGridViewCheckBoxColumn.DataPropertyName = "Rented";
            this.rentedDataGridViewCheckBoxColumn.HeaderText = "Kiralandı";
            this.rentedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rentedDataGridViewCheckBoxColumn.Name = "rentedDataGridViewCheckBoxColumn";
            this.rentedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // renterDataGridViewTextBoxColumn
            // 
            this.renterDataGridViewTextBoxColumn.DataPropertyName = "Renter";
            this.renterDataGridViewTextBoxColumn.HeaderText = "Kiralayan";
            this.renterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.renterDataGridViewTextBoxColumn.Name = "renterDataGridViewTextBoxColumn";
            this.renterDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentDateDataGridViewTextBoxColumn
            // 
            this.rentDateDataGridViewTextBoxColumn.DataPropertyName = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.HeaderText = "Kiralanma Tarihi";
            this.rentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentDateDataGridViewTextBoxColumn.Name = "rentDateDataGridViewTextBoxColumn";
            this.rentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveredDataGridViewCheckBoxColumn
            // 
            this.deliveredDataGridViewCheckBoxColumn.DataPropertyName = "Delivered";
            this.deliveredDataGridViewCheckBoxColumn.HeaderText = "Teslim Edildi";
            this.deliveredDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.deliveredDataGridViewCheckBoxColumn.Name = "deliveredDataGridViewCheckBoxColumn";
            this.deliveredDataGridViewCheckBoxColumn.Width = 125;
            // 
            // deliveredDateDataGridViewTextBoxColumn
            // 
            this.deliveredDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveredDate";
            this.deliveredDateDataGridViewTextBoxColumn.HeaderText = "Teslim Edilen Tarih";
            this.deliveredDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveredDateDataGridViewTextBoxColumn.Name = "deliveredDateDataGridViewTextBoxColumn";
            this.deliveredDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "Teslim Tarihi";
            this.deliveryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastRenterDataGridViewTextBoxColumn
            // 
            this.lastRenterDataGridViewTextBoxColumn.DataPropertyName = "LastRenter";
            this.lastRenterDataGridViewTextBoxColumn.HeaderText = "Son Kiralayan";
            this.lastRenterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastRenterDataGridViewTextBoxColumn.Name = "lastRenterDataGridViewTextBoxColumn";
            this.lastRenterDataGridViewTextBoxColumn.Width = 125;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.aracKiralamaDataSetBindingSource;
            // 
            // aracKiralamaDataSetBindingSource
            // 
            this.aracKiralamaDataSetBindingSource.DataSource = this.aracKiralamaDataSet;
            this.aracKiralamaDataSetBindingSource.Position = 0;
            // 
            // aracKiralamaDataSet
            // 
            this.aracKiralamaDataSet.DataSetName = "AracKiralamaDataSet";
            this.aracKiralamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClose.Location = new System.Drawing.Point(12, 724);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(148, 55);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // FrmCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1352, 787);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DgvCarList);
            this.Controls.Add(this.label1);
            this.Name = "FrmCarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba Listesi";
            this.Activated += new System.EventHandler(this.FrmCarList_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCarList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvCarList;
        private System.Windows.Forms.BindingSource aracKiralamaDataSetBindingSource;
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
        private System.Windows.Forms.Button BtnClose;
    }
}