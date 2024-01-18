using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AracKiralama
{
    public partial class FrmAddCar : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsSqlDatabase SqlDatabase = new ClsSqlDatabase();
        readonly ClsAracKiralamaDatabase AracKiralamaDatabase = new ClsAracKiralamaDatabase();
        #endregion

        // Values
        #region Values
        readonly int maxChar = 50;
        #endregion

        // FORM 
        #region FORM
        public FrmAddCar()
        {
            InitializeComponent();
        }
        // Load
        private void FrmEditCar_Load(object sender, EventArgs e)
        {
            CmbSeat.SelectedIndex = 1;
        }
        // Closing
        private void FrmAddCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                this.Hide();
                e.Cancel = true;
            }
        }
        #endregion

        // BUTTON
        #region BUTTON

        // Close
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        // Save
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TbcEditCar.SelectedIndex == 0)
            {
                if (TxtPrice.Text == "")
                {
                    MessageBox.Show("Fiyat kısmı boş bırakılamaz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtModel.Text == "")
                {
                    MessageBox.Show("Model kısmı boş bırakılamaz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string rentDate = ChbRentDateNull.Checked ? "NULL" : "'" + DtpRentDate.Value.ToString("yyyyMMdd") + "'";
                    string deliveredDate = ChbDeliveredDateNull.Checked ? "NULL" : "'" + DtpDeliveredDate.Value.ToString("yyyyMMdd") + "'";
                    string deliveryDate = ChbDeliveryDateNull.Checked ? "NULL" : "'" + DtpDeliveryDate.Value.ToString("yyyyMMdd") + "'";
                    AracKiralamaDatabase.WriteCarTable(TxtPrice.Text, TxtModel.Text, TxtKm.Text, CmbSeat.Text, ChbAutoGear.Checked.ToString(), ChbDamaged.Checked.ToString(), RtbDescription.Text, ChbRented.Checked.ToString(), TxtRenter.Text, rentDate, ChbDelivered.Checked.ToString(), deliveredDate, deliveryDate);
                }
            }
            else if (TbcEditCar.SelectedIndex == 1)
            {         
                SqlDatabase.DeleteColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, CmbCondition.Text, TxtValue.Text); 
            }
        }
        #endregion

        // DESIGN
        #region DESIGN

        // Value Edit -- Değer Düzenleme
        #region Value Edit
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
        // Value Limit -- Değer Limiti
        #region Value Limit
        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtPrice.Text) && !int.TryParse(TxtPrice.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir tamsayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TxtModel_TextChanged(object sender, EventArgs e)
        {
            if (TxtModel.Text.Length > maxChar)
            {
                MessageBox.Show("Girilen değer 50 karakter sınırını aşıyor", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtModel.Text = TxtModel.Text.Substring(0, maxChar);
                TxtModel.SelectionStart = TxtModel.Text.Length;
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
            if (TxtRenter.Text.Length > maxChar)
            {
                MessageBox.Show("Girilen değer 50 karakter sınırını aşıyor", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRenter.Text = TxtRenter.Text.Substring(0, maxChar);
                TxtRenter.SelectionStart = TxtRenter.Text.Length;
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
        // Button Design -- Buton Tasarımı
        #region Button Design

        // Save
        private void BtnSave_MouseEnter(object sender, EventArgs e)
        {
            BtnSave.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnSave_MouseLeave(object sender, EventArgs e)
        {
            BtnSave.BackColor = Color.FromArgb(224, 224, 224);
        }
        // Close
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
        #endregion
    }
}
