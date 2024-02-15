using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using SqlLibrary;

namespace AracKiralama
{
    public partial class FrmLogin : Form
    {

        // Class Connection -- Sınıf Bağlantıları
        #region Class Connection
        readonly SqlDatabase sqlDatabase = new();
        readonly Authentication authentication = new(ConfigurationManager.ConnectionStrings["AracKiralamaConnectionString"].ConnectionString);
        #endregion

        // Form Connection -- Form Bağlantıları
        #region Form Connection
        readonly FrmMain Main = new();
        #endregion

        // FORM 
        #region Form
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            AracKiralama.SqlDatabase.Main = Main;
            Main.Login = this;
        }
        #endregion 

        // BUTTONS
        #region Buttons

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (authentication.Login(sqlDatabase.tbLogin, TxtUsername.Text, TxtPassword.Text))
            {
                TxtPassword.Clear();
                TxtUsername.Clear();
                Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Clear();
                TxtPassword.Focus();
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        // DESIGN
        #region Design

        // Button Design -- Buton Tasarımı
        #region Button Design
        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            BtnLogin.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.BackColor = Color.FromArgb(224,224,224);
        }
        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            BtnExit.BackColor = SystemColors.ActiveBorder;
        }
        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.FromArgb(224, 224, 224);
        }
        #endregion

        #endregion
    }
}
