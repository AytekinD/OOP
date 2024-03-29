﻿using _9_Polimorfizm.AlanHesabi;
using _9_Polimorfizm.Araba;
using _9_Polimorfizm.Emlak;
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

            //Sekreter sekreter = new Sekreter() 
            //{
            //    AdSoyad="Ayse",
            //    CocukSayisi=4,
            //    EgitimDurumu=EgitimDurumu.Lise
            //};

            //IT yazilimci = new IT()
            //{
            //    AdSoyad = "Ali",
            //    CocukSayisi = 2,
            //    EgitimDurumu = EgitimDurumu.YuksekLisans,
            //    Seviye = Seviye.Orta
            //};
            //ItMuduru ıtMuduru = new ItMuduru()
            //{
            //    AdSoyad = "Fatma",
            //    CocukSayisi = 3,
            //    EgitimDurumu = EgitimDurumu.Doktora,
            //    Performans = Performans.Iyi,
            //    Seviye = Seviye.Usta
            //};

            //Console.WriteLine("Sekreter Maasi:" + sekreter.MaasHesapla());
            //Console.WriteLine("ORta YAzilimci Maasi:"+yazilimci.MaasHesapla());
            //Console.WriteLine("Usta YAzilimci Maasi:" + ıtMuduru.MaasHesapla());

            #endregion

            #region Emlak

            //HOCANİN YAPTİGİ FARKLİYDİ.


            //Kiraci Ali = new Kiraci()
            //{
            //    AdSoyad = "Ali Veli",
            //    Kimden = Kimden.Emlakci,
            //    m2 = 80,
            //    Esyali = true,
            //    Site = true,
            //    BulunduguKat = 3,
            //    IlanNo = "1548755",
            //    Aidat = 250
            //};
            //Console.WriteLine("Aylik Kira:" + Ali.KiraHesapla());
            //Console.WriteLine("Giris Masrafi:" + Ali.GirisMasrafi());
            //Console.WriteLine(Ali.ToString());

            #endregion

            Grandtour clio = new Grandtour(true,450000,true)
            {
                Yil = 2019,
                ElektrikliKoltukAyari = true,
                
                
                Model = Model.Clio,
                Km = 75000
            };

            Console.WriteLine("Clio Fiyat:"+ clio.FiyatHesap());


        }
    }
}