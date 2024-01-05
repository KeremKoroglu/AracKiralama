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
    public partial class FrmEditCars : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsSqlDatabase SqlDatabase = new ClsSqlDatabase();
        #endregion

        // FORM
        #region Form
        public FrmEditCars()
        {
            InitializeComponent();
        }
        private void FrmEditCars_Load(object sender, EventArgs e)
        {
            // Get Values
            #region Get Values
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Id"))
            {
                CmbID.Items.Add(item);
            }
            CmbID.SelectedIndex = 0;
            #endregion
        }
        #endregion

        // BUTTONS
        #region BUTTONS
        private void BtnFind_Click(object sender, EventArgs e)
        {
            string id = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Id", 1, "Model", "'" + TxtModel.Text + "'")[0];
            if (id != null)
            {
                CmbID.SelectedItem = id;
                MessageBox.Show("Model Bulundu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Model Bulunamadı! \nLütfen modeli doğru girdiğinizden emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // DESIGN
        #region DESIGN
        private void CmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get Values
            TxtModel.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", 1, "Id", CmbID.Text)[0];
            TxtPrice.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Price", 1, "Id", CmbID.Text)[0];
            TxtNewModel.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", 1, "Id", CmbID.Text)[0];
            TxtKm.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Km", 1, "Id", CmbID.Text)[0];
            TxtRenter.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Renter", 1, "Id", CmbID.Text)[0];
            RtbDescription.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Description", 1, "Id", CmbID.Text)[0];
            ChbAutoGear.Checked = Convert.ToBoolean(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "AutoGear", 1, "Id", CmbID.Text)[0]);
            ChbRented.Checked = Convert.ToBoolean(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Rented", 1, "Id", CmbID.Text)[0]);
            ChbDamaged.Checked = Convert.ToBoolean(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Damaged", 1, "Id", CmbID.Text)[0]);
            ChbDelivered.Checked = Convert.ToBoolean(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Delivered", 1, "Id", CmbID.Text)[0]);
            CmbSeat.SelectedItem = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Seat", 1, "Id", CmbID.Text)[0];

            // If Null
            string date = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "RentDate", 1, "Id", CmbID.Text)[0];
            if (date == "") { ChbRentDateNull.Checked = true; }
            else { DtpRentDate.Value = Convert.ToDateTime(date); ChbRentDateNull.Checked = false; }
            date = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "DeliveredDate", 1, "Id", CmbID.Text)[0];
            if (date == "") { ChbDeliveredDateNull.Checked = true; }
            else { DtpDeliveredDate.Value = Convert.ToDateTime(date); ChbDeliveredDateNull.Checked = false; }
            date = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "DeliveryDate", 1, "Id", CmbID.Text)[0];
            if (date == "") { ChbDeliveryDateNull.Checked = true; ChbDeliveryDateNull.Checked = false; }
            else { DtpDeliveryDate.Value = Convert.ToDateTime(date); }
        }
        private void ChbRentDateNull_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbRentDateNull.Checked == true)
            {
                DtpRentDate.Enabled = false;
            }
            else
            {
                DtpRentDate.Enabled = true;
            }
        }
        private void ChbDeliveredDateNull_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbDeliveredDateNull.Checked == true)
            {
                DtpDeliveredDate.Enabled = false;
            }
            else
            {
                DtpDeliveredDate.Enabled = true;
            }
        }
        private void ChbDeliveryDateNull_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbDeliveryDateNull.Checked == true)
            {
                DtpDeliveryDate.Enabled = false;
            }
            else
            {
                DtpDeliveryDate.Enabled = true;
            }
        }
        #endregion        
    }
}
