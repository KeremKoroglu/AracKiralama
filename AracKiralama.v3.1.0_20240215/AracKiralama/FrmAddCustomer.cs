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

namespace AracKiralama
{
    public partial class FrmAddCustomer : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly SqlDatabase sqlDatabase = new();
        readonly DatabaseManager databaseManager = new(ConfigurationManager.ConnectionStrings["AracKiralamaConnectionString"].ConnectionString);
        #endregion

        // FORM
        #region Form
        public FrmAddCustomer()
        {
            InitializeComponent();
        }
        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            GetValues();
        }
        private void FrmAddCustomer_FormClosing(object sender, FormClosingEventArgs e)
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
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Add Customer
            if (TbcAddCustomer.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(TxtName.Text))
                {
                    MessageBox.Show("İsim kısmı boş bırakılamaz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(TxtSurname.Text))
                {
                    MessageBox.Show("Soyisim kısmı boş bırakılamaz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(TxtTckn.Text))
                {
                    MessageBox.Show("Tckn kısmı boş bırakılamaz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(TxtNumber.Text))
                {
                    MessageBox.Show("Telefon kısmı boş bırakılamaz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string rentedModel = CmbRentedModel.Text == "Yok" ? null : CmbRentedModel.Text;
                    string rentDate = ChbRentDateNull.Checked ? null : DtpRentDate.Value.ToString("yyyyMMdd");
                    string deliveredDate = ChbDeliveredDateNull.Checked ? null : DtpDeliveredDate.Value.ToString("yyyyMMdd");
                    string deliveryDate = ChbDeliveryDateNull.Checked ? null : DtpDeliveryDate.Value.ToString("yyyyMMdd");

                    sqlDatabase.AddCustomer(TxtName.Text, TxtSurname.Text, DtpDateOfBirth.Value.ToString("yyyyMMdd"), TxtTckn.Text, TxtNumber.Text, TxtMail.Text, ChbRenter.Checked.ToString(), rentedModel, rentDate, ChbDelivered.Checked.ToString(), deliveredDate, deliveryDate);
                }
            }
            // Delete Customer
            else if (TbcAddCustomer.SelectedIndex == 1)
            {
                if (DgvCustomerList.CurrentCell != null)
                {
                    int rowIndex = DgvCustomerList.CurrentCell.RowIndex;

                    if (rowIndex >= 0 && rowIndex < DgvCustomerList.Rows.Count)
                    {
                        DataGridViewRow selectedRow = DgvCustomerList.Rows[rowIndex];
                        string id = selectedRow.Cells["ıdDataGridViewTextBoxColumn"].Value.ToString();
                        databaseManager.DeleteColumn(sqlDatabase.tbCustomers, ("Id", id));
                        MessageBox.Show("Müşteri Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }            
            }

            GetValues();
            sqlDatabase.RefreshCarInfo();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        // METODS
        #region Metods
        void GetValues()
        {
            DgvCustomerList.DataSource = databaseManager.GetTable(sqlDatabase.tbCustomers);

            CmbRentedModel.Items.Clear();
            CmbRentedModel.Items.Add("Yok");
            foreach (var item in databaseManager.GetColumn(sqlDatabase.tbCars, "Model", ("Rented", "0")))
            {
                CmbRentedModel.Items.Add(item);
            }
            CmbRentedModel.SelectedIndex = 0;
        }
        #endregion

        // DESIGN
        #region Design

        // Make Null
        private void ChbRentDateNull_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbRentDateNull.Checked)
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
            if (ChbDeliveredDateNull.Checked)
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
            if (ChbDeliveryDateNull.Checked)
            {
                DtpDeliveryDate.Enabled = false;
            }
            else
            {
                DtpDeliveryDate.Enabled = true;
            }
        }

        // Change Text
        private void TbcAddCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            if (TbcAddCustomer.SelectedIndex == 1)
            {
                BtnSave.Text = "Sil";
            }
            else
            {
                BtnSave.Text = "Kaydet";
            }
        }

        // Table Design
        private void DgvCustomerList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        // Button Design
        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void BtnSave_MouseEnter(object sender, EventArgs e)
        {
            BtnSave.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnSave_MouseLeave(object sender, EventArgs e)
        {
            BtnSave.BackColor = Color.FromArgb(224, 224, 224);
        }
        #endregion
    }
}
