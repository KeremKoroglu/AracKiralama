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
    public partial class FrmRentCar : Form
    {
        // Class Connection
        ClsSqlDatabase SqlDatabase = new ClsSqlDatabase();

        public FrmRentCar()
        {
            InitializeComponent();
        }

        private void FrmRentCar_Load(object sender, EventArgs e)
        {
            // Write CmbModel
            foreach (var item in SqlDatabase.GetColumn(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "Model", 1, "Rented", "0"))
            {
                CmbModel.Items.Add(item);
            }
        }
    }
}
