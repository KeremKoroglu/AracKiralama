namespace AracKiralama
{
    partial class FrmCustomerList
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
            this.LblCustomerList = new System.Windows.Forms.Label();
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
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracKiralamaDataSet = new AracKiralama.AracKiralamaDataSet();
            this.customersTableAdapter = new AracKiralama.AracKiralamaDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCustomerList
            // 
            this.LblCustomerList.AutoSize = true;
            this.LblCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCustomerList.Location = new System.Drawing.Point(12, 9);
            this.LblCustomerList.Name = "LblCustomerList";
            this.LblCustomerList.Size = new System.Drawing.Size(274, 46);
            this.LblCustomerList.TabIndex = 3;
            this.LblCustomerList.Text = "Müşteri Listesi";
            // 
            // DgvCustomerList
            // 
            this.DgvCustomerList.AllowUserToOrderColumns = true;
            this.DgvCustomerList.AutoGenerateColumns = false;
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
            this.deliveryDateDataGridViewTextBoxColumn});
            this.DgvCustomerList.DataSource = this.customersBindingSource;
            this.DgvCustomerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvCustomerList.Location = new System.Drawing.Point(12, 69);
            this.DgvCustomerList.Name = "DgvCustomerList";
            this.DgvCustomerList.RowHeadersWidth = 5;
            this.DgvCustomerList.RowTemplate.Height = 50;
            this.DgvCustomerList.Size = new System.Drawing.Size(1324, 640);
            this.DgvCustomerList.TabIndex = 4;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 75;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 110;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 110;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // tcknDataGridViewTextBoxColumn
            // 
            this.tcknDataGridViewTextBoxColumn.DataPropertyName = "Tckn";
            this.tcknDataGridViewTextBoxColumn.HeaderText = "Tckn";
            this.tcknDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcknDataGridViewTextBoxColumn.Name = "tcknDataGridViewTextBoxColumn";
            this.tcknDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // renterDataGridViewCheckBoxColumn
            // 
            this.renterDataGridViewCheckBoxColumn.DataPropertyName = "Renter";
            this.renterDataGridViewCheckBoxColumn.HeaderText = "Kiracı";
            this.renterDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.renterDataGridViewCheckBoxColumn.Name = "renterDataGridViewCheckBoxColumn";
            this.renterDataGridViewCheckBoxColumn.Width = 75;
            // 
            // rentedModelDataGridViewTextBoxColumn
            // 
            this.rentedModelDataGridViewTextBoxColumn.DataPropertyName = "RentedModel";
            this.rentedModelDataGridViewTextBoxColumn.HeaderText = "Kiralanan Model";
            this.rentedModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentedModelDataGridViewTextBoxColumn.Name = "rentedModelDataGridViewTextBoxColumn";
            this.rentedModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentDateDataGridViewTextBoxColumn
            // 
            this.rentDateDataGridViewTextBoxColumn.DataPropertyName = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.HeaderText = "Kiralama Tarihi";
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
            this.deliveredDataGridViewCheckBoxColumn.Width = 75;
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
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.DgvCustomerList);
            this.Controls.Add(this.LblCustomerList);
            this.Name = "FrmCustomerList";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.FrmCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCustomerList;
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
    }
}