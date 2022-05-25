using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Zinciri_Otomasyonu
{
    public class Urun
    {
        public int UrunKodu { get; set; }

        public string UrunGrubu { get; set; }

        public string UrunAdi { get; set; }

        public int StokAdeti { get; set; }

        public DateTime UrunGirisTarihi { get; set; }

        public int UrunSubeKodu { get; set; }

        public int UrunTedarikciKodu { get; set; }

        public double UrunFiyati { get; set; }

        public DateTime SonIndirimliUrununTarihi { get; set; }

        public float KampanyaliUrunIndirimOrani { get; set; }

        public float IndirimOrani { get; set; }

        public void UrunIdirimUygula()
        {
            UrunFiyati = UrunFiyati - (UrunFiyati * IndirimOrani / 100);
        }
    }
}
