
namespace MakinaMeQera
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.TopPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.kreu = new System.Windows.Forms.Label();
            this.btnMakina = new System.Windows.Forms.Button();
            this.btnKlienti = new System.Windows.Forms.Button();
            this.btnPerdoruesi = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChangePAss = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.TopPanel.Size = new System.Drawing.Size(885, 96);
            this.TopPanel.TabIndex = 0;
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
            this.kreu.Text = "KREU";
            this.kreu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMakina
            // 
            this.btnMakina.BackColor = System.Drawing.Color.Maroon;
            this.btnMakina.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMakina.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMakina.Location = new System.Drawing.Point(107, 100);
            this.btnMakina.Name = "btnMakina";
            this.btnMakina.Size = new System.Drawing.Size(178, 34);
            this.btnMakina.TabIndex = 1;
            this.btnMakina.Text = "Makina";
            this.btnMakina.UseVisualStyleBackColor = false;
            this.btnMakina.Click += new System.EventHandler(this.btnMakina_Click);
            // 
            // btnKlienti
            // 
            this.btnKlienti.BackColor = System.Drawing.Color.Maroon;
            this.btnKlienti.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKlienti.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKlienti.Location = new System.Drawing.Point(337, 100);
            this.btnKlienti.Name = "btnKlienti";
            this.btnKlienti.Size = new System.Drawing.Size(223, 34);
            this.btnKlienti.TabIndex = 4;
            this.btnKlienti.Text = "Me qera";
            this.btnKlienti.UseVisualStyleBackColor = false;
            this.btnKlienti.Click += new System.EventHandler(this.btnKlienti_Click);
            // 
            // btnPerdoruesi
            // 
            this.btnPerdoruesi.BackColor = System.Drawing.Color.Maroon;
            this.btnPerdoruesi.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPerdoruesi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPerdoruesi.Location = new System.Drawing.Point(610, 100);
            this.btnPerdoruesi.Name = "btnPerdoruesi";
            this.btnPerdoruesi.Size = new System.Drawing.Size(209, 35);
            this.btnPerdoruesi.TabIndex = 5;
            this.btnPerdoruesi.Text = "Perdoruesit";
            this.btnPerdoruesi.UseVisualStyleBackColor = false;
            this.btnPerdoruesi.Click += new System.EventHandler(this.btnPerdoruesi_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogout.Location = new System.Drawing.Point(256, 481);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 34);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Dil";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 29);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 333);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnChangePAss
            // 
            this.btnChangePAss.BackColor = System.Drawing.Color.Maroon;
            this.btnChangePAss.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePAss.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChangePAss.Location = new System.Drawing.Point(463, 481);
            this.btnChangePAss.Name = "btnChangePAss";
            this.btnChangePAss.Size = new System.Drawing.Size(240, 34);
            this.btnChangePAss.TabIndex = 9;
            this.btnChangePAss.Text = "Ndrysho Fjalekalim";
            this.btnChangePAss.UseVisualStyleBackColor = false;
            this.btnChangePAss.Click += new System.EventHandler(this.btnChangePAss_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(885, 550);
            this.Controls.Add(this.btnChangePAss);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPerdoruesi);
            this.Controls.Add(this.btnKlienti);
            this.Controls.Add(this.btnMakina);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakina;
        private System.Windows.Forms.Button btnKlienti;
        private System.Windows.Forms.Button btnPerdoruesi;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label kreu;
        private System.Windows.Forms.Button btnChangePAss;
    }
}