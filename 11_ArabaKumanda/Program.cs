namespace _11_ArabaKumanda
{
    internal class Program
    {

        public delegate void EventTusaBasildi(string kod);
        static void Main(string[] args)
        {
            //Kumanda acma tusuna basilinca kapılar acilsin.
            //Eger baska bir kumanda ile basilirsa islem yapmasin.
            //Yani birden cok kumanda olabilir. Arac sadece birisine tepki verecek.

            //1.Faz : Anahtar usuna basilirsa arabanin kaplari acilir.

            Araba araba = new Araba("bmw123");
            Kumanda kumanda = new Kumanda("bmw123");
            Kumanda YanlisKumanda = new Kumanda("Audi4412");

            kumanda.AcmaTusunaBasildi += araba.SinyalAl;
            YanlisKumanda.AcmaTusunaBasildi += araba.SinyalAl;

            YanlisKumanda.Tusabas();
            kumanda.Tusabas();

        }
    }
}