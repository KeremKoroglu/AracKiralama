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
    public partial class FrmEditCustomers : Form
    {
        // Class Connection
        #region Class Connection
        readonly ClsSqlDatabase SqlDatabase = new ClsSqlDatabase();
        readonly ClsAracKiralamaDatabase AracKiralamaDatabase = new ClsAracKiralamaDatabase();
        readonly ClsTextTools TextTools = new ClsTextTools();
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
        }
        #endregion

        // BUTTONS
        #region Buttons
        private void BtnFind_Click(object sender, EventArgs e)
        {
            string name = TextTools.GetBeforeSpace(TxtCustomer.Text) == "" ? null : TextTools.GetBeforeSpace(TxtCustomer.Text);
            string surname = TextTools.GetAfterSpace(TxtCustomer.Text) == "" ? null : TextTools.GetAfterSpace(TxtCustomer.Text);

            string id = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Id", 2, "Name", name, "Surname", surname)[0];
            if (id != null)
            {
                CmbID.SelectedItem = id;
                MessageBox.Show("Müşteri Bulundu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string search;
                string searchName = SqlDatabase.Search(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", "%%", 1, "Name", name)[0];
                string searchSurname = SqlDatabase.Search(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname", "%%", 1, "Surname", surname)[0];
                if (searchName != null || searchSurname != null)
                {
                    if (searchName != null && searchSurname == null)
                    {
                        search = searchName + " " + SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname", 1, "Name", searchName)[0];
                    }
                    else if (searchSurname != null && searchName == null)
                    {
                        search = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", 1, "Surname", searchSurname)[0] + " " + searchSurname;
                    }
                    else
                    {
                        search = searchName + " " + SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname", 1, "Name", searchName)[0];
                    }

                    DialogResult answer = MessageBox.Show("Müşteri Bulunamadı! \nBunu mu demek istediniz? \n" + search, "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (answer == DialogResult.Yes)
                    {
                        TxtCustomer.Text = search;

                        id = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Id", 2, "Name", searchName, "Surname", searchSurname)[0];
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
        #endregion

        // DESIGN
        #region Design

        // Get Values
        private void CmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtCustomer.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", 1, "Id", CmbID.Text)[0] + " " + SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname", 1, "Id", CmbID.Text)[0];
            TxtName.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", 1, "Id", CmbID.Text)[0];
            TxtSurname.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname", 1, "Id", CmbID.Text)[0];
            TxtTckn.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Tckn", 1, "Id", CmbID.Text)[0];
            TxtNumber.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Number", 1, "Id", CmbID.Text)[0];
            TxtMail.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Mail", 1, "Id", CmbID.Text)[0];
            ChbRenter.Checked = Convert.ToBoolean(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Renter", 1, "Id", CmbID.Text)[0]);
            ChbDelivered.Checked = Convert.ToBoolean(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Delivered", 1, "Id", CmbID.Text)[0]);
            TxtLastRentedModel.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "LastRentedModel", 1, "Id", CmbID.Text)[0];

            // If Null
            string date = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "DateOfBirth", 1, "Id", CmbID.Text)[0];
            if (date == "") { ChbDateOfBirthNull.Checked = true; }
            else { DtpDateOfBirth.Value = Convert.ToDateTime(date); ChbDateOfBirthNull.Checked = false; }
            date = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "RentDate", 1, "Id", CmbID.Text)[0];
            if (date == "") { ChbRentDateNull.Checked = true; }
            else { DtpRentDate.Value = Convert.ToDateTime(date); ChbRentDateNull.Checked = false; }
            date = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "DeliveredDate", 1, "Id", CmbID.Text)[0];
            if (date == "") { ChbDeliveredDateNull.Checked = true; }
            else { DtpDeliveredDate.Value = Convert.ToDateTime(date); ChbDeliveredDateNull.Checked = false; }
            date = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "DeliveryDate", 1, "Id", CmbID.Text)[0];
            if (date == "") { ChbDeliveryDateNull.Checked = true; }
            else { DtpDeliveryDate.Value = Convert.ToDateTime(date); ChbDeliveryDateNull.Checked = false; }
        }

        // Make Null
        private void ChbDateOfBirthNull_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbDateOfBirthNull.Checked == true)
            {
                DtpDateOfBirth.Enabled = false;
            }
            else
            {
                DtpDateOfBirth.Enabled = true;
            }
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

        // METODS
        #region Metods
        void GetValues()
        {
            // Write CmbID
            CmbID.Items.Clear();
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Id"))
            {
                CmbID.Items.Add(item);
            }
            CmbID.SelectedIndex = 0;
            // Write CmbRentedModel
            CmbRentedModel.Items.Clear();
            CmbRentedModel.Items.Add("Boş");
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model"))
            {
                CmbRentedModel.Items.Add(item);
            }
        }

        #endregion
    }
}
