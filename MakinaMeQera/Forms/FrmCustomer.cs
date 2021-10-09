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
    public partial class FrmCustomer : Form
    {
        int custId;
        public FrmCustomer(int custID=0)
        {
            InitializeComponent();
            if (custId == 0)
                this.custId = custID;
        }
        private void fillCustomers()
        {
            this.dataGridView1.Rows.Clear();
            foreach (var c in MakinaMeQera.CustList.Get())
            {
                this.dataGridView1.Rows.Add(
                    c.id,
                    c.client,
                    c.adress,
                    c.tel,
                    c.customerId
                    );
            }
        }
        private void btnSHTO_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();
            customer.customerId = this.custId;
            customer.client = this.txtclientName.Text;
            customer.adress = this.txtAdress.Text;
            customer.tel = this.txtTel.Text;
            customer.id = this.txtCustID.Text;


            var cust = Customer.Insert(customer);

            if (cust.customerId > 0)
            {
                MessageBox.Show("Shtimi u krye me sukses.", "Makina me qera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.fillCustomers();
                txtclientName.Clear();
                txtAdress.Clear();
                txtTel.Clear();
                txtCustID.Clear();


            }
            else
            {
                MessageBox.Show("Pati nje gabim gjate shtimit ne DB!", "Makina me qera", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Close();
            frmMain.Show();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            this.fillCustomers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRezervationn frmRent = new FrmRezervationn();
            this.Hide();
            frmRent.Show();
        }
    }
}
