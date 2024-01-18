using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AracKiralama
{
    public partial class FrmMain : Form
    {
        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly ClsSqlDatabase SqlDatabase = new ClsSqlDatabase();
        #endregion
        
        // Form Connection -- Form Bağlantıları
        #region Form Connection
        readonly FrmCarList CarList = new FrmCarList();
        readonly FrmIdleCarList IdleCarList = new FrmIdleCarList();
        readonly FrmRentedCarList RentedCarList = new FrmRentedCarList();
        readonly FrmCustomerList CustomerList = new FrmCustomerList();
        readonly FrmRenterCustomersList RenterCustomerList = new FrmRenterCustomersList();
        readonly FrmAddCar AddCar = new FrmAddCar();
        readonly FrmRentCar RentCar = new FrmRentCar();
        readonly FrmEditCars EditCars = new FrmEditCars();
        readonly FrmEditCustomers EditCustomers = new FrmEditCustomers();
        #endregion

        // FORM
        #region Form
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Get Interface -- Arayüzü Getir
            RefreshCarInfo();
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        // BUTTONS
        #region Buttons
        private void BtnCarList_Click(object sender, EventArgs e)
        {
            CarList.ShowDialog();
        }
        private void BtnIdleCarList_Click(object sender, EventArgs e)
        {
            IdleCarList.ShowDialog();
        }
        private void BtnRentedCarList_Click(object sender, EventArgs e)
        {
            RentedCarList.ShowDialog();
        }        
        private void BtnCustomerList_Click(object sender, EventArgs e)
        {
            CustomerList.ShowDialog();
        }
        private void BtnRenterCustomerList_Click(object sender, EventArgs e)
        {
            RenterCustomerList.ShowDialog();
        }
        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            AddCar.ShowDialog();
        }
        private void BtnRentCar_Click(object sender, EventArgs e)
        {
            RentCar.ShowDialog();
        }
        private void BtnEditCars_Click(object sender, EventArgs e)
        {
            EditCars.ShowDialog();
        }
        private void BtnEditCustomers_Click(object sender, EventArgs e)
        {
            EditCustomers.ShowDialog();
        }
        #endregion

        void RefreshCarInfo()
        {
            // Bu değer toplam satır sayısından alındı
            LblTotalCar.Text = "Toplam Araba : " + SqlDatabase.ColumnCount(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars);
            LblIdleCar.Text = "Boşta Araba : " + SqlDatabase.ColumnCount(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "=", 1, "Rented", "0");
            LblRentedCar.Text = "Kiralanan Araba : " + SqlDatabase.ColumnCount(SqlDatabase.dbAracKiralama, SqlDatabase.tbCars, "=", 1, "Rented", "1");
        }
    }
}
