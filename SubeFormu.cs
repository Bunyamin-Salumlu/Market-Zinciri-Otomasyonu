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
    public partial class frmSubeForm : Form
    {
        public frmSubeForm()
        {
            InitializeComponent();
        }

        public bool PatronGirisi = false;
        public bool MudurGirisi = false;
        Sube sube1 = new Sube();
        
        private void btnCalisanListele_Click(object sender, EventArgs e)
        {
            if (txtCalisanKodu.Text == "")
            {
                MessageBox.Show("Lütfen Çalışan Kodunu Boş Bırakmayınız.");
            }
            else
            {
                foreach (Calisan calisanlarim in sube1.CalisanListele())
                {
                    if (calisanlarim.CalisanKodu == Convert.ToInt64(txtCalisanKodu.Text))
                    {
                        txtCalisanAdi.Text = calisanlarim.CalisanAdi;
                        txtCalisanSoyadi.Text = calisanlarim.CalisanSoyadi;
                        txtCalisanSubeAdi.Text = calisanlarim.CalisanSubeAdi;
                        txtCalisanSubeKodu.Text = calisanlarim.CalisanSubeKodu.ToString();
                        txtCalisanUnvani.Text = calisanlarim.CalisanUnvani;
                        txtCalisanMaas.Text = calisanlarim.Maas.ToString();
                        txtCalisanIli.Text = calisanlarim.CalisanAdresi.Il;
                        txtCalisanIlcesi.Text = calisanlarim.CalisanAdresi.Ilce;
                        txtCalisanMahalle.Text = calisanlarim.CalisanAdresi.Mahalle;
                        txtCalisanCaddesi.Text = calisanlarim.CalisanAdresi.Cadde;
                        txtIseBaslamaTarih.Text = calisanlarim.IseBaslamaTarihi.ToString();
                        txtHaftalikIzinGunu.Text = calisanlarim.IzinliGunDurumu;
                        txtİzinHakkiMiktari.Text = calisanlarim.YillikIzin.ToString();
                    }
                }
            }
        }

        private void btnCalisanGuncelle_Click(object sender, EventArgs e)
        {
            if(txtCalisanYeniMaas.Text == "" || txtCalisanYeniUnvan.Text == "" || txtCalisanYeniSubeKodu.Text == "")
            {
                MessageBox.Show("Lütfen Yeni Maaş veya Yeni Ünvan veya Yeni Şube Alanını Boş Bırakmayınız.");
            }
            else
            {
                foreach (Calisan calisanlarim in sube1.CalisanListele())
                {
                    if (calisanlarim.CalisanKodu == Convert.ToInt64(txtCalisanKodu.Text))
                    {
                        calisanlarim.Maas = Convert.ToInt32(txtCalisanYeniMaas.Text);
                        calisanlarim.CalisanUnvani = txtCalisanYeniUnvan.Text;
                        calisanlarim.CalisanSubeKodu = Convert.ToInt32(txtCalisanYeniSubeKodu.Text);
                        txtCalisanMaas.Text = calisanlarim.Maas.ToString();
                        txtCalisanUnvani.Text = calisanlarim.CalisanUnvani;
                        txtCalisanSubeKodu.Text = calisanlarim.CalisanSubeKodu.ToString();
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
            else if(MudurGirisi == true)
            {
                islemFormu.MudurGirisi = true;
            }
            islemFormu.Show();
            this.Hide();
        }

        private void btnIzinVer_Click(object sender, EventArgs e)
        {
            if(txtİzinVerilenGunMiktari.Text == "")
            {
                MessageBox.Show("Lütfen Verilen İzin Miktarını Boş Bırakmayınız.");
            }
            else
            {
                foreach (Calisan calisanlarim in sube1.CalisanListele())
                {
                    if (calisanlarim.CalisanKodu == Convert.ToInt64(txtCalisanKodu.Text))
                    {
                        if (Convert.ToInt32(txtİzinVerilenGunMiktari.Text) <= calisanlarim.YillikIzin)
                        {
                            txtKalanIzin.Text = (calisanlarim.YillikIzin - Convert.ToInt32(txtİzinVerilenGunMiktari.Text)).ToString();
                            calisanlarim.YillikIzin = calisanlarim.YillikKalanIzni;
                            MessageBox.Show("Verdiğiniz İzin Uygulanmıştır.");
                        }
                    }
                }
            }
        }

        private void btnTedarikciListele_Click(object sender, EventArgs e)
        {
            if(txtTedarikciKodu.Text == "")
            {
                MessageBox.Show("Lütfen Tedarikçi Kodunu Boş Bırakmayınız.");
            }
            else
            {
                foreach (Tedarikci tedarikcilerim in sube1.TedarikciListele())
                {
                    if (tedarikcilerim.TedarikciKodu == Convert.ToInt64(txtTedarikciKodu.Text))
                    {
                        txtTedarikciAdi.Text = tedarikcilerim.TedarikciAdi;
                        txtTedarikciSoyadi.Text = tedarikcilerim.TedarikciSoyadi;
                        txtTedarikciTuru.Text = tedarikcilerim.TedarikciTuru;
                        txtTedarikciAdresIli.Text = tedarikcilerim.TedarikciAdresi.Il;
                        txtTedarikciAdresIlcesi.Text = tedarikcilerim.TedarikciAdresi.Ilce;
                        txtTedarikciAdresMahalle.Text = tedarikcilerim.TedarikciAdresi.Mahalle;
                        txtTedarikciAdresCaddesi.Text = tedarikcilerim.TedarikciAdresi.Cadde;
                    }
                }
            }
        }

        private void frmSubeForm_Load(object sender, EventArgs e)
        {
            if(MudurGirisi == true)
            {
                btnIzinVer.Enabled = false;
                btnCalisanGuncelle.Enabled = false;
            }
        }
    }
}
