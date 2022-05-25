
namespace Market_Zinciri_Otomasyonu
{
    partial class frmIslemForm
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
            this.btnFirmaIslemi = new System.Windows.Forms.Button();
            this.btnSubeIslemi = new System.Windows.Forms.Button();
            this.btnUrunIslemi = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnGirisFormunaGit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirmaIslemi
            // 
            this.btnFirmaIslemi.Location = new System.Drawing.Point(105, 77);
            this.btnFirmaIslemi.Name = "btnFirmaIslemi";
            this.btnFirmaIslemi.Size = new System.Drawing.Size(155, 23);
            this.btnFirmaIslemi.TabIndex = 0;
            this.btnFirmaIslemi.Text = "Firma İşlemi";
            this.btnFirmaIslemi.UseVisualStyleBackColor = true;
            this.btnFirmaIslemi.Click += new System.EventHandler(this.btnFirmaIslemi_Click);
            // 
            // btnSubeIslemi
            // 
            this.btnSubeIslemi.Location = new System.Drawing.Point(105, 121);
            this.btnSubeIslemi.Name = "btnSubeIslemi";
            this.btnSubeIslemi.Size = new System.Drawing.Size(155, 23);
            this.btnSubeIslemi.TabIndex = 1;
            this.btnSubeIslemi.Text = "Şube İşlemi";
            this.btnSubeIslemi.UseVisualStyleBackColor = true;
            this.btnSubeIslemi.Click += new System.EventHandler(this.btnSubeIslemi_Click);
            // 
            // btnUrunIslemi
            // 
            this.btnUrunIslemi.Location = new System.Drawing.Point(105, 170);
            this.btnUrunIslemi.Name = "btnUrunIslemi";
            this.btnUrunIslemi.Size = new System.Drawing.Size(155, 23);
            this.btnUrunIslemi.TabIndex = 2;
            this.btnUrunIslemi.Text = "Ürün İşlemi";
            this.btnUrunIslemi.UseVisualStyleBackColor = true;
            this.btnUrunIslemi.Click += new System.EventHandler(this.btnUrunIslemi_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(35, 31);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(272, 19);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Lütfen yapmak istediğiniz işlemi Seçiniz.!\r\n";
            // 
            // btnGirisFormunaGit
            // 
            this.btnGirisFormunaGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisFormunaGit.Location = new System.Drawing.Point(12, 204);
            this.btnGirisFormunaGit.Name = "btnGirisFormunaGit";
            this.btnGirisFormunaGit.Size = new System.Drawing.Size(68, 23);
            this.btnGirisFormunaGit.TabIndex = 113;
            this.btnGirisFormunaGit.Text = "Geri Git";
            this.btnGirisFormunaGit.UseVisualStyleBackColor = true;
            this.btnGirisFormunaGit.Click += new System.EventHandler(this.btnGirisFormunaGit_Click);
            // 
            // frmIslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(368, 239);
            this.Controls.Add(this.btnGirisFormunaGit);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnUrunIslemi);
            this.Controls.Add(this.btnSubeIslemi);
            this.Controls.Add(this.btnFirmaIslemi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIslemForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " İşlemler Sayfası";
            this.Load += new System.EventHandler(this.IslemFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirmaIslemi;
        private System.Windows.Forms.Button btnSubeIslemi;
        private System.Windows.Forms.Button btnUrunIslemi;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnGirisFormunaGit;
    }
}