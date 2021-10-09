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
    public partial class FrmCars : Form
    {
        byte carId;
        public FrmCars(byte carId_ = 0)
        {
            InitializeComponent();
            if(carId == 0)
                this.carId = carId_;
        }
        private void fillCars()
        {
            this.dataGridView1.Rows.Clear();
            foreach (var c in MakinaMeQera.CarsList.Get())
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car car1 = new Car();
            car1.id = this.carId;
            car1.model = this.txtmodel.Text;
            car1.brand = this.txtbrand.Text;
            car1.engine = this.txtEngine.Text;
            if(int.TryParse(this.txtprice.Text,out car1.price))
            {
                int.TryParse(this.txtprice.Text, out car1.price);
            }
            else
            {
                MessageBox.Show("Vendosni cmimin ne rregull!", Utils.AppName);
                txtprice.Focus();
                return;
                
            }


         


            if (carId > 0)
            {
                var car = Car.Update(car1);

                if (car.id > 0)
                {
                    MessageBox.Show("Modifikimi u krye me sukses.", "Makina me qera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.fillCars();
                    this.txtbrand.Clear();
                    this.txtmodel.Clear();
                    this.txtprice.Clear();
                    this.txtEngine.Clear();
                    btnAdd.Text = "SHTO";
                }
                else
                    MessageBox.Show("Pati nje gabim gjate modifikimit!", "Makina me qera", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var car = Car.Insert(car1);

                if (car.id > 0)
                {
                    MessageBox.Show("Shtimi u krye me sukses.", "Makina me qera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.fillCars();
                    this.txtbrand.Clear();
                    this.txtmodel.Clear();
                    this.txtprice.Clear();
                    this.txtEngine.Clear();

                }
                else
                    MessageBox.Show("Pati nje gabim gjate shtimit ne DB!", "Makina me qera", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void FrmCars_Load(object sender, EventArgs e)
        {
            this.fillCars();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex];

            if (selected != null)
            {
               var carId = (byte)selected.Cells["gcId"].Value;

                carId = (byte)selected.Cells[0].Value;

                if (carId > 0)
                {
                    var car = Car.Get(carId);
                    this.txtmodel.Text = car.model;
                    this.txtbrand.Text = car.brand;
                    this.txtEngine.Text = car.engine;
                    this.txtprice.Text = car.price.ToString();
                    this.carId = car.id;
                }
                btnAdd.Text = "RUAJ";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedCells.Count > 0)
                {
                    var index = this.dataGridView1.SelectedCells[0].RowIndex;
                    var row = this.dataGridView1.Rows[index];
                    var carId = (byte)row.Cells["gcId"].Value;
                    var brand= (string)row.Cells["gcBrand"].Value;
                    var model = (string)row.Cells["gcModel"].Value;


                    if (MessageBox.Show("Doni te fshini " + brand + model + '?',Utils.AppName, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Car.Delete(carId);
                        MessageBox.Show("Fshirja u krye me sukses",Utils.AppName);
                        this.fillCars();
                    }
                }
            }
            catch (Exception ex)
            { 

            }
        }
    }
}
