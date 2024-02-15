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
    public partial class FrmRentCar : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly SqlDatabase sqlDatabase = new();
        readonly SqlDatabase AracKiralamaDatabase = new();
        readonly DatabaseManager DatabaseManage = new(ConfigurationManager.ConnectionStrings["AracKiralamaConnectionString"].ConnectionString);
        #endregion

        // Values -- Değişkenler
        #region Values
        readonly int maxChar = 50;
        #endregion

        // FORM
        #region Form
        public FrmRentCar()
        {
            InitializeComponent();
        }
        private void FrmRentCar_Load(object sender, EventArgs e)
        {
            GetValues();

            // Object Arrangements -- Nesne Düzenlemeleri
            RtbDescription.MaxLength = maxChar;
            RtbRecallDescription.MaxLength = maxChar;
        }
        private void FrmRentCar_FormClosing(object sender, FormClosingEventArgs e)
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
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Rent
            if (TbcRentCar.SelectedIndex == 0)
            {
                AracKiralamaDatabase.UpdateCar(CmbModel.Text, CmbRenter.Text, RtbDescription.Text, DtpRentDate.Value.ToString("yyyyMMdd"), DtpDeliveryDate.Value.ToString("yyyyMMdd"));             
            }
            else if (TbcRentCar.SelectedIndex == 1)
            {
                AracKiralamaDatabase.RecallCar(TxtKm.Text, ChbDamaged.Checked.ToString(), RtbRecallDescription.Text, DtpDeliveredDate.Value.ToString("yyyyMMdd"), CmbRecallModel.Text);
            }

            GetValues();
            AracKiralamaDatabase.RefreshCarInfo();
        }

        #endregion

        // DESIGN
        #region Design

        // Value Edit
        #region Value Edit
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
        private void CmbRecallModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name", ("RentedModel", CmbRecallModel.Text))[0];
            string surname = DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname", ("RentedModel", CmbRecallModel.Text))[0];
            CmbRecallRenter.SelectedItem = name + " " + surname;
            RtbRecallDescription.Clear();
            RtbRecallDescription.Text = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Description", ("Renter", (name + " " + surname)))[0];
            TxtKm.Text = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Km", ("Renter", (name + " " + surname)))[0];
            ChbDamaged.Checked = Convert.ToBoolean(DatabaseManage.GetColumn(sqlDatabase.tbCars, "Damaged", ("Renter", (name + " " + surname)))[0]);
            DtpRecallDeliveryDate.Value = DatabaseManage.GetColumn(sqlDatabase.tbCars, "DeliveryDate", ("Renter", "'" + (name + " " + surname) + "'"))[0] == null ? DateTime.Now : Convert.ToDateTime(DatabaseManage.GetColumn(sqlDatabase.tbCars, "DeliveryDate", ("Renter", "'" + (name + " " + surname) + "'"))[0]);
        }
        private void CmbRecallRenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string model = DatabaseManage.GetColumn(sqlDatabase.tbCars, "Model", ("Renter", CmbRecallRenter.Text))[0];
            CmbRecallModel.SelectedItem = model;
        }   
        #endregion
        // Only Number
        #region Only Number
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
            // Write CmbModel
            CmbModel.Items.Clear();
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCars, "Model",("Rented", "0")))
            {
                CmbModel.Items.Add(item);
            }
            CmbModel.SelectedIndex = 0;
            // Write CmbRecallModel
            CmbRecallModel.Items.Clear();
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCars, "Model", ("Rented", "1")))
            {
                CmbRecallModel.Items.Add(item);
            }
            CmbRecallModel.SelectedIndex = 0;
            // Write CmbRenter
            CmbRenter.Items.Clear();
            string[] Names = new string[DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name", ("Renter", "0")).Length];
            int i = 0;
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name", ("Renter", "0")))
            {
                Names[i] = item;
                i++;
            }
            string[] Surnames = new string[DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname", ("Renter", "0")).Length];
            i = 0;
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname", ("Renter", "0")))
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
            CmbRenter.SelectedIndex = 0;
            // Write CmbRecallRenter
            CmbRecallRenter.Items.Clear();
            string[] RecallNames = new string[DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name", ("Renter", "1")).Length];
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Name", ("Renter", "1")))
            {
                RecallNames[i] = item;
                i++;
            }
            string[] RecallSurnames = new string[DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname", ("Renter", "1")).Length];
            i = 0;
            foreach (string item in DatabaseManage.GetColumn(sqlDatabase.tbCustomers, "Surname", ("Renter", "1")))
            {
                RecallSurnames[i] = item;
                i++;
            }
            i = 0;
            foreach (string item in RecallNames)
            {
                CmbRecallRenter.Items.Add(item + " " + RecallSurnames[i]);
                i++;
            }
            CmbRecallRenter.SelectedIndex = 0;
            // Edit Date Time Picker 
            DtpDeliveryDate.Value = DateTime.Now.AddDays(7);
        }
        #endregion
    }
}
