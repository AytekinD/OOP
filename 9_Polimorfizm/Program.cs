using _9_Polimorfizm.AlanHesabi;
using _9_Polimorfizm.Personeller;

namespace _9_Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AlanHesabı

            //Kare kare = new Kare();
            //kare.Kenar = 5;
            //Dikdortgen dikdortgen = new Dikdortgen();
            //dikdortgen.KisaKenar = 5;
            //dikdortgen.UzunKenar = 15;

            //Console.WriteLine("Dikdortgen alani:"+dikdortgen.Alan());

            //Console.WriteLine("Kare Alani:" + kare.Alan());
            //Daire daire = new Daire();
            //daire.YariCap = 5;
            //Console.WriteLine("Daire Alani:" + daire.Alan());

            #endregion

            #region Maas Hesabi

            Sekreter sekreter = new Sekreter() 
            {
                AdSoyad="Ayse",
                CocukSayisi=4,
                EgitimDurumu=EgitimDurumu.Lise
            };

            IT yazilimci = new IT()
            {
                AdSoyad = "Ali",
                CocukSayisi = 2,
                EgitimDurumu = EgitimDurumu.YuksekLisans,
                Seviye = Seviye.Orta
            };
            ItMuduru ıtMuduru = new ItMuduru()
            {
                AdSoyad = "Fatma",
                CocukSayisi = 3,
                EgitimDurumu = EgitimDurumu.Doktora,
                Performans = Performans.Iyi,
                Seviye = Seviye.Usta
            };

            Console.WriteLine("Sekreter Maasi:" + sekreter.MaasHesapla());
            Console.WriteLine("ORta YAzilimci Maasi:"+yazilimci.MaasHesapla());
            Console.WriteLine("Usta YAzilimci Maasi:" + ıtMuduru.MaasHesapla());


            #endregion




        }
    }
}