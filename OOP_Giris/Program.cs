using _2_Class_AnotherProject.Mobilyalar;
using OOP_Giris.Bilgisayar;

namespace OOP_Giris
{

    public class Personel   //erisim belirteci:public
    {
        public string Ad;
        public string Soyad;
        private string TcNo;
        public string eMail;
        public DateTime DogumTarihi;

        
    }

    public class Araba
    {
        public string Marka{ get; set; }
        public string Model { get; set; }
        public string Km { get; set; }
        public string Vites { get; set; }
        public string Yakıt { get; set; }
        public string Yil { get; set; }
        private string SaseNo { get; set; }
    }
    public class Yoklama
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KursNo { get; set; }
        public string KurumAd { get; set; }
        public List<DateTime> Gunler { get; set; }
        public List<bool> Imza { get; set; }

    }

    internal class Program
    {



        static void Main(string[] args)
        {

            #region Classlardan instance alma

            //1.Yol
            Ram ram = new Ram();
            //2.Yol
            Ram ram2 = new();
            ram2.Marka = "Samsung";
            ram2.kapasitesi = "8GB";
            //3.Yol
            Ram ram3 = new() { Marka = "Samsung", kapasitesi = "8GB" };

            HardDisk ssd = new() { Marka = "Seagete", Kapasite = "1TB" };

            AnaKart anaKart = new()
            {
                Marka = "Asus"
            };

            #endregion
            
            Masa masa = new Masa();
            

        }
    }
}