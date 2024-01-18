using System;
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
    public partial class FrmIdleCarList : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsSqlDatabase Database = new ClsSqlDatabase();
        #endregion

        // Form Connection -- Form Bağlantıları
        #region Form Connection
        readonly FrmRentedCarList RentedCarList = new FrmRentedCarList();
        #endregion

        // FORM
        #region Form
        public FrmIdleCarList()
        {
            InitializeComponent();
        }
        private void FrmIdleCarList_Load(object sender, EventArgs e)
        {
            // Write Table To Data Grid View -- Tabloyu Data Grid View'e Yaz
            DgvIdleCarList.DataSource = Database.WriteDGV(Database.tbCars, 1, "Rented", "0");
        }
        private void FrmIdleCarList_FormClosing(object sender, FormClosingEventArgs e)
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
        private void BtnNextTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentedCarList.Show();
        }

        #endregion

        // DESIGN
        #region Design

        // Table Design (Zebra Striping)
        private void DgvIdleCarList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
