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
    public partial class FrmEditCar : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        ClsSqlDatabase Database = new ClsSqlDatabase();
        ClsAracKiralamaDatabase AracKiralamaDatabase = new ClsAracKiralamaDatabase();
        #endregion

        // Form Connection -- Form Bağlantıları
        #region Form Connection

        #endregion

        // FORM 
        #region FORM
        public FrmEditCar()
        {
            InitializeComponent();
        }
        #endregion

        // BUTTON
        #region BUTTON
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TbcEditCar.SelectedIndex == 0)
            {
                try
                {
                    AracKiralamaDatabase.WriteCarTable(TxtPrice.Text, TxtModel.Text, TxtKm.Text, CmbSeat.Text, ChbAutoGear.Checked.ToString(), ChbDamaged.Checked.ToString(), RtbDescription.Text, ChbRented.Checked.ToString(), TxtRenter.Text, DtpRentDate.Value.ToString("yyyyMMdd"), ChbDelivered.Checked.ToString(), DtpDeliveredDate.Value.ToString("yyyyMMdd"), DtpDeliveryDate.Value.ToString("yyyyMMdd"));
                    MessageBox.Show("Araç başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Error)
                {
                    MessageBox.Show("Araç kaydı başarısız. \n" + Error.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (TbcEditCar.SelectedIndex == 1)
            {         
                try
                {
                    Database.DeleteColumn(Database.dbAracKiralama, Database.tbCars, CmbCondition.Text, TxtValue.Text); 
                    MessageBox.Show("Araç başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Error)
                {
                    MessageBox.Show("Araç silme başarısız. \n" + Error.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
