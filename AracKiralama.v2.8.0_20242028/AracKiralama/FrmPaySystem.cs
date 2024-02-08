using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SqlLibrary;
using static System.Net.Mime.MediaTypeNames;

namespace AracKiralama
{
    public partial class FrmPaySystem : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly SqlDatabase sqlDatabase = new();
        readonly DatabaseManager databaseManager = new(ConfigurationManager.ConnectionStrings["AracKiralamaConnectionString"].ConnectionString);
        readonly ClsTextTools textTools = new ();
        #endregion

        // Form Connection -- Form Bağlantıları
        #region Form Connection
        readonly FrmCarList carList = new();
        #endregion

        // Values
        #region
        float Total = 0;
        readonly float AdditionalDriver = 450;
        readonly float BabyChair = 250;
        byte Page = 0;
        #endregion

        // FORM
        #region Form
        public FrmPaySystem()
        {
            InitializeComponent();
        }
        private void FrmPaySystem_Load(object sender, EventArgs e)
        {
            GetValues();
        }
        private void FrmPaySystem_FormClosing(object sender, FormClosingEventArgs e)
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
        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page == 3)
                {
                    foreach (Control tbp in TbcPaySystem.Controls)
                    {
                        foreach (Control control in tbp.Controls)
                        {
                            if (control is TextBox)
                            {
                                if (string.IsNullOrEmpty(control.Text))
                                {
                                    throw new Exception();
                                }
                            }
                        }

                    }

                    foreach (Control tbp in TbcPaySystem.Controls)
                    {
                        foreach (Control control in tbp.Controls)
                        {
                            if (control is ComboBox)
                            {
                                if (string.IsNullOrEmpty(control.Text))
                                {
                                    throw new Exception();
                                }
                            }
                        }

                    }

                    foreach (Control tbp in TbcPaySystem.Controls)
                    {
                        foreach (Control control in tbp.Controls)
                        {
                            if (control is DateTimePicker)
                            {
                                if (string.IsNullOrEmpty(control.Text))
                                {
                                    throw new Exception();
                                }
                            }
                        }

                    }

                    foreach (Control tbp in TbcPaySystem.Controls)
                    {
                        foreach (Control control in tbp.Controls)
                        {
                            if (control is MaskedTextBox)
                            {
                                if (string.IsNullOrEmpty(control.Text))
                                {
                                    throw new Exception();
                                }
                            }
                        }

                    }
                    // Ödeme
                }
                else
                {
                    if (Page == 1 && CmbCustomers.SelectedIndex == -1)
                    {
                        MessageBox.Show("Lütfen Bir Müşteri Seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (Page == 1)
                        {
                            Total += Convert.ToInt32(databaseManager.GetColumn(sqlDatabase.tbCars, "Price", ("Model", CmbCars.Text))[0]);
                            TxtTotal.Text = Total + "₺";
                        }

                        if (Page == 2)
                        {
                            if (ChbAdditionalDriver.Checked && !ChbBabyChair.Checked)
                            {
                                LblInfo.Text = $"Şu anda {CmbCars.Text} modelini Şoför ile beraber kiralıyorsunuz. Toplam {Total}₺";
                            }
                            else if (ChbBabyChair.Checked && !ChbAdditionalDriver.Checked)
                            {
                                LblInfo.Text = $"Şu anda {CmbCars.Text} modelini Bebek Koltuğu ile beraber kiralıyorsunuz. Toplam {Total}₺";
                            }
                            else if (ChbAdditionalDriver.Checked && ChbBabyChair.Checked)
                            {
                                LblInfo.Text = $"Şu anda {CmbCars.Text} modelini Şoför ve Bebek Koltuğu ile beraber kiralıyorsunuz. Toplam {Total}₺";
                            }
                            else
                            {
                                LblInfo.Text = $"Şu anda {CmbCars.Text} modelini hiçbir ek ürün satın almadan kiralıyorsunuz. Toplam {Total}₺";
                            }
                        }

                        Page += 1;
                        TbcPaySystem.SelectedIndex = Page;
                        BtnClose.Text = "Geri";
                    }
                }

                if (Page == 3)
                {
                    BtnNext.Text = "Ödeme Yap";
                }
            }
            catch
            {
                MessageBox.Show("Tüm Bilgileri Doldurduğunuzdan Emin Olun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (Page == 0)
            {
                this.Close();
            }
            else
            {
                if (Page == 2)
                {
                    Total -= Convert.ToInt32(databaseManager.GetColumn(sqlDatabase.tbCars, "Price", ("Model", CmbCars.Text))[0]);
                    TxtTotal.Text = Total + "₺";
                }

                Page -= 1;
                TbcPaySystem.SelectedIndex = Page;
                BtnNext.Text = "İlerle";
            }

            if (Page == 0)
            {
                BtnClose.Text = "Kapat";
            }
        }
        #endregion

        // LINKLABEL
        #region LinkLabel
        private void LlbCarList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            carList.Show();
        }

        private void LlbAddCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        #endregion

        // CHECKBOX
        #region CheckBox
        private void ChbAdditionalDriver_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbAdditionalDriver.Checked)
            {
                Total += AdditionalDriver;
                TxtTotal.Text = Total.ToString() + "₺";
            }
            else
            {
                Total -= AdditionalDriver;
                TxtTotal.Text = Total.ToString() + "₺";
            }
        }
        private void ChbBabyChair_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbBabyChair.Checked)
            {
                Total += BabyChair;
                TxtTotal.Text = Total.ToString() + "₺";
            }
            else
            {
                Total -= BabyChair;
                TxtTotal.Text = Total.ToString() + "₺";
            }
        }
        #endregion

        // METODS
        #region Metods
        void GetValues()
        {
            // TbpPickUpDropOff
            CmbPickUpOffice.SelectedIndex = 0;
            CmbDropOffOffice.SelectedIndex = 0;
            MtbPickUpTime.Text = DateTime.Now.ToShortTimeString();
            // TbpCarSelection
            CmbCars.Items.Clear();
            foreach (var item in databaseManager.GetColumn(sqlDatabase.tbCars, "Model", ("Rented", "0")))
            {
                CmbCars.Items.Add(item);
            }
            CmbCars.SelectedIndex = 0;
            CmbCustomers.Items.Clear();
            foreach (var item in databaseManager.GetColumn(sqlDatabase.tbCustomers, "Name", ("Renter", "0")))
            {
                CmbCustomers.Items.Add(item + " " + databaseManager.GetColumn(sqlDatabase.tbCustomers, "Surname", ("Name", item))[0]);
            }
        }
        #endregion

        // DESIGN 
        #region Design
        private void CmbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtPrice.Text = databaseManager.GetColumn(sqlDatabase.tbCars, "Price", ("Model", CmbCars.Text))[0] + "₺";
        }
        private void CmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = textTools.GetBeforeSpace(CmbCustomers.Text);
            string surname = textTools.GetAfterSpace(CmbCustomers.Text);
            TxtName.Text = name;
            TxtSurname.Text = surname;
            DtpDateOfBirth.Value = Convert.ToDateTime(databaseManager.GetColumn(sqlDatabase.tbCustomers, "DateOfBirth", ("Name", name), ("Surname", surname))[0]);
            MtbTckn.Text = databaseManager.GetColumn(sqlDatabase.tbCustomers, "Tckn", ("Name", name), ("Surname", surname))[0];
            MtbNumber.Text = databaseManager.GetColumn(sqlDatabase.tbCustomers, "Number", ("Name", name), ("Surname", surname))[0];
            TxtMail.Text = databaseManager.GetColumn(sqlDatabase.tbCustomers, "Mail", ("Name", name), ("Surname", surname))[0];
        }
        #endregion

        private void TbcPaySystem_Click(object sender, EventArgs e)
        {
            TbcPaySystem.SelectedIndex = Page;
        }
    }
}
