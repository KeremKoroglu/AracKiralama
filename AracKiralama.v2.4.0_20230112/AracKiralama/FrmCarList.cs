using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class FrmCarList : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsSqlDatabase Database = new ClsSqlDatabase();
        #endregion

        // Form Connection -- Form Bağlantıları
        #region Form Connection
        readonly FrmIdleCarList IdleCarList = new FrmIdleCarList();
        #endregion

        // FORM
        #region Form
        public FrmCarList()
        {
            InitializeComponent();
        }
        // Load
        private void FrmCarList_Load(object sender, EventArgs e)
        {
            // Write Table To Data Grid View -- Tabloyu Data Grid View'e Yaz
            DgvCarList.DataSource = Database.WriteDGV(Database.dbAracKiralama, Database.tbCars);
        }
        // Closing
        private void FrmCarList_FormClosing(object sender, FormClosingEventArgs e)
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
        // Next Table
        private void BtnNextTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            IdleCarList.Show();
        }
        #endregion

        // DESIGN
        #region Design

        // Table Design (Zebra Striping)
        private void DgvCarList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
