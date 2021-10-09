using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakinaMeQera
{
    public partial class FrmRezervationn : Form
    {
        int rezId;
        byte selectedCarId;
        
        public FrmRezervationn(int rezId_ = 0)
        {
            InitializeComponent();
            this.rezId = rezId_;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        SqlConnection con= new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\user\Desktop\C#\MakinaMeQera\MakinaMeQera\db.mdf;Integrated Security=True");
            private void fillClinet()
        {
            con.Open();
            string query = "select *  from CustomerTable";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
          foreach(DataRow dr in dt.Rows)
            {
               txtClient.Text = dr["Klienti"].ToString();
            }
            con.Close();
        }
        private void fillAvailableCars()
        {  
            this.dataGridView1.Rows.Clear();
            foreach (var c in MakinaMeQera.CarsAvailableList.GetAvailable(dtRent.Value,dtBack.Value))
            {
                this.dataGridView1.Rows.Add(
                    c.id,
                    c.model,
                    c.brand,
                    c.engine,
                    c.price
                    );
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtsale.Text))
            {
                MessageBox.Show("Vendosni zbritjen!");
                return;
            }
            if (this.dtRent.Value >= this.dtBack.Value)
            {
                MessageBox.Show("Vendosi daten ne rregull!");
                this.dtBack.Focus();
                return;
            }
            else
            fillAvailableCars();

        }

        private void FrmRent_Load(object sender, EventArgs e)
        {
            fillClinet();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ts = this.dtBack.Value - this.dtRent.Value;
            float.TryParse(this.txtsale.Text, out var sale);

            var selecetd = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex];
            if(selecetd != null)
            {
                var carId = (byte)selecetd.Cells["gcId"].Value;
                carId = (byte)selecetd.Cells[0].Value;

                if (carId > 0)
                {
                    var car = Car.Get(carId);
                    this.txtBrand.Text = car.model;
                    this.txtModel.Text = car.brand;
                    this.txtEngine.Text = car.engine;
                    this.txtPrice.Text = car.price.ToString();
                        if (sale == 0)
                    {
                        this.txtTotPrice.Text = (car.price * ts.Days).ToString();
                    }
                    else
                    {
                        this.txtTotPrice.Text = ((car.price * ts.Days+1) - (car.price * (ts.Days+1) * sale) / 100).ToString();
                    }
                    
                    this.selectedCarId = car.id;
                }
            }
        }

        private void btnSHTO_Click(object sender, EventArgs e)
        {
            Rezervation rez = new Rezervation();
            rez.rezId = this.rezId;
            rez.dtFrom = this.dtRent.Value;
            rez.dtTo = this.dtBack.Value;
            rez.carId = this.selectedCarId;
            rez.client = this.txtClient.Text;
            float.TryParse(this.txtTotPrice.Text, out rez.totPrice);

            var newrez = Rezervation.Insert(rez);
            if(newrez.rezId > 0)
            {
                MessageBox.Show("Shtimi u krye me sukses.", "Makina me qera", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRents rents = new FrmRents();
            this.Hide();
            rents.Show();
        }

       
    }
}
