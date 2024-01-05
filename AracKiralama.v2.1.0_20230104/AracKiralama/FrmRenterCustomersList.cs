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
    public partial class FrmRenterCustomersList : Form
    {
        // Class Connection 
        #region Class Connection
        readonly ClsSqlDatabase Database = new ClsSqlDatabase();
        #endregion

        // FORM
        #region Form
        public FrmRenterCustomersList()
        {
            InitializeComponent();
        }
        private void FrmRenterCustomersList_Load(object sender, EventArgs e)
        {
            // Write Table To Data Grid View -- Tabloyu Data Grid View'e Yaz
            DgvCustomerList.DataSource = Database.WriteDGV(Database.dbAracKiralama, Database.tbCustomers, 1, "Renter", "1");
        }
        #endregion
    }
}
