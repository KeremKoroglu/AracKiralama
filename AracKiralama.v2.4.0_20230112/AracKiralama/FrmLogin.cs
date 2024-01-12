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

namespace AracKiralama
{
    public partial class FrmLogin : Form
    {

        // Class Connection
        #region Class Connection
        readonly ClsSqlDatabase SqlDatabase = new ClsSqlDatabase();
        #endregion

        // Form Connection
        #region Form Connection
        readonly FrmMain Main = new FrmMain();
        #endregion

        // FORM 
        #region Form
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Main.Login = this;
        }
        #endregion 

        // BUTTONS
        #region Buttons
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (SqlDatabase.Login(SqlDatabase.dbAracKiralama, SqlDatabase.tbLogin, TxtUsername.Text, TxtPassword.Text))
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

        private void button1_Click(object sender, EventArgs e)
        {
            Main.Show();
            this.Hide();
        }
    }
}
