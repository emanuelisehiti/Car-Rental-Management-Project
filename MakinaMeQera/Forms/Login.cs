using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakinaMeQera
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var perdorues = this.txtUName.Text;
            var fjalekalim = this.txtPass.Text;

            if (string.IsNullOrEmpty(perdorues))
            {
                MessageBox.Show("Ju lutem shkruani perdoruesin!", "Makina me qera",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(fjalekalim))
            {
                MessageBox.Show("Ju lutem shkruani fjalekalimin!", "Makina me qera",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPass.Focus();
                return;
            }

            var user = Users.Login(perdorues, fjalekalim);

            if (user)
            {
                Users currentUser = Users.currentUser;
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.Show();
              
            }
            else
            {
                MessageBox.Show("Perdorues ose fjalekalim i gabuar!", "Makina me qera",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUName.Clear();
                this.txtPass.Clear();
            }
        }
    }
}
