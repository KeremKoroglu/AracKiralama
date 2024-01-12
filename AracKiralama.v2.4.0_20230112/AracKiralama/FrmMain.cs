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
        public FrmLogin Login;
        readonly FrmCarList CarList = new FrmCarList();
        readonly FrmIdleCarList IdleCarList = new FrmIdleCarList();
        readonly FrmRentedCarList RentedCarList = new FrmRentedCarList();
        readonly FrmCustomerList CustomerList = new FrmCustomerList();
        readonly FrmRenterCustomersList RenterCustomerList = new FrmRenterCustomersList();
        readonly FrmAddCar AddCar = new FrmAddCar();
        readonly FrmRentCar RentCar = new FrmRentCar();
        readonly FrmEditCars EditCars = new FrmEditCars();
        readonly FrmEditCustomers EditCustomers = new FrmEditCustomers();
        readonly FrmPaySystem PaySystem = new FrmPaySystem();
        #endregion

        // FORM
        #region Form
        public FrmMain()
        {
            InitializeComponent();
        }
        // Load
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Get Interface -- Arayüzü Getir
            RefreshCarInfo();
        }
        // Closed
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        // BUTTONS
        #region Buttons
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Login.Show();
            this.Hide();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnCarList_Click(object sender, EventArgs e)
        {
            CarList.Show();
        }
        private void BtnIdleCarList_Click(object sender, EventArgs e)
        {
            IdleCarList.Show();
        }
        private void BtnRentedCarList_Click(object sender, EventArgs e)
        {
            RentedCarList.Show();
        }        
        private void BtnCustomerList_Click(object sender, EventArgs e)
        {
            CustomerList.Show();
        }
        private void BtnRenterCustomerList_Click(object sender, EventArgs e)
        {
            RenterCustomerList.Show();
        }
        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            AddCar.Show();
        }
        private void BtnRentCar_Click(object sender, EventArgs e)
        {
            RentCar.Show();
        }
        private void BtnEditCars_Click(object sender, EventArgs e)
        {
            EditCars.Show();
        }
        private void BtnEditCustomers_Click(object sender, EventArgs e)
        {
            EditCustomers.Show();
        }
        private void BtnPaySystem_Click(object sender, EventArgs e)
        {
            PaySystem.Show();
        }

        #endregion

        // DESIGN
        #region Design

        // Button Design -- Buton Tasarımı
        #region Button Design

        // Back
        private void BtnBack_MouseEnter(object sender, EventArgs e)
        {
            BtnBack.BackColor = Color.Gray;
        }
        private void BtnBack_MouseLeave(object sender, EventArgs e)
        {
            BtnBack.BackColor = SystemColors.ActiveBorder;
        }
        // Exit
        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.Gray;
        }
        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.BackColor = SystemColors.ActiveBorder;
        }
        // Car List
        private void BtnCarList_MouseEnter(object sender, EventArgs e)
        {
            BtnCarList.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnCarList_MouseLeave(object sender, EventArgs e)
        {
            BtnCarList.BackColor = Color.FromArgb(224, 224, 224);
        }
        // Idle Car List
        private void BtnIdleCarList_MouseEnter(object sender, EventArgs e)
        {
            BtnIdleCarList.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnIdleCarList_MouseLeave(object sender, EventArgs e)
        {
            BtnIdleCarList.BackColor = Color.FromArgb(224, 224, 224);
        }
        // Rented Car List
        private void BtnRentedCarList_MouseEnter(object sender, EventArgs e)
        {
            BtnRentedCarList.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnRentedCarList_MouseLeave(object sender, EventArgs e)
        {
            BtnRentedCarList.BackColor = Color.FromArgb(224, 224, 224);
        }
        // Customer List
        private void BtnCustomerList_MouseEnter(object sender, EventArgs e)
        {
            BtnCustomerList.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnCustomerList_MouseLeave(object sender, EventArgs e)
        {
            BtnCustomerList.BackColor = Color.FromArgb(224, 224, 224);
        }
        // Renter Customers
        private void BtnRenterCustomers_MouseEnter(object sender, EventArgs e)
        {
            BtnRenterCustomers.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnRenterCustomers_MouseLeave(object sender, EventArgs e)
        {
            BtnRenterCustomers.BackColor = Color.FromArgb(224, 224, 224);
        }
        // Add Car
        private void BtnAddCar_MouseEnter(object sender, EventArgs e)
        {
            BtnAddCar.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnAddCar_MouseLeave(object sender, EventArgs e)
        {
            BtnAddCar.BackColor = Color.FromArgb(224, 224, 224);
        }
        // Rent Car
        private void BtnRentCar_MouseEnter(object sender, EventArgs e)
        {
            BtnRentCar.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnRentCar_MouseLeave(object sender, EventArgs e)
        {
            BtnRentCar.BackColor = Color.FromArgb(224, 224, 224);
        }
        // Edit Cars
        private void BtnEditCars_MouseEnter(object sender, EventArgs e)
        {
            BtnEditCars.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnEditCars_MouseLeave(object sender, EventArgs e)
        {
            BtnEditCars.BackColor = Color.FromArgb(224, 224, 224);
        }
        // Edit Customers
        private void BtnEditCustomers_MouseEnter(object sender, EventArgs e)
        {
            BtnEditCustomers.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnEditCustomers_MouseLeave(object sender, EventArgs e)
        {
            BtnEditCustomers.BackColor = Color.FromArgb(224, 224, 224);
        }
        // Pay System
        private void BtnPaySystem_MouseEnter(object sender, EventArgs e)
        {
            BtnPaySystem.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnPaySystem_MouseLeave(object sender, EventArgs e)
        {
            BtnPaySystem.BackColor = Color.FromArgb(224, 224, 224);
        }

        #endregion

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
