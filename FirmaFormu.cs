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
    public partial class frmFirmaForm : Form
    {
        public frmFirmaForm()
        {
            InitializeComponent();
        }

        private void btnSubeListele_Click(object sender, EventArgs e)
        {
            Firma firma = new Firma();

            if (txtSubeKodu.Text == "")
            {
                MessageBox.Show("Lütfen Şube Kodunu Boş Bırakmayınız.");
            }
            else
            {
                foreach (Sube Subelerim in firma.SubeListele())
                {
                    if (Subelerim.SubeKodu == Convert.ToInt32(txtSubeKodu.Text))
                    {
                        txtSubeAdi.Text = Subelerim.SubeAdi;
                        txtSubeAdresIli.Text = Subelerim.SubeAdresi.Il;
                        txtSubeAdresIlcesi.Text = Subelerim.SubeAdresi.Ilce;
                        txtSubeAdresMahallesi.Text = Subelerim.SubeAdresi.Mahalle;
                        txtSubeAdresCaddesi.Text = Subelerim.SubeAdresi.Cadde;
                    }
                }
            }
        }
        private void btnIslemFormunaGit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlemler Ekranı Açılıyor...");
            frmIslemForm islemFormu = new frmIslemForm();
            islemFormu.Show();
            this.Hide();
        }
    }
}
