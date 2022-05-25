using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Zinciri_Otomasyonu
{
    public class Mudur : Calisan
    {
        public override void maasHesapla()
        {
            base.maasHesapla();//üst sınıftan 3200 aldı üzerine 500 tl ekledi
            Maas  +=  500;
        }
    }
}
