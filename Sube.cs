using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Zinciri_Otomasyonu
{
    public class Sube
    {
        public int SubeKodu { get; set; }

        public string SubeAdi { get; set; }

        public Adres SubeAdresi { get; set; } = new Adres();

        public List<Tedarikci> Tedarikciler { get; set; } = new List<Tedarikci>();

        public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();

        public List<Urun> Urunler { get; set; } = new List<Urun>();

        public void TedarikciEkle(Tedarikci tedarikci)
        {
            this.Tedarikciler.Add(tedarikci);
        }

        public List<Tedarikci> TedarikciListele()
        {
            return Tedarikciler;
        }

        public void calisanlariSil(Calisan calisan)
        {
            Calisanlar.Remove(calisan);
        }

        public void CalisanEkle(Calisan calisan)
        {
            this.Calisanlar.Add(calisan);
            calisan.CalisanAdresiniKontrolEt();
            if (calisan.CalisanAdresiniKontrolEt() == false)
            {
                calisanlariSil(calisan);
                MessageBox.Show("Adres Bilgileri Boş Geçildiği için Kayıt silindi!!");
            }
        }

        public List<Calisan> CalisanListele()
        {            
            return Calisanlar;
        }

        public void UrunEkle (Urun urun)
        {
            this.Urunler.Add(urun);
        }

        public List<Urun> UrunListele()
        {
            return Urunler;
        }

        public Sube()
        {
            Mudur mudur1 = new Mudur
            {
                CalisanKodu = 5101,
                CalisanAdi = "Ahmet",
                CalisanSoyadi = "YILMAZ",
                CalisanUnvani = "Müdür",
                CalisanSubeKodu = 1,
                CalisanSubeAdi = "BünSer Market"
            };
            mudur1.CalisanAdresi.Il = "BİTLİS";
            mudur1.CalisanAdresi.Ilce = "Tatvan";
            mudur1.CalisanAdresi.Mahalle = "Hidayet Mah.";
            mudur1.CalisanAdresi.Cadde = "Seymen Cad.";
            mudur1.IseBaslamaTarihi = new DateTime(2020, 05, 06);
            mudur1.IzinliGunDurumu = "Salı";
            mudur1.maasHesapla();
            CalisanEkle(mudur1);  

            MudurYardimci mudurYardimci1 = new MudurYardimci
            {
                CalisanKodu = 5102,
                CalisanAdi = "Taner",
                CalisanSoyadi = "ASLAN",
                CalisanUnvani = "Müdür Yardımcısı",
                CalisanSubeKodu = 1,
                CalisanSubeAdi = "BünSer Market"
            };
            mudurYardimci1.CalisanAdresi.Il = "BİTLİS";
            mudurYardimci1.CalisanAdresi.Ilce = "Mutki";
            mudurYardimci1.CalisanAdresi.Mahalle = "Esberk Mah.";
            mudurYardimci1.CalisanAdresi.Cadde = "Sevgi Cad.";
            mudurYardimci1.IseBaslamaTarihi = new DateTime(2020, 01, 15);
            mudurYardimci1.IzinliGunDurumu = "Perşembe";
            mudurYardimci1.maasHesapla();
            CalisanEkle(mudurYardimci1);

            Kasiyer kasiyer1 = new Kasiyer
            {
                CalisanKodu = 5103,
                CalisanAdi = "Mustafa",
                CalisanSoyadi = "ERBAŞ",
                CalisanUnvani = "Kasiyer",
                CalisanSubeKodu = 1,
                CalisanSubeAdi = "BünSer Market"
            };
            kasiyer1.CalisanAdresi.Il = "BİTLİS";
            kasiyer1.CalisanAdresi.Ilce = "Tatvan";
            kasiyer1.CalisanAdresi.Mahalle = "Sahil Mah.";
            kasiyer1.CalisanAdresi.Cadde = "İşletme Cad.";
            kasiyer1.IseBaslamaTarihi = new DateTime(2020, 02, 12);
            kasiyer1.IzinliGunDurumu = "Cuma";
            kasiyer1.maasHesapla();
            CalisanEkle(kasiyer1);

            Mudur mudur2 = new Mudur
            {
                CalisanKodu = 5104,
                CalisanAdi = "İsmail",
                CalisanSoyadi = "BULUT",
                CalisanUnvani = "Müdür",
                CalisanSubeKodu = 2,
                CalisanSubeAdi = "BünSer Market"
            };
            mudur2.CalisanAdresi.Il = "BİTLİS";
            mudur2.CalisanAdresi.Ilce = "Tatvan";
            mudur2.CalisanAdresi.Mahalle = "Fatih Mah.";
            mudur2.CalisanAdresi.Cadde = "Kartal Cad.";
            mudur2.IseBaslamaTarihi = new DateTime(2020, 03, 20);
            mudur2.IzinliGunDurumu = "Pazartesi";
            mudur2.maasHesapla();
            CalisanEkle(mudur2);

            MudurYardimci mudurYardimci2 = new MudurYardimci
            {
                CalisanKodu = 5105,
                CalisanAdi = "Muhammed",
                CalisanSoyadi = "AYAZ",
                CalisanUnvani = "Müdür yardımcısı",
                CalisanSubeKodu = 2,
                CalisanSubeAdi = "BünSer Market"
            };
            mudurYardimci2.CalisanAdresi.Il = "BİTLİS";
            mudurYardimci2.CalisanAdresi.Ilce = "Hizan";
            mudurYardimci2.CalisanAdresi.Mahalle = "Kahraman Mah.";
            mudurYardimci2.CalisanAdresi.Cadde = "Cezayir Cad.";
            mudurYardimci2.IseBaslamaTarihi = new DateTime(2020, 02, 25);
            mudurYardimci2.IzinliGunDurumu = "Çarşamba";
            mudurYardimci2.maasHesapla();
            CalisanEkle(mudurYardimci2);

            Kasiyer kasiyer2 = new Kasiyer
            {
                CalisanKodu = 5106,
                CalisanAdi = "Musa",
                CalisanSoyadi = "IŞIKLI",
                CalisanUnvani = "Kasiyer",
                CalisanSubeKodu = 2,
                CalisanSubeAdi = "BünSer Market"
            };
            kasiyer2.CalisanAdresi.Il = "BİTLİS";
            kasiyer2.CalisanAdresi.Ilce = "Güroymak";
            kasiyer2.CalisanAdresi.Mahalle = "Erentepe Mah.";
            kasiyer2.CalisanAdresi.Cadde = "Kurtuluş Cad.";
            kasiyer2.IseBaslamaTarihi = new DateTime(2020, 06, 04);
            kasiyer2.IzinliGunDurumu = "Salı";
            kasiyer2.maasHesapla();
            CalisanEkle(kasiyer2);

            Mudur mudur3 = new Mudur
            {
                CalisanKodu = 5107,
                CalisanAdi = "Berken",
                CalisanSoyadi = "AVCI",
                CalisanUnvani = "Müdür",
                CalisanSubeKodu = 3,
                CalisanSubeAdi = "BünSer Market"
            };
            mudur3.CalisanAdresi.Il = "BİTLİS";
            mudur3.CalisanAdresi.Ilce = "Ahlat";
            mudur3.CalisanAdresi.Mahalle = "Erkizan Mah.";
            mudur3.CalisanAdresi.Cadde = "Selçuklu Cad.";
            mudur3.IseBaslamaTarihi = new DateTime(2020, 05, 27);
            mudur3.IzinliGunDurumu = "Perşembe";
            mudur3.maasHesapla();
            CalisanEkle(mudur3);

            MudurYardimci mudurYardimci3 = new MudurYardimci
            {
                CalisanKodu = 5108,
                CalisanAdi = "Ömer",
                CalisanSoyadi = "ŞAFAK",
                CalisanUnvani = "Müdür Yardımcısı",
                CalisanSubeKodu = 3,
                CalisanSubeAdi = "BünSer Market"
            };
            mudurYardimci3.CalisanAdresi.Il = "BİTLİS";
            mudurYardimci3.CalisanAdresi.Ilce = "Ahlat";
            mudurYardimci3.CalisanAdresi.Mahalle = "Tepecik Mah.";
            mudurYardimci3.CalisanAdresi.Cadde = "Çetin Emeç Cad.";
            mudurYardimci3.IseBaslamaTarihi = new DateTime(2020, 04, 19);
            mudurYardimci3.IzinliGunDurumu = "Çarşamba";
            mudurYardimci3.maasHesapla();
            CalisanEkle(mudurYardimci3);

            Kasiyer kasiyer3 = new Kasiyer
            {
                CalisanKodu = 5109,
                CalisanAdi = "Nevzat",
                CalisanSoyadi = "EKİN",
                CalisanUnvani = "Kasiyer",
                CalisanSubeKodu = 3,
                CalisanSubeAdi = "BünSer Market"
            };
            kasiyer3.CalisanAdresi.Il = "BİTLİS";
            kasiyer3.CalisanAdresi.Ilce = "Yenişehir";
            kasiyer3.CalisanAdresi.Mahalle = "Alangör Mah.";
            kasiyer3.CalisanAdresi.Cadde = "Bağlar Cad.";
            kasiyer3.IseBaslamaTarihi = new DateTime(2020, 02, 20);
            kasiyer3.IzinliGunDurumu = "Pazartesi";
            kasiyer3.maasHesapla();
            CalisanEkle(kasiyer3);

            Tedarikci tedarikci1 = new Tedarikci
            {
                TedarikciAdi = "Ali",
                TedarikciSoyadi = "Şimşek",
                TedarikciKodu = 1,
                TedarikciTuru = "Temizlik"
            };
            tedarikci1.TedarikciAdresi.Il = "BİTLİS";
            tedarikci1.TedarikciAdresi.Ilce = "Adilcevaz";
            tedarikci1.TedarikciAdresi.Mahalle = "Adil Mah.";
            tedarikci1.TedarikciAdresi.Cadde = "İstikrar Cad.";
            TedarikciEkle(tedarikci1);

            Tedarikci tedarikci2 = new Tedarikci
            {
                TedarikciAdi = "Mehmet",
                TedarikciSoyadi = "Yaman",
                TedarikciKodu = 2,
                TedarikciTuru = "Gıda"
            };
            tedarikci2.TedarikciAdresi.Il = "İSTANBUL";
            tedarikci2.TedarikciAdresi.Ilce = "Bağcılar";
            tedarikci2.TedarikciAdresi.Mahalle = "Yavuz Selim Mah.";
            tedarikci2.TedarikciAdresi.Cadde = "Ana Cad.";
            TedarikciEkle(tedarikci2);

            Tedarikci tedarikci3 = new Tedarikci
            {
                TedarikciAdi = "Eşref",
                TedarikciSoyadi = "Demir",
                TedarikciKodu = 3,
                TedarikciTuru = "Haftalık Kampanya"
            };
            tedarikci3.TedarikciAdresi.Il = "BATMAN";
            tedarikci3.TedarikciAdresi.Ilce = "Kozluk";
            tedarikci3.TedarikciAdresi.Mahalle = "Komando Mah.";
            tedarikci3.TedarikciAdresi.Cadde = "Çetin Emeç Cad.";
            TedarikciEkle(tedarikci3);

            Temizlik temizlik1 = new Temizlik
            {
                UrunKodu = 110,
                StokAdeti = 75,
                UrunGrubu = "Temizlik Ürünü",
                UrunAdi = "Deterjan",
                UrunFiyati = 34.99,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 1,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 1
            };
            UrunEkle(temizlik1);

            Temizlik temizlik2 = new Temizlik
            {
                UrunKodu = 111,
                StokAdeti = 43,
                UrunGrubu = "Temizlik Ürünü",
                UrunAdi = "Cif Ultra",
                UrunFiyati = 15.75,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 2,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 1
            };
            UrunEkle(temizlik2);

            Gida gida1 = new Gida
            {
                UrunKodu = 112,
                StokAdeti = 38,
                UrunGrubu = "Gıda Ürünü",
                UrunAdi = "Bitkisel Macun",
                UrunFiyati = 107.10,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 3,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 2
            };
            UrunEkle(gida1);

            Gida gida2 = new Gida
            {
                UrunKodu = 113,
                StokAdeti = 35,
                UrunGrubu = "Gıda Ürünü",
                UrunAdi = "Arifoğlu Zencefil",
                UrunFiyati = 21.99,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 1,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 2
            };
            UrunEkle(gida2);

            Kampanya kampanya1 = new Kampanya
            {
                UrunKodu = 114,
                StokAdeti = 50,
                UrunGrubu = "Haftalık Kampanya Ürünü",
                UrunAdi = "64 GB USB Bellek",
                UrunFiyati = 59.90,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 2,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 3
            };
            UrunEkle(kampanya1);

            Kampanya kampanya2 = new Kampanya
            {
                UrunKodu = 115,
                StokAdeti = 40,
                UrunGrubu = "Haftalık Kampanya Ürünü",
                UrunAdi = "Logitech Mouse",
                UrunFiyati = 89.90,
                SonIndirimliUrununTarihi = DateTime.Now,
                UrunSubeKodu = 3,
                UrunGirisTarihi = DateTime.Today,
                UrunTedarikciKodu = 3
            };
            UrunEkle(kampanya2);
        }
    }
}
