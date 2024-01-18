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
    public partial class FrmIdleCarList : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsSqlDatabase Database = new ClsSqlDatabase();
        #endregion

        // FORM
        #region Form
        public FrmIdleCarList()
        {
            InitializeComponent();
        }
        private void FrmIdleCarList_Load(object sender, EventArgs e)
        {
            // Write Table To Data Grid View -- Tabloyu Data Grid View'e Yaz
            DgvIdleCarList.DataSource = Database.WriteDGV(Database.dbAracKiralama, Database.tbCars, 1, "Rented", "0");
        }
        #endregion
    }
}
