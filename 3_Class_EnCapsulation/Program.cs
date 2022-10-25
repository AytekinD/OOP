namespace _3_Class_EnCapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Personel ali = new Personel();
            //ali.Ad = "Ali";
            //ali.Soyad = "Yilmaz";
            //string donendeger = ali.SetTcNo("12345678901");
            //Console.WriteLine(donendeger);
            //Personel ayse = new Personel()
            //{
            //    Ad = "Ayse",
            //    Soyad = "Kaya"
            //};

            Insan ali = new Insan("ali","Yilmaz");

            //Class icerisinden ulasilabilen set metoduna atama yapilamaz
            //Burasi hata vercektir
            //ali.Kilosu = 50;

            ali.HarclikAl(100);
            Console.WriteLine("Alinin biriktirdigi para:"+ali.BiriktirdigiPara); 
        }
    }
}