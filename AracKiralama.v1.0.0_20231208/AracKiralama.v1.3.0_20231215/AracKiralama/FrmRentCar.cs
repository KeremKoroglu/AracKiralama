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
    public partial class FrmRentCar : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsSqlDatabase SqlDatabase = new ClsSqlDatabase();
        readonly ClsAracKiralamaDatabase AracKiralamaDatabase = new ClsAracKiralamaDatabase();
        #endregion

        // Form Connection -- Form Bağlantıları
        #region Form Connection
        public FrmRentCar()
        {
            InitializeComponent();
        }
        private void FrmRentCar_Load(object sender, EventArgs e)
        {
            // Get Values
            #region Get Values
            // Write CmbModel
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", 1, "Rented", "0"))
            {
                CmbModel.Items.Add(item);
            }
            CmbModel.SelectedIndex = 0;
            // Write CmbRecallModel
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", 1, "Rented", "1"))
            {
                CmbRecallModel.Items.Add(item);
            }
            CmbRecallModel.SelectedIndex = 0;
            // Write CmbRenter
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", 1, "Renter", "0"))
            {
                CmbRenter.Items.Add(item);
            }
            CmbRenter.SelectedIndex = 0;
            // Write CmbRecallRenter
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", 1, "Renter", "1"))
            {
                CmbRecallRenter.Items.Add(item);
            }
            CmbRecallRenter.SelectedIndex = 0;
            // Edit Date Time Picker 
            DtpDeliveryDate.Value = DateTime.Now.AddDays(7);
            #endregion

            // Design
        }
        #endregion

        // BUTTONS
        #region BUTTONS
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Rent
            if (TbcRentCar.SelectedIndex == 0)
            {
                AracKiralamaDatabase.UpdateCar(CmbModel.Text, CmbRenter.Text, RtbDescription.Text, DtpRentDate.Value.ToString("yyyyMMdd"), DtpDeliveryDate.Value.ToString("yyyyMMdd"));
            }
            else if (TbcRentCar.SelectedIndex == 1)
            {
                SqlDatabase.UpdateCell(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "DeliveredDate", DtpDeliveredDate.Value.ToString("yyyyMMdd"), 2, "Model", CmbRecallModel.Text, "Renter", CmbRecallRenter.Text);
            }
        }
        #endregion

        // Design
        #region Design
        private void TbcRentCar_Click(object sender, EventArgs e)
        {
            if (TbcRentCar.SelectedIndex == 0)
            {
                BtnSave.Text = "Kirala";
            }
            else
            {
                BtnSave.Text = "Çağır";
            }
        }
        #endregion        
    }
}
