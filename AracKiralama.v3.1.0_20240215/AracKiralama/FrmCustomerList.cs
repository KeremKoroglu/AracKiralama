using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SqlLibrary;

namespace AracKiralama
{
    public partial class FrmCustomerList : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly SqlDatabase sqlDatabase = new();
        readonly DatabaseManager DatabaseManage = new(ConfigurationManager.ConnectionStrings["AracKiralamaConnectionString"].ConnectionString);
        #endregion

        // FORM
        #region Form
        public FrmCustomerList()
        {
            InitializeComponent();
        }
        private void FrmCustomerList_Activated(object sender, EventArgs e)
        {
            DgvCustomerList.DataSource = DatabaseManage.GetTable(sqlDatabase.tbCustomers);
        }
        private void FrmCustomerList_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        // DESIGN
        #region Design

        // Table Design (Zebra Striping)
        private void DgvCustomerList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        // Button Design
        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = Color.Gray;
        }
        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = SystemColors.ActiveBorder;
        }

        #endregion
    }
}
