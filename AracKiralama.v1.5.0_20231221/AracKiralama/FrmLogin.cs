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
        readonly ClsSqlDatabase Database = new ClsSqlDatabase();
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
        #endregion 

        // BUTTONS
        #region Buttons
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Database.Login(Database.dbAracKiralama, Database.tbLogin, TxtUsername.Text, TxtPassword.Text))
            {
                Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Clear();
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
        #region
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
