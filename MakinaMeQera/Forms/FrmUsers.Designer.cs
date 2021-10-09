
namespace MakinaMeQera
{
    partial class FrmUser
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
            this.TopPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.kreu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSHTO = new System.Windows.Forms.Button();
            this.btnNdrysho = new System.Windows.Forms.Button();
            this.btnKthehu = new System.Windows.Forms.Button();
            this.lblListPerdorus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPerdorues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.chcbAdmin = new System.Windows.Forms.CheckBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Maroon;
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.close);
            this.TopPanel.Controls.Add(this.kreu);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(898, 96);
            this.TopPanel.TabIndex = 1;
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
            this.kreu.Text = "PERDORUESIT";
            this.kreu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 29);
            this.panel1.TabIndex = 8;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(130, 192);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(222, 31);
            this.txtPass.TabIndex = 12;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(130, 154);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(222, 31);
            this.txtUname.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 245);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 31);
            this.txtName.TabIndex = 14;
            // 
            // btnSHTO
            // 
            this.btnSHTO.BackColor = System.Drawing.Color.Maroon;
            this.btnSHTO.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSHTO.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSHTO.Location = new System.Drawing.Point(30, 425);
            this.btnSHTO.Name = "btnSHTO";
            this.btnSHTO.Size = new System.Drawing.Size(140, 34);
            this.btnSHTO.TabIndex = 15;
            this.btnSHTO.Text = "SHTO";
            this.btnSHTO.UseVisualStyleBackColor = false;
            this.btnSHTO.Click += new System.EventHandler(this.btnSHTO_Click);
            // 
            // btnNdrysho
            // 
            this.btnNdrysho.BackColor = System.Drawing.Color.Maroon;
            this.btnNdrysho.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNdrysho.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNdrysho.Location = new System.Drawing.Point(192, 425);
            this.btnNdrysho.Name = "btnNdrysho";
            this.btnNdrysho.Size = new System.Drawing.Size(160, 34);
            this.btnNdrysho.TabIndex = 16;
            this.btnNdrysho.Text = "NDRYSHO";
            this.btnNdrysho.UseVisualStyleBackColor = false;
            this.btnNdrysho.Click += new System.EventHandler(this.btnNdrysho_Click);
            // 
            // btnKthehu
            // 
            this.btnKthehu.BackColor = System.Drawing.Color.Maroon;
            this.btnKthehu.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKthehu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKthehu.Location = new System.Drawing.Point(30, 476);
            this.btnKthehu.Name = "btnKthehu";
            this.btnKthehu.Size = new System.Drawing.Size(112, 34);
            this.btnKthehu.TabIndex = 18;
            this.btnKthehu.Text = "KTHEHU";
            this.btnKthehu.UseVisualStyleBackColor = false;
            this.btnKthehu.Click += new System.EventHandler(this.btnKthehu_Click);
            // 
            // lblListPerdorus
            // 
            this.lblListPerdorus.AutoSize = true;
            this.lblListPerdorus.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListPerdorus.ForeColor = System.Drawing.Color.Maroon;
            this.lblListPerdorus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListPerdorus.Location = new System.Drawing.Point(556, 131);
            this.lblListPerdorus.Name = "lblListPerdorus";
            this.lblListPerdorus.Size = new System.Drawing.Size(188, 21);
            this.lblListPerdorus.TabIndex = 19;
            this.lblListPerdorus.Text = "Lista e përdoruesve";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcId,
            this.clmPerdorues,
            this.gcName,
            this.gcSurname,
            this.gcEmail,
            this.gcAdmin});
            this.dataGridView1.Location = new System.Drawing.Point(408, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(473, 304);
            this.dataGridView1.TabIndex = 20;
            // 
            // gcId
            // 
            this.gcId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcId.HeaderText = "Id";
            this.gcId.MinimumWidth = 8;
            this.gcId.Name = "gcId";
            this.gcId.Visible = false;
            // 
            // clmPerdorues
            // 
            this.clmPerdorues.HeaderText = "Perdoruesi";
            this.clmPerdorues.MinimumWidth = 8;
            this.clmPerdorues.Name = "clmPerdorues";
            this.clmPerdorues.Width = 150;
            // 
            // gcName
            // 
            this.gcName.HeaderText = "Emri";
            this.gcName.MinimumWidth = 8;
            this.gcName.Name = "gcName";
            this.gcName.Width = 150;
            // 
            // gcSurname
            // 
            this.gcSurname.HeaderText = "Mbiemri";
            this.gcSurname.MinimumWidth = 8;
            this.gcSurname.Name = "gcSurname";
            this.gcSurname.Width = 150;
            // 
            // gcEmail
            // 
            this.gcEmail.HeaderText = "Email";
            this.gcEmail.MinimumWidth = 8;
            this.gcEmail.Name = "gcEmail";
            this.gcEmail.Width = 150;
            // 
            // gcAdmin
            // 
            this.gcAdmin.HeaderText = "Admin";
            this.gcAdmin.MinimumWidth = 8;
            this.gcAdmin.Name = "gcAdmin";
            this.gcAdmin.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Perdoruesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fjalekalimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(12, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Emri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mbiemri";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(130, 290);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(222, 31);
            this.txtSurname.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(12, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(130, 334);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(222, 31);
            this.txtemail.TabIndex = 27;
            // 
            // chcbAdmin
            // 
            this.chcbAdmin.AutoSize = true;
            this.chcbAdmin.Location = new System.Drawing.Point(130, 372);
            this.chcbAdmin.Name = "chcbAdmin";
            this.chcbAdmin.Size = new System.Drawing.Size(91, 29);
            this.chcbAdmin.TabIndex = 28;
            this.chcbAdmin.Text = "Admin";
            this.chcbAdmin.UseVisualStyleBackColor = true;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 545);
            this.Controls.Add(this.chcbAdmin);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblListPerdorus);
            this.Controls.Add(this.btnKthehu);
            this.Controls.Add(this.btnNdrysho);
            this.Controls.Add(this.btnSHTO);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label kreu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSHTO;
        private System.Windows.Forms.Button btnNdrysho;
        private System.Windows.Forms.Button btnKthehu;
        private System.Windows.Forms.Label lblListPerdorus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPass;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.CheckBox chcbAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPerdorues;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcAdmin;
    }
}