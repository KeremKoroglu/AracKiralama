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
    public partial class FrmEditCars : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsSqlDatabase SqlDatabase = new ClsSqlDatabase();
        readonly ClsAracKiralamaDatabase AracKiralamaDatabase = new ClsAracKiralamaDatabase();
        readonly ClsTextTools TextTools = new ClsTextTools();
        #endregion

        // FORM
        #region Form
        readonly int maxChar = 50;
        public FrmEditCars()
        {
            InitializeComponent();
        }
        private void FrmEditCars_Load(object sender, EventArgs e)
        {
            GetValues();
        }
        #endregion

        // BUTTONS
        #region BUuttons
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
                string model = SqlDatabase.Search(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", "%%", 1, "Model", TxtModel.Text)[0];
                if (model != null)
                {
                    DialogResult answer = MessageBox.Show("Model Bulunamadı! \nBunu mu demek istediniz? \n" + model, "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (answer == DialogResult.Yes)
                    {
                        TxtModel.Text = model;

                        id = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Id", 1, "Model", "'" + TxtModel.Text + "'")[0];
                        if (id != null)
                        {
                            CmbID.SelectedItem = id;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Model Bulunamadı! \nLütfen modeli doğru girdiğinizden emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Control
                string name = TextTools.GetBeforeSpace(CmbRenter.Text);
                string surname = TextTools.GetAfterSpace(CmbRenter.Text);
                string model = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", 1, "Id", CmbID.Text)[0];
                string lastRenter = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Renter", 1, "Id", CmbID.Text)[0] == "" ? "NULL" : SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Renter", 1, "Id", CmbID.Text)[0];
                string lastRenterName = TextTools.GetBeforeSpace(lastRenter);
                string lastRenterSurname = TextTools.GetAfterSpace(lastRenter);
                string renter = CmbRenter.Text == "Boş" ? "NULL" : CmbRenter.Text;

                if (SqlDatabase.IsThere(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", "=", 2, "Name", name, "Surname", surname, "Renter", "1") == false && renter != "NULL")
                {
                    throw new InvalidOperationException("Bu müşterinin kiraladığı bir model zaten var");
                }

                // Update
                string rentDate = ChbRentDateNull.Checked ? "NULL" : DtpRentDate.Value.ToString("yyyyMMdd");
                string deliveredDate = ChbDeliveredDateNull.Checked ? "NULL" : DtpDeliveredDate.Value.ToString("yyyyMMdd");
                string deliveryDate = ChbDeliveryDateNull.Checked ? "NULL" : DtpDeliveryDate.Value.ToString("yyyyMMdd");
                string autoGear = ChbAutoGear.Checked ? "1" : "0";
                string rented = ChbRented.Checked ? "1" : "0";
                string damaged = ChbDamaged.Checked ? "1" : "0";
                string delivered = ChbDelivered.Checked ? "1" : "0";
                string description = RtbDescription.Text == "" ? "NULL" : RtbDescription.Text;

                AracKiralamaDatabase.EditCar(CmbID.Text, TxtPrice.Text, model, TxtKm.Text, CmbSeat.Text, autoGear, damaged, description, rented, renter, rentDate, delivered, deliveredDate, deliveryDate, lastRenter);

                MessageBox.Show("Araba Düzenlendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // DESIGN
        #region Design

        // Edit
        private void CmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get Values
            TxtModel.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", 1, "Id", CmbID.Text)[0];
            TxtPrice.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Price", 1, "Id", CmbID.Text)[0];
            TxtNewModel.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", 1, "Id", CmbID.Text)[0];
            TxtKm.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Km", 1, "Id", CmbID.Text)[0];
            CmbRenter.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Renter", 1, "Id", CmbID.Text)[0];
            RtbDescription.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Description", 1, "Id", CmbID.Text)[0];
            ChbAutoGear.Checked = Convert.ToBoolean(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "AutoGear", 1, "Id", CmbID.Text)[0]);
            ChbRented.Checked = Convert.ToBoolean(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Rented", 1, "Id", CmbID.Text)[0]);
            ChbDamaged.Checked = Convert.ToBoolean(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Damaged", 1, "Id", CmbID.Text)[0]);
            ChbDelivered.Checked = Convert.ToBoolean(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Delivered", 1, "Id", CmbID.Text)[0]);
            CmbSeat.SelectedItem = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Seat", 1, "Id", CmbID.Text)[0];
            TxtLastRenter.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "LastRenter", 1, "Id", CmbID.Text)[0];

            // If Null
            string date = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "RentDate", 1, "Id", CmbID.Text)[0];
            if (date == "") { ChbRentDateNull.Checked = true; }
            else { DtpRentDate.Value = Convert.ToDateTime(date); ChbRentDateNull.Checked = false; }
            date = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "DeliveredDate", 1, "Id", CmbID.Text)[0];
            if (date == "") { ChbDeliveredDateNull.Checked = true; }
            else { DtpDeliveredDate.Value = Convert.ToDateTime(date); ChbDeliveredDateNull.Checked = false; }
            date = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "DeliveryDate", 1, "Id", CmbID.Text)[0];
            if (date == "") { ChbDeliveryDateNull.Checked = true; }
            else { DtpDeliveryDate.Value = Convert.ToDateTime(date); ChbDeliveryDateNull.Checked = false; }
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
        
        // Value Limit
        private void TxtModel_TextChanged(object sender, EventArgs e)
        {
            if (TxtModel.Text.Length > maxChar)
            {
                MessageBox.Show("Girilen değer 50 karakter sınırını aşıyor", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtModel.Text = TxtModel.Text.Substring(0, maxChar);
                TxtModel.SelectionStart = TxtModel.Text.Length;
            }
        }
        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtPrice.Text) && !int.TryParse(TxtPrice.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir tamsayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TxtNewModel_TextChanged(object sender, EventArgs e)
        {
            if (TxtNewModel.Text.Length > maxChar)
            {
                MessageBox.Show("Girilen değer 50 karakter sınırını aşıyor", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNewModel.Text = TxtNewModel.Text.Substring(0, maxChar);
                TxtNewModel.SelectionStart = TxtNewModel.Text.Length;
            }
        }
        private void TxtKm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtKm.Text) && !int.TryParse(TxtKm.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir tamsayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TxtRenter_TextChanged(object sender, EventArgs e)
        {
            if (CmbRenter.Text.Length > maxChar)
            {
                MessageBox.Show("Girilen değer 50 karakter sınırını aşıyor", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbRenter.Text = CmbRenter.Text.Substring(0, maxChar);
                CmbRenter.SelectionStart = CmbRenter.Text.Length;
            }
        }
        private void TxtLastRenter_TextChanged(object sender, EventArgs e)
        {
            if (TxtLastRenter.Text.Length > maxChar)
            {
                MessageBox.Show("Girilen değer 50 karakter sınırını aşıyor", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtLastRenter.Text = TxtLastRenter.Text.Substring(0, maxChar);
                TxtLastRenter.SelectionStart = TxtLastRenter.Text.Length;
            }
        }
        private void RtbDescription_TextChanged(object sender, EventArgs e)
        {
            if (RtbDescription.Text.Length > maxChar)
            {
                MessageBox.Show("Girilen değer 50 karakter sınırını aşıyor", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RtbDescription.Text = RtbDescription.Text.Substring(0, maxChar);
                RtbDescription.SelectionStart = RtbDescription.Text.Length;
            }
        }
        #endregion

        // METODS
        #region Metods
        void GetValues()
        {
            // Write CmbID
            CmbID.Items.Clear();
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Id"))
            {
                CmbID.Items.Add(item);
            }
            CmbID.SelectedIndex = 0;
            // Write CmbRenter
            CmbRenter.Items.Clear();
            string[] Names = new string[SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name").Length];
            int i = 0;
            CmbRenter.Items.Add("Boş");
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name"))
            {
                Names[i] = item;
                i++;
            }
            string[] Surnames = new string[SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname").Length];
            i = 0;
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname"))
            {
                Surnames[i] = item;
                i++;
            }
            i = 0;
            foreach (string item in Names)
            {
                CmbRenter.Items.Add(item + " " + Surnames[i]);
                i++;
            }
            i = 0;
            CmbRenter.SelectedItem = "Boş";
            CmbRenter.SelectedItem = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Renter", 1, "Id", CmbID.Text)[0];
        }
        #endregion
    }
}
