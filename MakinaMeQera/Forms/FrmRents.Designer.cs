
namespace MakinaMeQera
{
    partial class FrmRents
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcDtFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcDtTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcEngine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcTotPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            this.TopPanel.Size = new System.Drawing.Size(998, 103);
            this.TopPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Magneto", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(960, 60);
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
            this.close.Location = new System.Drawing.Point(969, 0);
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
            this.kreu.Size = new System.Drawing.Size(969, 43);
            this.kreu.TabIndex = 13;
            this.kreu.Text = "Rezervimet";
            this.kreu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 598);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 29);
            this.panel1.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcId,
            this.gcDtFrom,
            this.gcDtTo,
            this.gcCar,
            this.gcModel,
            this.gcEngine,
            this.gcTotPrice,
            this.gcClient});
            this.dataGridView1.Location = new System.Drawing.Point(43, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(878, 399);
            this.dataGridView1.TabIndex = 38;
            // 
            // gcId
            // 
            this.gcId.HeaderText = "Id";
            this.gcId.MinimumWidth = 8;
            this.gcId.Name = "gcId";
            this.gcId.Visible = false;
            this.gcId.Width = 150;
            // 
            // gcDtFrom
            // 
            this.gcDtFrom.HeaderText = "Rezervimi";
            this.gcDtFrom.MinimumWidth = 8;
            this.gcDtFrom.Name = "gcDtFrom";
            this.gcDtFrom.Width = 150;
            // 
            // gcDtTo
            // 
            this.gcDtTo.HeaderText = "Kthimi";
            this.gcDtTo.MinimumWidth = 8;
            this.gcDtTo.Name = "gcDtTo";
            this.gcDtTo.Width = 150;
            // 
            // gcCar
            // 
            this.gcCar.HeaderText = "Makina";
            this.gcCar.MinimumWidth = 8;
            this.gcCar.Name = "gcCar";
            this.gcCar.Width = 150;
            // 
            // gcModel
            // 
            this.gcModel.HeaderText = "Modeli";
            this.gcModel.MinimumWidth = 8;
            this.gcModel.Name = "gcModel";
            this.gcModel.Width = 150;
            // 
            // gcEngine
            // 
            this.gcEngine.HeaderText = "Motorri";
            this.gcEngine.MinimumWidth = 8;
            this.gcEngine.Name = "gcEngine";
            this.gcEngine.Width = 150;
            // 
            // gcTotPrice
            // 
            this.gcTotPrice.HeaderText = "Pagesa";
            this.gcTotPrice.MinimumWidth = 8;
            this.gcTotPrice.Name = "gcTotPrice";
            this.gcTotPrice.Width = 150;
            // 
            // gcClient
            // 
            this.gcClient.HeaderText = "Klienti";
            this.gcClient.MinimumWidth = 8;
            this.gcClient.Name = "gcClient";
            this.gcClient.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(12, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 34);
            this.button1.TabIndex = 52;
            this.button1.Text = "KTHEHU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 627);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReservation";
            this.Load += new System.EventHandler(this.FrmRents_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label kreu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcDtFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcDtTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcEngine;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcTotPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcClient;
        private System.Windows.Forms.Button button1;
    }
}