using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Zinciri_Otomasyonu
{
    public partial class frmIslemForm : Form
    {
        public bool PatronGirisi = false;
        public bool MudurGirisi = false;
        public bool MudurYarGirisi = false;
        frmSubeForm subeFormu = new frmSubeForm();
        frmUrunForm urunFormu = new frmUrunForm();

        private void IslemFormu_Load(object sender, EventArgs e)
        {
            if(PatronGirisi == true)
            {
                subeFormu.PatronGirisi = true;
                urunFormu.PatronGirisi = true;
                btnFirmaIslemi.Enabled = true;
                btnSubeIslemi.Enabled = true;
                btnUrunIslemi.Enabled = true;
            }

            else if (MudurGirisi == true)
            {
                subeFormu.MudurGirisi = true;
                urunFormu.MudurGirisi = true;
                btnFirmaIslemi.Enabled = false;
            }
            else if (MudurYarGirisi == true)
            {
                urunFormu.MudurYarGirisi = true;
                btnFirmaIslemi.Enabled = false;
                btnSubeIslemi.Enabled = false;
            }
        }

        public frmIslemForm()
        {
            InitializeComponent();
        }

        private void btnFirmaIslemi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Firma İşlemlerine Gidiliyor...");
            frmFirmaForm firmaFormu = new frmFirmaForm();
            firmaFormu.Show();
            this.Hide();
        }

        private void btnSubeIslemi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şube İşlemlerine Gidiliyor...");
            subeFormu.Show();
            this.Hide();
        }

        private void btnUrunIslemi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün İşlemlerine Gidiliyor...");
            urunFormu.Show();
            this.Hide();
        }

        private void btnGirisFormunaGit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş Ekrani Açılıyor...");
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }
    }
}
