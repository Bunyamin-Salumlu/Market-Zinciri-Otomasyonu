
namespace Market_Zinciri_Otomasyonu
{
    partial class frmFirmaForm
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
            this.btnIslemFormunaGit = new System.Windows.Forms.Button();
            this.txtSubeKodu = new System.Windows.Forms.TextBox();
            this.lblSubeKodu = new System.Windows.Forms.Label();
            this.grpSube = new System.Windows.Forms.GroupBox();
            this.btnSubeListele = new System.Windows.Forms.Button();
            this.txtSubeAdresIlcesi = new System.Windows.Forms.TextBox();
            this.lblSubeAdresIlcesi = new System.Windows.Forms.Label();
            this.txtSubeAdresCaddesi = new System.Windows.Forms.TextBox();
            this.txtSubeAdresMahallesi = new System.Windows.Forms.TextBox();
            this.txtSubeAdresIli = new System.Windows.Forms.TextBox();
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.lblSubeAdresCaddesi = new System.Windows.Forms.Label();
            this.lblSubeAdresMahallesi = new System.Windows.Forms.Label();
            this.lblSubeAdresIli = new System.Windows.Forms.Label();
            this.lblSubeAdi = new System.Windows.Forms.Label();
            this.grpSube.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIslemFormunaGit
            // 
            this.btnIslemFormunaGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemFormunaGit.Location = new System.Drawing.Point(12, 303);
            this.btnIslemFormunaGit.Name = "btnIslemFormunaGit";
            this.btnIslemFormunaGit.Size = new System.Drawing.Size(68, 23);
            this.btnIslemFormunaGit.TabIndex = 112;
            this.btnIslemFormunaGit.Text = "Geri Git";
            this.btnIslemFormunaGit.UseVisualStyleBackColor = true;
            this.btnIslemFormunaGit.Click += new System.EventHandler(this.btnIslemFormunaGit_Click);
            // 
            // txtSubeKodu
            // 
            this.txtSubeKodu.Location = new System.Drawing.Point(100, 12);
            this.txtSubeKodu.Name = "txtSubeKodu";
            this.txtSubeKodu.Size = new System.Drawing.Size(153, 20);
            this.txtSubeKodu.TabIndex = 115;
            // 
            // lblSubeKodu
            // 
            this.lblSubeKodu.AutoSize = true;
            this.lblSubeKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeKodu.Location = new System.Drawing.Point(20, 15);
            this.lblSubeKodu.Name = "lblSubeKodu";
            this.lblSubeKodu.Size = new System.Drawing.Size(73, 13);
            this.lblSubeKodu.TabIndex = 114;
            this.lblSubeKodu.Text = "Şube Kodu:";
            // 
            // grpSube
            // 
            this.grpSube.Controls.Add(this.btnSubeListele);
            this.grpSube.Controls.Add(this.txtSubeAdresIlcesi);
            this.grpSube.Controls.Add(this.lblSubeAdresIlcesi);
            this.grpSube.Controls.Add(this.txtSubeAdresCaddesi);
            this.grpSube.Controls.Add(this.txtSubeAdresMahallesi);
            this.grpSube.Controls.Add(this.txtSubeAdresIli);
            this.grpSube.Controls.Add(this.txtSubeAdi);
            this.grpSube.Controls.Add(this.lblSubeAdresCaddesi);
            this.grpSube.Controls.Add(this.lblSubeAdresMahallesi);
            this.grpSube.Controls.Add(this.lblSubeAdresIli);
            this.grpSube.Controls.Add(this.lblSubeAdi);
            this.grpSube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSube.Location = new System.Drawing.Point(12, 43);
            this.grpSube.Name = "grpSube";
            this.grpSube.Size = new System.Drawing.Size(279, 242);
            this.grpSube.TabIndex = 113;
            this.grpSube.TabStop = false;
            this.grpSube.Text = "Şube";
            // 
            // btnSubeListele
            // 
            this.btnSubeListele.Location = new System.Drawing.Point(88, 189);
            this.btnSubeListele.Name = "btnSubeListele";
            this.btnSubeListele.Size = new System.Drawing.Size(105, 23);
            this.btnSubeListele.TabIndex = 15;
            this.btnSubeListele.Text = "Şube Listele";
            this.btnSubeListele.UseVisualStyleBackColor = true;
            this.btnSubeListele.Click += new System.EventHandler(this.btnSubeListele_Click);
            // 
            // txtSubeAdresIlcesi
            // 
            this.txtSubeAdresIlcesi.Location = new System.Drawing.Point(88, 90);
            this.txtSubeAdresIlcesi.Name = "txtSubeAdresIlcesi";
            this.txtSubeAdresIlcesi.Size = new System.Drawing.Size(153, 20);
            this.txtSubeAdresIlcesi.TabIndex = 2;
            // 
            // lblSubeAdresIlcesi
            // 
            this.lblSubeAdresIlcesi.AutoSize = true;
            this.lblSubeAdresIlcesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeAdresIlcesi.Location = new System.Drawing.Point(41, 93);
            this.lblSubeAdresIlcesi.Name = "lblSubeAdresIlcesi";
            this.lblSubeAdresIlcesi.Size = new System.Drawing.Size(32, 13);
            this.lblSubeAdresIlcesi.TabIndex = 0;
            this.lblSubeAdresIlcesi.Text = "İlçe:";
            // 
            // txtSubeAdresCaddesi
            // 
            this.txtSubeAdresCaddesi.Location = new System.Drawing.Point(88, 149);
            this.txtSubeAdresCaddesi.Name = "txtSubeAdresCaddesi";
            this.txtSubeAdresCaddesi.Size = new System.Drawing.Size(153, 20);
            this.txtSubeAdresCaddesi.TabIndex = 14;
            // 
            // txtSubeAdresMahallesi
            // 
            this.txtSubeAdresMahallesi.Location = new System.Drawing.Point(88, 120);
            this.txtSubeAdresMahallesi.Name = "txtSubeAdresMahallesi";
            this.txtSubeAdresMahallesi.Size = new System.Drawing.Size(153, 20);
            this.txtSubeAdresMahallesi.TabIndex = 13;
            // 
            // txtSubeAdresIli
            // 
            this.txtSubeAdresIli.Location = new System.Drawing.Point(88, 62);
            this.txtSubeAdresIli.Name = "txtSubeAdresIli";
            this.txtSubeAdresIli.Size = new System.Drawing.Size(153, 20);
            this.txtSubeAdresIli.TabIndex = 11;
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.Location = new System.Drawing.Point(88, 33);
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Size = new System.Drawing.Size(153, 20);
            this.txtSubeAdi.TabIndex = 9;
            // 
            // lblSubeAdresCaddesi
            // 
            this.lblSubeAdresCaddesi.AutoSize = true;
            this.lblSubeAdresCaddesi.Location = new System.Drawing.Point(25, 152);
            this.lblSubeAdresCaddesi.Name = "lblSubeAdresCaddesi";
            this.lblSubeAdresCaddesi.Size = new System.Drawing.Size(47, 13);
            this.lblSubeAdresCaddesi.TabIndex = 4;
            this.lblSubeAdresCaddesi.Text = "Cadde:";
            // 
            // lblSubeAdresMahallesi
            // 
            this.lblSubeAdresMahallesi.AutoSize = true;
            this.lblSubeAdresMahallesi.Location = new System.Drawing.Point(17, 123);
            this.lblSubeAdresMahallesi.Name = "lblSubeAdresMahallesi";
            this.lblSubeAdresMahallesi.Size = new System.Drawing.Size(55, 13);
            this.lblSubeAdresMahallesi.TabIndex = 3;
            this.lblSubeAdresMahallesi.Text = "Mahalle:";
            // 
            // lblSubeAdresIli
            // 
            this.lblSubeAdresIli.AutoSize = true;
            this.lblSubeAdresIli.Location = new System.Drawing.Point(54, 65);
            this.lblSubeAdresIli.Name = "lblSubeAdresIli";
            this.lblSubeAdresIli.Size = new System.Drawing.Size(18, 13);
            this.lblSubeAdresIli.TabIndex = 1;
            this.lblSubeAdresIli.Text = "İl:";
            // 
            // lblSubeAdi
            // 
            this.lblSubeAdi.AutoSize = true;
            this.lblSubeAdi.Location = new System.Drawing.Point(43, 36);
            this.lblSubeAdi.Name = "lblSubeAdi";
            this.lblSubeAdi.Size = new System.Drawing.Size(29, 13);
            this.lblSubeAdi.TabIndex = 0;
            this.lblSubeAdi.Text = "Adı:";
            // 
            // frmFirmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(319, 338);
            this.Controls.Add(this.txtSubeKodu);
            this.Controls.Add(this.lblSubeKodu);
            this.Controls.Add(this.grpSube);
            this.Controls.Add(this.btnIslemFormunaGit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFirmaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma Sayfası";
            this.grpSube.ResumeLayout(false);
            this.grpSube.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIslemFormunaGit;
        private System.Windows.Forms.TextBox txtSubeKodu;
        private System.Windows.Forms.Label lblSubeKodu;
        private System.Windows.Forms.GroupBox grpSube;
        private System.Windows.Forms.TextBox txtSubeAdresIlcesi;
        private System.Windows.Forms.Label lblSubeAdresIlcesi;
        private System.Windows.Forms.TextBox txtSubeAdresCaddesi;
        private System.Windows.Forms.TextBox txtSubeAdresMahallesi;
        private System.Windows.Forms.TextBox txtSubeAdresIli;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.Label lblSubeAdresCaddesi;
        private System.Windows.Forms.Label lblSubeAdresMahallesi;
        private System.Windows.Forms.Label lblSubeAdresIli;
        private System.Windows.Forms.Label lblSubeAdi;
        private System.Windows.Forms.Button btnSubeListele;
    }
}