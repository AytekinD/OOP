using _7_Interface_Lab.FaturaKesim;
using _7_Interface_Lab.Fırın;
using _7_Interface_Lab.Guvenlik;
using Birim = _7_Interface_Lab.Fırın.Birim;

namespace _7_Interface_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region KaraFirin
            //Usta aliUsta = new Usta();
            //aliUsta.Isim = "Ali Yilmaz";

            //Urun Un = new Urun();
            //Un.Isim = "Beyaz Un";
            //Un.birim = Birim.Gram;
            //Un.Miktar = 3000;
            //Un.Fiyat = 1;

            //Urun Tuz = new Urun();
            //Tuz.Isim = "Kaya Tuzu";
            //Tuz.birim = Birim.Gram;
            //Tuz.Miktar = 200;
            //Tuz.Fiyat = 1;

            //Urun Su = new Urun();
            //Su.Isim = "Musluk Suyu";
            //Su.birim = Birim.Gram;
            //Su.Miktar = 200;
            //Su.Fiyat= 1;

            //List<Urun> urunler = new List<Urun>();
            //urunler.Add(Su);
            //urunler.Add(Tuz);
            //urunler.Add(Un);

            //YogurmaMakinasi yogurmaMakinesi = new YogurmaMakinasi();
            //yogurmaMakinesi.MakinaAdi = "Bosch";

            //IYogur yogurucu = new Usta();
            //IYogur makinaYogurucu = new YogurmaMakinasi();
            //Firin karafirin = new Firin();

            ////karafirin.EkmekPisir(urunler, aliUsta);
            ////karafirin.EkmekPisir(urunler, yogurmaMakinesi);

            //karafirin.EkmekPisir(urunler,yogurmaMakinesi);

            #endregion

            #region Guvenlik

            //List<GirisKarti> girisKartlari = new List<GirisKarti>();

            //GuvenlikGorevlisi BekciMurtaza = new GuvenlikGorevlisi();
            //BekciMurtaza.AdSoyad = "Murtaza Kaya";
            //KimlikKarti ahmet = new KimlikKarti() { TcNo = "1234" };
            //KimlikKarti mehmet = new KimlikKarti() { TcNo = "1456" };
            //KimlikKarti ayse = new KimlikKarti() { TcNo = "789" };
            //KimlikKarti fatma = new KimlikKarti() { TcNo = "dsad" };

            //GirisKarti girisKarti1 = BekciMurtaza.GirisKartıver(ahmet);
            //GirisKarti girisKarti2 = BekciMurtaza.GirisKartıver(mehmet);
            //GirisKarti girisKarti3 = BekciMurtaza.GirisKartıver(ayse);
            //GirisKarti girisKarti4 = BekciMurtaza.GirisKartıver(fatma);
            //girisKartlari.Add(girisKarti1);
            //girisKartlari.Add(girisKarti2);
            //girisKartlari.Add(girisKarti3);
            //girisKartlari.Add(girisKarti4);

            //BekciMurtaza.KimlikleriListele();
            //Console.WriteLine("***Kart Listesi****");
            //BekciMurtaza.KimlikKartiVer(girisKarti1);
            //BekciMurtaza.KimlikleriListele();
            //Console.WriteLine("*** Kart Listesi****");

            //BekciMurtaza.KimlikKartiVer(girisKarti2);
            //BekciMurtaza.KimlikleriListele();

            #endregion

            #region Fatura Kesim

            //List<FaturaUrun> faturaUruns = new List<FaturaUrun>();

            //FaturaMaster faturaMaster = new FaturaMaster();
            //faturaMaster.Personel = new Personel() { TcNo="1234654",AdSoyad="asdasd"};
            //faturaMaster.Musteri = new Musteri() { TcNo = "4687862", AdSoyad = "dsdsads" };
            //FaturaUrun urun = new FaturaUrun() 
            //{
            //    Birim=FaturaKesim.Birim.Adet,
            //    UrunAdi = "Ekmek",
            //    Adet = 10,
            //    Fiyat = 5
            //};
            //faturaUruns.Add(urun);

            //urun = new FaturaUrun()
            //{
            //    Birim = FaturaKesim.Birim.gram,
            //    UrunAdi = "Peynir",
            //    Adet = 540,
            //    Fiyat = 50
            //};
            //faturaUruns.Add(urun);


            //FaturaMaster fat = new FaturaMaster();
            //try
            //{

            //    //bool sonuc = faturaMaster.FaturaKes();
            //    //if (sonuc)
            //    //{
            //    //    Console.WriteLine("Fatura Kesilmistir.");
            //    //}
            //    //fat.FaturaKes(new Personel(),new Musteri(),faturaUruns);

            //    /*
            //        Faturamasteryeni classindan bir instance alinabilmaesi icin constructer icerisine 
            //        gcilecek bagimli claslarinvar olmasi gerekir.
            //        Yoksa bu classtan instance alinmaz.
            //     */
            //    //1.Nesne
            //    Musteri musteri = new Musteri() { TcNo="21345", AdSoyad="hşlkhlşk"};
            //    Personel personel = new Personel() { TcNo="124857897", AdSoyad = "sda"};

            //    List<FaturaUrun> faturaUrunleri = new();
            //    faturaUrunleri.Add(new FaturaUrun() { UrunAdi="Peynir",Fiyat=100});
            //    faturaUrunleri.Add(new FaturaUrun() { UrunAdi = "Ekmek",Fiyat = 5 });
            //    faturaUrunleri.Add(new FaturaUrun() { UrunAdi = "Su",Fiyat = 3 });


            //    FaturaMasterYeni masterYeni = new FaturaMasterYeni(musteri,personel,faturaUrunleri);

            //    Console.WriteLine( masterYeni.ToString());

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            #endregion

        }
    }
}