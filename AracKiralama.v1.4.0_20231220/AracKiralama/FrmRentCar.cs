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
            CmbModel.Items.Clear();
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", 1, "Rented", "0"))
            {
                CmbModel.Items.Add(item);
            }
            CmbModel.SelectedIndex = 0;
            // Write CmbRecallModel
            CmbRecallModel.Items.Clear();
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", 1, "Rented", "1"))
            {
                CmbRecallModel.Items.Add(item);
            }
            CmbRecallModel.SelectedIndex = 0;
            // Write CmbRenter
            CmbRenter.Items.Clear();    
            string[] Names = new string[SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", 1, "Renter", "0").Length];
            int i = 0;
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", 1, "Renter", "0"))
            {
                Names[i] = item;
                i++;
            }
            string[] Surnames = new string[SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname", 1, "Renter", "0").Length];
            i = 0;
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname", 1, "Renter", "0"))
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
            string[] RecallNames = new string[SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", 1, "Renter", "1").Length];
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", 1, "Renter", "1"))
            {
                RecallNames[i] = item;
                i++;
            }
            string[] RecallSurnames = new string[SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname", 1, "Renter", "1").Length];
            i = 0;
            foreach (string item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname", 1, "Renter", "1"))
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
                AracKiralamaDatabase.RecallCar(ChbDamaged.Checked.ToString(), RtbDescription.Text, DtpDeliveredDate.Value.ToString("yyyyMMdd"), CmbRecallModel.Text, CmbRecallRenter.Text);
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
        private void CmbRecallModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Name", 1, "RentedModel", "'" + CmbRecallModel.Text + "'")[0];
            string surname = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCustomers, "Surname", 1, "RentedModel", "'" + CmbRecallModel.Text + "'")[0];
            CmbRecallRenter.SelectedItem = name + " " + surname;
            RtbRecallDescription.Clear();
            RtbRecallDescription.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Description", 1, "Renter", "'" + (name + " " + surname) + "'")[0];
            TxtKm.Text = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Km", 1, "Renter", "'" + (name + " " + surname) + "'")[0];
            ChbDamaged.Checked = Convert.ToBoolean(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Damaged", 1, "Renter", "'" + (name + " " + surname) + "'")[0]);
            DtpRecallDeliveryDate.Value = Convert.ToDateTime(SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "DeliveryDate", 1, "Renter", "'" + (name + " " + surname) + "'")[0]);
        }
        private void CmbRecallRenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string model = SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", 1, "Renter", "'" + CmbRecallRenter.Text + "'")[0];
            CmbRecallModel.SelectedItem = model;
        }
        #endregion
    }
}
