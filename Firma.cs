using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Zinciri_Otomasyonu
{
    public class Firma
    {
        public Adres FirmaAdresi { get; set; } = new Adres();

        public List<Sube> Subeler { get; set; } = new List<Sube>();

        public void SubeEkle(Sube sube) 
        {
            this.Subeler.Add(sube);
        }

        public List<Sube> SubeListele() 
        {
            return Subeler;
        }

        public Firma()
        {
            Sube sube1 = new Sube
            {
                SubeKodu = 1,
                SubeAdi = "BünSer",
            };
            sube1.SubeAdresi.Il = "BİTLİS";
            sube1.SubeAdresi.Ilce = "Tatvan";
            sube1.SubeAdresi.Mahalle = "Fatih Mah.";
            sube1.SubeAdresi.Cadde = "Yıldırım Cad.";
            SubeEkle(sube1);

            Sube sube2 = new Sube
            {
                SubeKodu = 2,
                SubeAdi = "BünSer",
            };
            sube2.SubeAdresi.Il = "BİTLİS";
            sube2.SubeAdresi.Ilce = "Tatvan";
            sube2.SubeAdresi.Mahalle = "Fuar Mah.";
            sube2.SubeAdresi.Cadde = "Huzur Cad.";
            SubeEkle(sube2);

            Sube sube3 = new Sube
            {
                SubeKodu = 3,
                SubeAdi = "BünSer",
            };
            sube3.SubeAdresi.Il = "BİTLİS";
            sube3.SubeAdresi.Ilce = "Tatvan";
            sube3.SubeAdresi.Mahalle = "Urtap Mah.";
            sube3.SubeAdresi.Cadde = "Dicle Cad.";
            SubeEkle(sube3);
        }
    }
}