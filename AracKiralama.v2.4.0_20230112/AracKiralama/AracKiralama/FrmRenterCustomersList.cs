﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class FrmRenterCustomersList : Form
    {
        // Class Connection 
        #region Class Connection
        readonly ClsSqlDatabase Database = new ClsSqlDatabase();
        #endregion

        // FORM
        #region Form
        public FrmRenterCustomersList()
        {
            InitializeComponent();
        }
        // Load
        private void FrmRenterCustomersList_Load(object sender, EventArgs e)
        {
            // Write Table To Data Grid View -- Tabloyu Data Grid View'e Yaz
            DgvRenterCustomerList.DataSource = Database.WriteDGV(Database.dbAracKiralama, Database.tbCustomers, 1, "Renter", "1");
        }
        // Closing
        private void FrmRenterCustomersList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                this.Hide();
                e.Cancel = true;
            }
        }
        #endregion

        // BUTTONS
        #region Buttons

        // Close
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        // DESIGN
        #region Design

        // Table Design (Zebra Striping)
        private void DgvRenterCustomerList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (sender is DataGridView gridView)
            {
                var row = gridView.Rows[e.RowIndex];
                if (e.RowIndex % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }
        #endregion  


    }
}