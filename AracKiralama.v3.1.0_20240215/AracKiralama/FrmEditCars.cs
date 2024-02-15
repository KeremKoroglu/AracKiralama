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
using System.Configuration;
using SqlLibrary;

namespace AracKiralama
{
    public partial class FrmEditCars : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly SqlDatabase sqlDatabase = new();
        readonly SqlDatabase AracKiralamaDatabase = new();
        readonly ClsTextTools TextTools = new();
        readonly DatabaseManager DatabaseManage = new(ConfigurationManager.ConnectionStrings["AracKiralamaConnectionString"].ConnectionString);
        #endregion

        // Values -- Değişkenler
        #region Values
        readonly int maxChar = 50;
        #endregion

        // FORM
        #region Form
        public FrmEditCars()
        {
            InitializeComponent();
        }
        private void FrmEditCars_Load(object sender, EventArgs e)
        {
            GetValues();

            // Object Arrangements -- Nesne Düzenlemeleri
            TxtModel.MaxLength = maxChar;
            TxtNewModel.MaxLength = maxChar;
            RtbDescription.MaxLength = maxChar;
        }
        private void FrmEditCars_FormClosing(object sender, FormClosingEventArgs e)
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
        private void BtnFind_Click(object sender, EventArgs e)
        {
            string id = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Id", ("Model", TxtModel.Text))[0];
            if (id != null)
            {
                CmbID.SelectedItem = id;
                MessageBox.Show("Model Bulundu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string model = DatabaseManage.Search(sqlDatabase.tbCars, "Model", "%%", ("Model", TxtModel.Text))[0] == "" ? null : DatabaseManage.Search(sqlDatabase.tbCars, "Model", "%%", ("Model", TxtModel.Text))[0];
                if (model != null)
                {
                    DialogResult answer = MessageBox.Show("Model Bulunamadı! \nBunu mu demek istediniz? \n" + model, "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (answer == DialogResult.Yes)
                    {
                        TxtModel.Text = model;

                        id = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Id", ("Model", TxtModel.Text))[0];
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
                string name = CmbRenter.Text == "Yok" ? null : TextTools.GetBeforeSpace(CmbRenter.Text);
                string surname = CmbRenter.Text == "Yok" ? null : TextTools.GetAfterSpace(CmbRenter.Text);
                string model = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Model", ("Id", CmbID.Text))[0];
                string lastRenter = CmbLastRenter.Text == "Yok" ? null : CmbLastRenter.Text;
                string renter = CmbRenter.Text == "Yok" ? null : CmbRenter.Text;

                if (DatabaseManage.IsThere(sqlDatabase.tbCustomers, "Renter", "=", ("Name", name), ("Surname", surname)) && renter != null && renter != DatabaseManage.GetColumn(sqlDatabase.tbCars, "Renter", ("Id", CmbID.Text))[0])
                {
                    throw new InvalidOperationException("Bu müşterinin kiraladığı bir model zaten var");
                }

                // Update
                string rentDate = ChbRentDateNull.Checked ? null : DtpRentDate.Value.ToString("yyyyMMdd");
                string deliveredDate = ChbDeliveredDateNull.Checked ? null : DtpDeliveredDate.Value.ToString("yyyyMMdd");
                string deliveryDate = ChbDeliveryDateNull.Checked ? null : DtpDeliveryDate.Value.ToString("yyyyMMdd");
                string autoGear = ChbAutoGear.Checked ? "1" : "0";
                string rented = ChbRented.Checked ? "1" : "0";
                string damaged = ChbDamaged.Checked ? "1" : "0";
                string delivered = ChbDelivered.Checked ? "1" : "0";
                string description = RtbDescription.Text == "" ? null : RtbDescription.Text;

                AracKiralamaDatabase.EditCar(CmbID.Text, TxtPrice.Text, model, TxtKm.Text, CmbSeat.Text, autoGear, damaged, description, rented, renter, rentDate, delivered, deliveredDate, deliveryDate, lastRenter);

                MessageBox.Show("Araba Düzenlendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetValues();
                AracKiralamaDatabase.RefreshCarInfo();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        // DESIGN
        #region Design

        // Value Edit -- Değer Düzenlemeleri
        #region Value Edit
        private void CmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get Values
            TxtModel.Text = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Model", ("Id", CmbID.Text))[0];
            TxtPrice.Text = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Price", ("Id", CmbID.Text))[0];
            TxtNewModel.Text = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Model", ("Id", CmbID.Text))[0];
            TxtKm.Text = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Km", ("Id", CmbID.Text))[0];
            CmbRenter.Text = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Renter", ("Id", CmbID.Text))[0] == "" ? "Yok" : DatabaseManage.GetColumn(sqlDatabase.tbCars, "Renter", ("Id", CmbID.Text))[0];
            RtbDescription.Text = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Description", ("Id", CmbID.Text))[0];
            ChbAutoGear.Checked = Convert.ToBoolean(DatabaseManage.GetColumn(sqlDatabase.tbCars, "AutoGear", ("Id", CmbID.Text))[0]);
            ChbRented.Checked = Convert.ToBoolean(DatabaseManage.GetColumn(sqlDatabase.tbCars, "Rented", ("Id", CmbID.Text))[0]);
            ChbDamaged.Checked = Convert.ToBoolean(DatabaseManage.GetColumn(sqlDatabase.tbCars, "Damaged", ("Id", CmbID.Text))[0]);
            ChbDelivered.Checked = Convert.ToBoolean(DatabaseManage.GetColumn(sqlDatabase.tbCars, "Delivered", ("Id", CmbID.Text))[0]);
            CmbSeat.SelectedItem = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Seat", ("Id", CmbID.Text))[0];
            CmbLastRenter.SelectedItem = string.IsNullOrEmpty(DatabaseManage.GetColumn(sqlDatabase.tbCars, "LastRenter", ("Id", CmbID.Text))[0]) == true ? "Yok" : DatabaseManage.GetColumn(sqlDatabase.tbCars, "LastRenter", ("Id", CmbID.Text))[0];

            // If Null
            string date = DatabaseManage.GetColumn(sqlDatabase.tbCars, "RentDate", ("Id", CmbID.Text))[0];
            if (date == "") { ChbRentDateNull.Checked = true; }
            else { DtpRentDate.Value = Convert.ToDateTime(date); ChbRentDateNull.Checked = false; }
            date = DatabaseManage.GetColumn(sqlDatabase.tbCars, "DeliveredDate", ("Id", CmbID.Text))[0];
            if (date == "") { ChbDeliveredDateNull.Checked = true; }
            else { DtpDeliveredDate.Value = Convert.ToDateTime(date); ChbDeliveredDateNull.Checked = false; }
            date = DatabaseManage.GetColumn(sqlDatabase.tbCars, "DeliveryDate", ("Id", CmbID.Text))[0];
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
        #endregion
        // Only Numbers -- Sadece Sayılar
        #region Only Numbers
        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtPrice.Text) && !int.TryParse(TxtPrice.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir tamsayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPrice.Text = TxtPrice.Text.Substring(0, TxtPrice.TextLength - 1);
                TxtPrice.SelectionStart = TxtPrice.Text.Length;
            }
        }
        private void TxtKm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtKm.Text) && !int.TryParse(TxtKm.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir tamsayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtKm.Text = TxtKm.Text.Substring(0, TxtKm.TextLength - 1);
                TxtKm.SelectionStart = TxtKm.Text.Length;
            }
        } 
        #endregion
        // Button Design -- Buton Tasarımı
        #region Button Design
        private void BtnFind_MouseEnter(object sender, EventArgs e)
        {
            BtnFind.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnFind_MouseLeave(object sender, EventArgs e)
        {
            BtnFind.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void BtnSave_MouseEnter(object sender, EventArgs e)
        {
            BtnSave.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnSave_MouseLeave(object sender, EventArgs e)
        {
            BtnSave.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = Color.FromArgb(224, 224, 224);
        }
        #endregion

        #endregion

        // METODS
        #region Metods
        void GetValues()
        {
            // Write CmbID
            CmbID.Items.Clear();
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCars, "Id"))
            {
                CmbID.Items.Add(item);
            }
            CmbID.SelectedIndex = 0;
            // Write CmbRenter
            CmbRenter.Items.Clear();
            string[] Names = new string[DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name").Length];
            int i = 0;
            CmbRenter.Items.Add("Yok");
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name"))
            {
                Names[i] = item;
                i++;
            }
            string[] Surnames = new string[DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname").Length];
            i = 0;
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname"))
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
            CmbRenter.SelectedItem = "Yok";
            CmbRenter.SelectedItem = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Renter", ("Id", CmbID.Text))[0];
            // Write CmbLastRenter
            CmbLastRenter.Items.Clear();
            string[] LastNames = new string[DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name").Length];
            int j = 0;
            CmbLastRenter.Items.Add("Yok");
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name"))
            {
                LastNames[j] = item;
                j++;
            }
            string[] LastSurnames = new string[DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname").Length];
            j = 0;
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname"))
            {
                LastSurnames[j] = item;
                j++;
            }
            j = 0;
            foreach (string item in LastNames)
            {
                CmbLastRenter.Items.Add(item + " " + LastSurnames[j]);
                j++;
            }
            j = 0;
            CmbLastRenter.SelectedItem = "Yok";
            if (!string.IsNullOrEmpty(DatabaseManage.GetColumn(sqlDatabase.tbCars, "LastRenter", ("Id", CmbID.Text))[0]))
            {
                CmbLastRenter.SelectedItem = DatabaseManage.GetColumn(sqlDatabase.tbCars, "LastRenter", ("Id", CmbID.Text))[0];
            }
        }
        #endregion
    }
}
