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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void autorizo()
        {
            if (!Users.currentUser.admin)
            {
                btnMakina.Enabled = false;
                btnPerdoruesi.Enabled = false;
            } 
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMakina_Click(object sender, EventArgs e)
        {
            FrmCars frmCars = new FrmCars();
            this.Hide();
            frmCars.Show(); 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void btnPerdoruesi_Click(object sender, EventArgs e)
        {
            FrmUser user = new FrmUser();
            this.Hide();
            user.Show();

        }

        private void btnKlienti_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            this.Hide();
            frmCustomer.Show();
        }

        private void btnMeQera_Click(object sender, EventArgs e)
        {
            FrmRezervationn frmRent = new FrmRezervationn();
            this.Hide();
            frmRent.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            autorizo();
        }

        private void btnChangePAss_Click(object sender, EventArgs e)
        {
            FrmChangePass frmChangePass = new FrmChangePass();
            this.Hide();
            frmChangePass.Show();
        }
    }
}
