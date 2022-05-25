
namespace Market_Zinciri_Otomasyonu
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.pctGirisResmi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctGirisResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(69, 202);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(83, 15);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(113, 238);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(39, 15);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(158, 275);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(118, 23);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(158, 200);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(118, 20);
            this.txtKullanici.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(158, 238);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.Size = new System.Drawing.Size(118, 20);
            this.txtSifre.TabIndex = 4;
            // 
            // pctGirisResmi
            // 
            this.pctGirisResmi.Image = ((System.Drawing.Image)(resources.GetObject("pctGirisResmi.Image")));
            this.pctGirisResmi.Location = new System.Drawing.Point(72, 12);
            this.pctGirisResmi.Name = "pctGirisResmi";
            this.pctGirisResmi.Size = new System.Drawing.Size(204, 166);
            this.pctGirisResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGirisResmi.TabIndex = 5;
            this.pctGirisResmi.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 315);
            this.Controls.Add(this.pctGirisResmi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGiris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pctGirisResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.PictureBox pctGirisResmi;
    }
}

