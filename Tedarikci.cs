using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Zinciri_Otomasyonu
{
    public class Tedarikci
    {
        public int TedarikciKodu { get; set; }

        public string TedarikciAdi { get; set; }

        public string TedarikciSoyadi { get; set; }

        public string TedarikciTuru { get; set; }

        public Adres TedarikciAdresi { get; set; } = new Adres();
    }
}
