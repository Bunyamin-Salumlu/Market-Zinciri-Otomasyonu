using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Zinciri_Otomasyonu
{
    public class Calisan
    {
        public int CalisanKodu { get; set; }

        public string CalisanAdi { get; set; }

        public string CalisanSoyadi { get; set; }

        public string CalisanUnvani { get; set; }

        public int CalisanSubeKodu { get; set; }

        public string CalisanSubeAdi { get; set; }

        public DateTime IseBaslamaTarihi { get; set; }

        public string IzinliGunDurumu { get; set; }

        public int YillikIzin { get; set; }

        public int YillikKalanIzni { get; set; }

        public Adres CalisanAdresi { get; set; }

        public Calisan()
        {
            this.CalisanAdresi = new Adres();
            this.YillikIzin = 14;
        }

        private decimal maas;
        public virtual decimal Maas
        {
            get 
            {
                return maas;
            }
            set
            {
                if (value >= this.maas)
                {
                    this.maas = value;
                }
                else
                {
                    MessageBox.Show("Girilen maaş, eski maaştan küçük olamaz.!");
                }
            }
        }

        public Boolean CalisanAdresiniKontrolEt()
        {
            if(CalisanAdresi.Il == "" && CalisanAdresi.Il == null || 
               CalisanAdresi.Ilce == "" && CalisanAdresi.Ilce == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public virtual void maasHesapla()
        {
            Maas = 3200; 
        }
    }
}
