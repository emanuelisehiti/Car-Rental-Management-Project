
namespace MakinaMeQera
{
    partial class FrmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNext = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.kreu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtclientName = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnSHTO = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVazhdo = new System.Windows.Forms.Button();
            this.lblListPerdorus = new System.Windows.Forms.Label();
            this.btnNext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Maroon;
            this.btnNext.Controls.Add(this.label1);
            this.btnNext.Controls.Add(this.close);
            this.btnNext.Controls.Add(this.kreu);
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNext.Location = new System.Drawing.Point(0, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(885, 97);
            this.btnNext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Magneto", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(847, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Makina me qera";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.Color.Transparent;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(856, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 21);
            this.close.TabIndex = 12;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // kreu
            // 
            this.kreu.BackColor = System.Drawing.Color.Maroon;
            this.kreu.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kreu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kreu.Location = new System.Drawing.Point(3, 60);
            this.kreu.Name = "kreu";
            this.kreu.Size = new System.Drawing.Size(878, 26);
            this.kreu.TabIndex = 13;
            this.kreu.Text = "KLIENTET";
            this.kreu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(27, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Emri Klientit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(27, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(27, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefoni";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(27, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nid";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(170, 175);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(232, 31);
            this.txtCustID.TabIndex = 26;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(170, 253);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(232, 31);
            this.txtAdress.TabIndex = 27;
            // 
            // txtclientName
            // 
            this.txtclientName.Location = new System.Drawing.Point(170, 216);
            this.txtclientName.Name = "txtclientName";
            this.txtclientName.Size = new System.Drawing.Size(232, 31);
            this.txtclientName.TabIndex = 28;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(170, 290);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(232, 31);
            this.txtTel.TabIndex = 29;
            // 
            // btnSHTO
            // 
            this.btnSHTO.BackColor = System.Drawing.Color.Maroon;
            this.btnSHTO.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSHTO.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSHTO.Location = new System.Drawing.Point(170, 341);
            this.btnSHTO.Name = "btnSHTO";
            this.btnSHTO.Size = new System.Drawing.Size(112, 34);
            this.btnSHTO.TabIndex = 30;
            this.btnSHTO.Text = "SHTO";
            this.btnSHTO.UseVisualStyleBackColor = false;
            this.btnSHTO.Click += new System.EventHandler(this.btnSHTO_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(27, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "KTHEHU";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 29);
            this.panel1.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcId,
            this.gcClientName,
            this.gcAdress,
            this.gcTel,
            this.gcCustID});
            this.dataGridView1.Location = new System.Drawing.Point(408, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(454, 269);
            this.dataGridView1.TabIndex = 35;
            // 
            // gcId
            // 
            this.gcId.HeaderText = "Nid";
            this.gcId.MinimumWidth = 8;
            this.gcId.Name = "gcId";
            this.gcId.Width = 150;
            // 
            // gcClientName
            // 
            this.gcClientName.HeaderText = "Klienti";
            this.gcClientName.MinimumWidth = 8;
            this.gcClientName.Name = "gcClientName";
            this.gcClientName.Width = 150;
            // 
            // gcAdress
            // 
            this.gcAdress.HeaderText = "Adresa";
            this.gcAdress.MinimumWidth = 8;
            this.gcAdress.Name = "gcAdress";
            this.gcAdress.Width = 150;
            // 
            // gcTel
            // 
            this.gcTel.HeaderText = "Telefoni";
            this.gcTel.MinimumWidth = 8;
            this.gcTel.Name = "gcTel";
            this.gcTel.Width = 150;
            // 
            // gcCustID
            // 
            this.gcCustID.HeaderText = "Id";
            this.gcCustID.MinimumWidth = 8;
            this.gcCustID.Name = "gcCustID";
            this.gcCustID.Visible = false;
            this.gcCustID.Width = 150;
            // 
            // btnVazhdo
            // 
            this.btnVazhdo.BackColor = System.Drawing.Color.Maroon;
            this.btnVazhdo.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVazhdo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVazhdo.Location = new System.Drawing.Point(750, 420);
            this.btnVazhdo.Name = "btnVazhdo";
            this.btnVazhdo.Size = new System.Drawing.Size(123, 34);
            this.btnVazhdo.TabIndex = 36;
            this.btnVazhdo.Text = "VAZHDO";
            this.btnVazhdo.UseVisualStyleBackColor = false;
            this.btnVazhdo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblListPerdorus
            // 
            this.lblListPerdorus.AutoSize = true;
            this.lblListPerdorus.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListPerdorus.ForeColor = System.Drawing.Color.Maroon;
            this.lblListPerdorus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListPerdorus.Location = new System.Drawing.Point(554, 109);
            this.lblListPerdorus.Name = "lblListPerdorus";
            this.lblListPerdorus.Size = new System.Drawing.Size(166, 21);
            this.lblListPerdorus.TabIndex = 37;
            this.lblListPerdorus.Text = "Lista e Klienteve";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 492);
            this.Controls.Add(this.lblListPerdorus);
            this.Controls.Add(this.btnVazhdo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSHTO);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtclientName);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.btnNext.ResumeLayout(false);
            this.btnNext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label kreu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtclientName;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnSHTO;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVazhdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcCustID;
        private System.Windows.Forms.Label lblListPerdorus;
    }
}