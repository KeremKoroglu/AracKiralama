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
    public partial class FrmRentedCarList : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsDatabase Database = new ClsDatabase();
        #endregion

        // FORM
        #region Form
        public FrmRentedCarList()
        {
            InitializeComponent();
        }
        private void FrmRentedCarList_Load(object sender, EventArgs e)
        {
            // Write Table To Data Grid View -- Tabloyu Data Grid View'e Yaz
            DgvCarList.DataSource = Database.WriteDGV(Database.dbAracKiralama, Database.tbCars, 1, "Rented", "1");
        }
        #endregion
    }
}
