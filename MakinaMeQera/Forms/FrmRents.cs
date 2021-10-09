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
    public partial class FrmRents : Form
    {
        public FrmRents()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fillAllRents()
        {
            this.dataGridView1.Rows.Clear();
            foreach (var c in MakinaMeQera.RentsList.Get())
            {
                this.dataGridView1.Rows.Add(
                    c.id,
                    c.dtFrom,
                    c.dtTo,
                    c.brand,
                    c.model,
                    c.engine,
                    c.totPrice,
                    c.client
                    );
            }
        }

        private void FrmRents_Load(object sender, EventArgs e)
        {
            fillAllRents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRezervationn frm = new FrmRezervationn();
            this.Hide();
            frm.Show();
        }
    }
}
