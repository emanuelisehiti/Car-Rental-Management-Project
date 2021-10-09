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

namespace MakinaMeQera
{
    public partial class FrmUser : Form
    {


        int userId;
        public FrmUser(int userId_=0)
        {
            InitializeComponent();
            if (userId == 0)
                this.userId = userId_;

        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fillUsers()
        {
            this.dataGridView1.Rows.Clear();
            foreach (var c in MakinaMeQera.UsersList.Get())
            {
                this.dataGridView1.Rows.Add(
                    c.id,
                    c.Username,
                    c.Firstname,
                    c.Lastname,
                    c.email,
                    (c.admin) ? "Po" : "Jo"
                    
                    );
            }
        }


       
        private void btnSHTO_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.id = this.userId;
            users.Username = this.txtUname.Text;
           
            users.Firstname = this.txtName.Text;
            users.Lastname = this.txtSurname.Text;
            users.email = this.txtemail.Text;
            users.admin = this.chcbAdmin.Checked;
            if (userId > 0)
            {
                this.txtPass.Enabled = false;
                var user = Users.Update(users);

                if (user.id > 0)
                {
                    MessageBox.Show("Modifikimi u krye me sukses.", "Makina me qera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.fillUsers();
                    this.txtUname.Clear();
                    this.txtPass.Clear();
                    this.txtName.Clear();
                    this.txtSurname.Clear();
                    this.txtemail.Clear();
                    this.chcbAdmin.Checked = false;
                    btnSHTO.Text = "SHTO";
                }
                else
                    MessageBox.Show("Pati nje gabim gjate modifikimit!", "Makina me qera", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var user = Users.Insert(users,this.txtPass.Text);

                if (user.id > 0)
                {
                    MessageBox.Show("Shtimi u krye me sukses.", "Makina me qera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.fillUsers();
                    this.txtUname.Clear();
                    this.txtPass.Clear();
                    this.txtName.Clear();
                    this.txtSurname.Clear();
                    this.txtemail.Clear();
                    this.chcbAdmin.Checked = false;
                }
                else
                    MessageBox.Show("Pati nje gabim gjate shtimit ne DB!", "Makina me qera", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            this.fillUsers();
        }

        private void btnKthehu_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Close();
            frmMain.Show();
            
        }

        private void btnNdrysho_Click(object sender, EventArgs e)
        {

            var selected = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex];

            if (selected != null)
            {
                var userId = (int)selected.Cells["gcId"].Value;

               userId = (int)selected.Cells[0].Value;

                if (userId > 0)
                {
                    var user = Users.Get(userId);
                    this.txtUname.Text = user.Username;
                
                    this.txtName.Text = user.Firstname;
                    this.txtSurname.Text= user.Lastname;
                    this.txtemail.Text = user.email;
                    this.chcbAdmin.Checked = user.admin;
                    this.userId = user.id;
                }
               btnSHTO.Text = "RUAJ";
            }
        }

       
    }
}