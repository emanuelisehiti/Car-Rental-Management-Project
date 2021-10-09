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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 20;
            MyProgress.Value = startPoint;
            if(MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
