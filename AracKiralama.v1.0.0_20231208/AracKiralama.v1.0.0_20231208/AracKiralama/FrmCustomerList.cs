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
    public partial class FrmCustomerList : Form
    {
        // Class Connection 
        #region Class Connection
        readonly ClsDatabase Database = new ClsDatabase();
        #endregion

        // FORM
        #region Form
        public FrmCustomerList()
        {
            InitializeComponent();
        }
        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            // Write Table To Data Grid View -- Tabloyu Data Grid View'e Yaz
            DgvCustomerList.DataSource = Database.WriteDGV(Database.dbAracKiralama, Database.tbCustomers);
        }
        #endregion
    }
}
