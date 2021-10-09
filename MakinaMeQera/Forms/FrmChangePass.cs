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
    public partial class FrmChangePass : Form
    {
        public FrmChangePass()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ri = Utils.GetStringSha256Hash(txtNew.Text);
            string perserit = Utils.GetStringSha256Hash(txtNew2.Text);

            if (Users.Login(Users.currentUser.Username, this.txtActual.Text))
            {
                if (ri == perserit)
                {
                    Users.UpdatePasswordHash(Users.currentUser.id, ri);
                    MessageBox.Show("Fjalekalimi u ndryshua me sukses", Utils.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    Login login = new Login();
                    login.Show();
                    
                }
                else
                {
                    MessageBox.Show("Fjalekalimi ri me ate te perseritur nuk perputhet", Utils.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNew.Text = string.Empty;
                    txtNew2.Text = string.Empty;
                    txtNew.Focus();
                }
            }
            else
            {
                MessageBox.Show("Fjalekalimi i vjeter nuk eshte i sakte!", Utils.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtActual.Text = "";
                txtActual.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }
    }
}
