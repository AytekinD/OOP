using _7_Interface_Lab.Guvenlik;

namespace _7_Interface_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<GirisKarti> girisKartlari = new List<GirisKarti>();

            GuvenlikGorevlisi BekciMurtaza = new GuvenlikGorevlisi();
            BekciMurtaza.AdSoyad = "Murtaza Kaya";
            KimlikKarti ahmet = new KimlikKarti() { TcNo="1234"};
            KimlikKarti mehmet = new KimlikKarti() { TcNo = "1456" };
            KimlikKarti ayse = new KimlikKarti() { TcNo = "789" };
            KimlikKarti fatma = new KimlikKarti() { TcNo = "dsad" };

            GirisKarti girisKarti1 = BekciMurtaza.GirisKartıver(ahmet);
            GirisKarti girisKarti2 = BekciMurtaza.GirisKartıver(mehmet);
            GirisKarti girisKarti3 = BekciMurtaza.GirisKartıver(ayse);
            GirisKarti girisKarti4 = BekciMurtaza.GirisKartıver(fatma);
            girisKartlari.Add(girisKarti1);
            girisKartlari.Add(girisKarti2);
            girisKartlari.Add(girisKarti3);
            girisKartlari.Add(girisKarti4);

            BekciMurtaza.KimlikleriListele();
            Console.WriteLine("***Kart Listesi****");
            BekciMurtaza.KimlikKartiVer(girisKarti1);
            BekciMurtaza.KimlikleriListele();
            Console.WriteLine("*** Kart Listesi****");

            BekciMurtaza.KimlikKartiVer(girisKarti2);
            BekciMurtaza.KimlikleriListele();

        }
    }
}