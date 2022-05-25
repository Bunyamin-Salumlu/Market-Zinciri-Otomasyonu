using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Zinciri_Otomasyonu
{
    public class MudurYardimci : Calisan
    {
       public override void maasHesapla()
        {
            base.maasHesapla(); // üst sınıftan 3200 tl aldı ve üzerine 300 tl ekledi
            Maas  +=  300;     //sıkıntı yok gibi
        } 
    }
}
