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
    public partial class FrmPaySystem : Form
    {
        // FORM
        #region Form
        public FrmPaySystem()
        {
            InitializeComponent();
        }
        // Load
        private void FrmPaySystem_Load(object sender, EventArgs e)
        {

        }
        // Closing
        private void FrmPaySystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                this.Hide();
                e.Cancel = true;
            }
        }
        #endregion
    }
}
