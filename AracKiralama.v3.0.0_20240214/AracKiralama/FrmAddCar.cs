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
using System.Configuration;
using SqlLibrary;

namespace AracKiralama
{
    public partial class FrmAddCar : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly SqlDatabase sqlDatabase = new();
        readonly DatabaseManager DatabaseManage = new(ConfigurationManager.ConnectionStrings["AracKiralamaConnectionString"].ConnectionString);
        #endregion

        // Values -- Değişkenler
        #region Values
        readonly int maxChar = 50;
        #endregion

        // FORM 
        #region FORM
        public FrmAddCar()
        {
            InitializeComponent();
        }
        private void FrmEditCar_Load(object sender, EventArgs e)
        {
            DgvCarList.DataSource = DatabaseManage.GetTable(sqlDatabase.tbCars);

            // Object Arrangements -- Nesne Düzenlemeleri
            CmbSeat.SelectedIndex = 1;
            TxtModel.MaxLength = maxChar;
            TxtRenter.MaxLength = maxChar;
            RtbDescription.MaxLength = maxChar;
        }
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Add Car
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
                    string rentDate = ChbRentDateNull.Checked ? null : DtpRentDate.Value.ToString("yyyyMMdd");
                    string deliveredDate = ChbDeliveredDateNull.Checked ? null : DtpDeliveredDate.Value.ToString("yyyyMMdd");
                    string deliveryDate = ChbDeliveryDateNull.Checked ? null : DtpDeliveryDate.Value.ToString("yyyyMMdd");
                    sqlDatabase.AddCar(TxtPrice.Text, TxtModel.Text, TxtKm.Text, CmbSeat.Text, ChbAutoGear.Checked.ToString(), ChbDamaged.Checked.ToString(), RtbDescription.Text, ChbRented.Checked.ToString(), TxtRenter.Text, rentDate, ChbDelivered.Checked.ToString(), deliveredDate, deliveryDate);
                }
            }
            // Delete Car
            else if (TbcEditCar.SelectedIndex == 1)
            {
                if (DgvCarList.CurrentCell != null)
                {
                    int rowIndex = DgvCarList.CurrentCell.RowIndex;

                    if (rowIndex >= 0 && rowIndex < DgvCarList.Rows.Count)
                    {
                        DataGridViewRow selectedRow = DgvCarList.Rows[rowIndex];
                        string id = selectedRow.Cells["ıdDataGridViewTextBoxColumn"].Value.ToString();
                        DatabaseManage.DeleteColumn(sqlDatabase.tbCars, ("Id", id));
                        MessageBox.Show("Araba Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            sqlDatabase.RefreshCarInfo();
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

        private void TbcEditCar_MouseClick(object sender, MouseEventArgs e)
        {
            if (TbcEditCar.SelectedIndex == 0)
            {
                BtnSave.Text = "Kaydet";
            }
            else
            {
                BtnSave.Text = "Sil";
            }
        }
        #endregion

        // Table Design (Zebra Striping)
        #region Table Design
        private void DgvCarList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        #endregion

        #endregion
    }
}
