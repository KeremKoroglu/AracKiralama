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
    public partial class FrmAddCar : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsSqlDatabase Database = new ClsSqlDatabase();
        readonly ClsAracKiralamaDatabase AracKiralamaDatabase = new ClsAracKiralamaDatabase();
        #endregion

        // Form Connection -- Form Bağlantıları
        #region Form Connection

        #endregion

        // FORM 
        #region FORM
        public FrmAddCar()
        {
            InitializeComponent();
        }
        private void FrmEditCar_Load(object sender, EventArgs e)
        {
            CmbSeat.SelectedIndex = 1;
        }
        #endregion

        // BUTTON
        #region BUTTON
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TbcEditCar.SelectedIndex == 0)
            {
                AracKiralamaDatabase.WriteCarTable(TxtPrice.Text, TxtModel.Text, TxtKm.Text, CmbSeat.Text, ChbAutoGear.Checked.ToString(), ChbDamaged.Checked.ToString(), RtbDescription.Text, ChbRented.Checked.ToString(), TxtRenter.Text, DtpRentDate.Value.ToString("yyyyMMdd"), ChbDelivered.Checked.ToString(), DtpDeliveredDate.Value.ToString("yyyyMMdd"), DtpDeliveryDate.Value.ToString("yyyyMMdd"));
            }
            else if (TbcEditCar.SelectedIndex == 1)
            {         
                Database.DeleteColumn(Database.dbAracKiralama, Database.tbCars, CmbCondition.Text, TxtValue.Text); 
            }
        }
        #endregion

        // Null Ekleme
        private void ChbRentDateNull_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
