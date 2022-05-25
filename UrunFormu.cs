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
    public partial class frmUrunForm : Form
    {
        public frmUrunForm()
        {
            InitializeComponent();
        }
        public bool PatronGirisi = false;
        public bool MudurGirisi = false;
        public bool MudurYarGirisi = false;
        Sube sube = new Sube();

        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            if (txtUrunKodu.Text == "")
            {
                MessageBox.Show("Lütfen Ürün Kodunu Boş Bırakmayınız.");
            }
            else
            {
                foreach (Urun Urunlerim in sube.UrunListele())
                {
                    if (Urunlerim.UrunKodu == Convert.ToInt32(txtUrunKodu.Text))
                    {
                        txtUrunGrubu.Text = Urunlerim.UrunGrubu;
                        txtUrunAdi.Text = Urunlerim.UrunAdi;
                        txtStokAdeti.Text = Urunlerim.StokAdeti.ToString();
                        txtUrunGirisTarihi.Text = Urunlerim.UrunGirisTarihi.ToString();
                        txtUrunSubeKod.Text = Urunlerim.UrunSubeKodu.ToString();
                        txtUrunTedarikciKodu.Text = Urunlerim.UrunTedarikciKodu.ToString();
                        txtUrunFiyati.Text = Urunlerim.UrunFiyati.ToString();
                        txtSonIndirimliUrununTarihi.Text = Urunlerim.SonIndirimliUrununTarihi.ToString();
                        txtIndirimOrani.Text = Urunlerim.IndirimOrani.ToString();
                        txtKampanyaliIndirimOrani.Text = Urunlerim.KampanyaliUrunIndirimOrani.ToString();
                        txtKampanyaliIndirimOrani.Enabled = false;
                    }
                    if (txtUrunTedarikciKodu.Text == 3.ToString())
                    {
                        txtKampanyaliIndirimOrani.Enabled = true;
                    }
                }
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if(txtIndirimOrani.Text == "" && txtKampanyaliIndirimOrani.Text == "")
            {
                MessageBox.Show("Lütfen İndirim Oranı Alanını Boş Bırakmayınız.");
            }
            else
            {
                foreach (Urun Urunlerim in sube.UrunListele())
                {
                    if (Urunlerim.UrunKodu == Convert.ToInt32(txtUrunKodu.Text))
                    {
                        Urunlerim.IndirimOrani = Convert.ToInt32(txtIndirimOrani.Text) + Convert.ToInt32(txtKampanyaliIndirimOrani.Text);
                        Urunlerim.UrunIdirimUygula();
                        txtUrunFiyati.Text = Urunlerim.UrunFiyati.ToString();
                        MessageBox.Show("Güncelleme İşlemi Başarıyla Gercekleştirilmiştir.");
                    }
                }
            }
        }

        private void btnIslemFormunaGit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlemler Ekranı Açılıyor...");
            frmIslemForm islemFormu = new frmIslemForm();
            if(PatronGirisi == true)
            {
                islemFormu.PatronGirisi = true;
            }
            else if (MudurGirisi == true)
            {
                islemFormu.MudurGirisi = true;
            }
            else if (MudurYarGirisi == true)
            {
                islemFormu.MudurYarGirisi = true;
            }
            islemFormu.Show();
            this.Hide();
        }

        private void frmUrunForm_Load(object sender, EventArgs e)
        {
            if(MudurGirisi == true)
            {
                txtIndirimOrani.Enabled = false;
            }

            else if(MudurYarGirisi == true)
            {
                btnUrunGuncelle.Enabled = false;
                txtIndirimOrani.Enabled = false;
            }
        }
    }
}
