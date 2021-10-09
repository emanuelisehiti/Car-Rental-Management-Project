
namespace MakinaMeQera
{
    partial class FrmCars
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
            this.lblNID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcEngine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.lblListPerdorus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.TopPanel.Size = new System.Drawing.Size(946, 103);
            this.TopPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Magneto", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(909, 60);
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
            this.close.Location = new System.Drawing.Point(918, 0);
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
            this.kreu.Text = "Makinat";
            this.kreu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNID
            // 
            this.lblNID.AutoSize = true;
            this.lblNID.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNID.ForeColor = System.Drawing.Color.Maroon;
            this.lblNID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNID.Location = new System.Drawing.Point(19, 156);
            this.lblNID.Name = "lblNID";
            this.lblNID.Size = new System.Drawing.Size(75, 21);
            this.lblNID.TabIndex = 11;
            this.lblNID.Text = "Modeli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(19, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Motorri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(19, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cmimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(19, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Marka";
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(100, 146);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(292, 31);
            this.txtmodel.TabIndex = 15;
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(100, 197);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(292, 31);
            this.txtbrand.TabIndex = 16;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(100, 249);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(232, 31);
            this.txtprice.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(297, 368);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 38);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "FSHIJ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Maroon;
            this.btnEdit.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Location = new System.Drawing.Point(142, 368);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 38);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "NDRYSHO";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(24, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 38);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "SHTO";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(24, 448);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 36);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Kthehu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcId,
            this.gcModel,
            this.gcBrand,
            this.gcEngine,
            this.gcPrice});
            this.dataGridView1.Location = new System.Drawing.Point(422, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(495, 338);
            this.dataGridView1.TabIndex = 25;
            // 
            // gcId
            // 
            this.gcId.HeaderText = "Id";
            this.gcId.MinimumWidth = 8;
            this.gcId.Name = "gcId";
            this.gcId.Visible = false;
            this.gcId.Width = 30;
            // 
            // gcModel
            // 
            this.gcModel.HeaderText = "Modeli";
            this.gcModel.MinimumWidth = 8;
            this.gcModel.Name = "gcModel";
            this.gcModel.Width = 120;
            // 
            // gcBrand
            // 
            this.gcBrand.HeaderText = "Marka";
            this.gcBrand.MinimumWidth = 8;
            this.gcBrand.Name = "gcBrand";
            this.gcBrand.Width = 120;
            // 
            // gcEngine
            // 
            this.gcEngine.HeaderText = "Motorri";
            this.gcEngine.MinimumWidth = 8;
            this.gcEngine.Name = "gcEngine";
            this.gcEngine.Width = 120;
            // 
            // gcPrice
            // 
            this.gcPrice.HeaderText = "Cmimi";
            this.gcPrice.MinimumWidth = 8;
            this.gcPrice.Name = "gcPrice";
            this.gcPrice.Width = 120;
            // 
            // model
            // 
            this.model.HeaderText = "Modeli";
            this.model.MinimumWidth = 8;
            this.model.Name = "model";
            this.model.Width = 150;
            // 
            // brand
            // 
            this.brand.HeaderText = "Marka";
            this.brand.MinimumWidth = 8;
            this.brand.Name = "brand";
            this.brand.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "Cmimi";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 29);
            this.panel1.TabIndex = 26;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(100, 300);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(292, 31);
            this.txtEngine.TabIndex = 27;
            // 
            // lblListPerdorus
            // 
            this.lblListPerdorus.AutoSize = true;
            this.lblListPerdorus.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListPerdorus.ForeColor = System.Drawing.Color.Maroon;
            this.lblListPerdorus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListPerdorus.Location = new System.Drawing.Point(596, 106);
            this.lblListPerdorus.Name = "lblListPerdorus";
            this.lblListPerdorus.Size = new System.Drawing.Size(165, 21);
            this.lblListPerdorus.TabIndex = 28;
            this.lblListPerdorus.Text = "Lista e makinave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(338, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Leke";
            // 
            // FrmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 535);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblListPerdorus);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNID);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCars";
            this.Load += new System.EventHandler(this.FrmCars_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TopPanel;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kreu;
        private System.Windows.Forms.Label lblNID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcEngine;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcPrice;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.Label lblListPerdorus;
        private System.Windows.Forms.Label label5;
    }
}