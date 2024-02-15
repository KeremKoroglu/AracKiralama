using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;
using SqlLibrary;

namespace AracKiralama
{
    public partial class FrmEditCustomers : Form
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
        readonly int maxChar = 50, nmbTckn = 11, nmbPhoneNumber = 12;
        #endregion

        // FORM
        #region Form
        public FrmEditCustomers()
        {
            InitializeComponent();
        }
        private void FrmEditCustomers_Load(object sender, EventArgs e)
        {
            GetValues();

            // Object Arrangements -- Nesne Düzenlemeleri
            TxtCustomer.MaxLength = maxChar;
            TxtName.MaxLength = maxChar;
            TxtSurname.MaxLength = maxChar;
            TxtTckn.MaxLength = nmbTckn;
            TxtNumber.MaxLength = nmbPhoneNumber;
            TxtMail.MaxLength = maxChar;
        }
        private void FrmEditCustomers_FormClosing(object sender, FormClosingEventArgs e)
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
            this.Close();
        }
        private void BtnFind_Click(object sender, EventArgs e)
        {
            string name = TextTools.GetBeforeSpace(TxtCustomer.Text) == "" ? null : TextTools.GetBeforeSpace(TxtCustomer.Text);
            string surname = TextTools.GetAfterSpace(TxtCustomer.Text) == "" ? null : TextTools.GetAfterSpace(TxtCustomer.Text);

            string id = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Id", ("Name", name), ("Surname", surname))[0];
            if (id != null)
            {
                CmbID.SelectedItem = id;
                MessageBox.Show("Müşteri Bulundu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string search;
                string searchName = DatabaseManage.Search(sqlDatabase.tbCustomers, "Name", "%%", ("Name", name))[0];
                string searchSurname = DatabaseManage.Search(sqlDatabase.tbCustomers, "Surname", "%%", ("Surname", surname))[0];
                if (searchName != null || searchSurname != null)
                {
                    if (searchName != null && searchSurname == null)
                    {
                        search = searchName + " " + DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname", ("Name", searchName))[0];
                    }
                    else if (searchSurname != null && searchName == null)
                    {
                        search = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name", ("Surname", searchSurname))[0] + " " + searchSurname;
                    }
                    else
                    {
                        search = searchName + " " + DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname", ("Name", searchName))[0];
                    }

                    DialogResult answer = MessageBox.Show("Müşteri Bulunamadı! \nBunu mu demek istediniz? \n" + search, "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (answer == DialogResult.Yes)
                    {
                        TxtCustomer.Text = search;

                        id = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Id", ("Name", searchName), ("Surname", searchSurname))[0];
                        if (id != null)
                        {
                            CmbID.SelectedItem = id;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Müşteri Bulunamadı! \nLütfen modeli doğru girdiğinizden emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Controls
                string model = CmbRentedModel.Text == "" ? "NULL" : CmbRentedModel.Text;
                string lastRentedModel = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "RentedModel", ("Id", CmbID.Text))[0] == "" ? "NULL" : DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "RentedModel", ("Id", CmbID.Text))[0];
                if (DatabaseManage.IsThere(sqlDatabase.tbCars, "Model", "=", ("Model", model), ("Rented", "1")) && model != "NULL" && model != DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "RentedModel", ("Id", CmbID.Text))[0])
                {
                    throw new InvalidOperationException("Bu modelin kiralandığı bir müşteri zaten var");
                }

                // Update
                string mail = TxtMail.Text == "" ? "NULL" : TxtMail.Text;
                string renter = ChbRenter.Checked ? "1" : "0";
                string rentedModel = CmbRentedModel.Text == "Yok" ? "NULL" : CmbRentedModel.Text;
                string rentDate = ChbRentDateNull.Checked ? "NULL" : DtpRentDate.Value.ToString("yyyyMMdd");
                string delivered = ChbDelivered.Checked ? "1" : "0";
                string deliveredDate = ChbDeliveredDateNull.Checked ? "NULL" : DtpDeliveredDate.Value.ToString("yyyyMMdd");
                string deliveryDate = ChbDeliveryDateNull.Checked ? "NULL" : DtpDeliveryDate.Value.ToString("yyyyMMdd");
                
                AracKiralamaDatabase.EditCustomer(CmbID.Text, TxtName.Text, TxtSurname.Text, DtpDateOfBirth.Value.ToString("yyyyMMdd"), TxtTckn.Text, TxtNumber.Text, mail, renter, rentedModel, rentDate, delivered, deliveredDate, deliveryDate, lastRentedModel);

                MessageBox.Show("Müşteri Düzenlendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        // Get Values -- Değerleri Al
        private void CmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtCustomer.Text = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name", ("Id", CmbID.Text))[0] + " " + DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname", ("Id", CmbID.Text))[0];
            TxtName.Text = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name", ("Id", CmbID.Text))[0];
            TxtSurname.Text = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname", ("Id", CmbID.Text))[0];
            TxtTckn.Text = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Tckn", ("Id", CmbID.Text))[0];
            TxtNumber.Text = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Number", ("Id", CmbID.Text))[0];
            TxtMail.Text = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Mail", ("Id", CmbID.Text))[0];
            ChbRenter.Checked = Convert.ToBoolean(DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Renter", ("Id", CmbID.Text))[0]);
            ChbDelivered.Checked = Convert.ToBoolean(DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Delivered", ("Id", CmbID.Text))[0]);
            CmbRentedModel.Text = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "RentedModel", ("Id", CmbID.Text))[0] == "" ? "Yok" : DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "RentedModel", ("Id", CmbID.Text))[0];
            TxtLastRentedModel.Text = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "LastRentedModel", ("Id", CmbID.Text))[0];

            // If Null
            string date = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "RentDate", ("Id", CmbID.Text))[0];
            if (date == "") { ChbRentDateNull.Checked = true; }
            else { DtpRentDate.Value = Convert.ToDateTime(date); ChbRentDateNull.Checked = false; }
            date = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "DeliveredDate", ("Id", CmbID.Text))[0];
            if (date == "") { ChbDeliveredDateNull.Checked = true; }
            else { DtpDeliveredDate.Value = Convert.ToDateTime(date); ChbDeliveredDateNull.Checked = false; }
            date = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "DeliveryDate", ("Id", CmbID.Text))[0];
            if (date == "") { ChbDeliveryDateNull.Checked = true; }
            else { DtpDeliveryDate.Value = Convert.ToDateTime(date); ChbDeliveryDateNull.Checked = false; }
        }

        // Make Null -- Null Yap
        #region Make Null
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
        private void TxtTckn_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtTckn.Text) && !long.TryParse(TxtTckn.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir tamsayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTckn.Text = TxtTckn.Text.Substring(0, TxtTckn.TextLength - 1);
                TxtTckn.SelectionStart = TxtTckn.Text.Length;
            }
        }
        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNumber.Text) && !long.TryParse(TxtNumber.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir tamsayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNumber.Text = TxtNumber.Text.Substring(0, TxtNumber.TextLength - 1);
                TxtNumber.SelectionStart = TxtNumber.Text.Length;
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
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Id"))
            {
                CmbID.Items.Add(item);
            }
            CmbID.SelectedIndex = 0;
            // Write CmbRentedModel
            CmbRentedModel.Items.Clear();
            CmbRentedModel.Items.Add("Yok");
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCars, "Model"))
            {
                CmbRentedModel.Items.Add(item);
            }
            CmbRentedModel.SelectedItem = "Yok";
            CmbRentedModel.SelectedItem = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "RentedModel", ("Id", CmbID.Text))[0];
        }
        #endregion
    }
}
