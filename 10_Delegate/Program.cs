namespace _10_Delegate
{
    internal class Program
    {
        /*
            Delegate Metodlari temsil eden yapilardir

            Ornek tanimlama
        <Erisim Belirteci> delegate <TemsilEdilen MetodunGeriDonusTipi> <DelegeAdi> (Parametre)
            public         delegate     int     hesaplayici(int a, int b)

         */

        public delegate void hesaplayici(int a, int b);


        static void Main(string[] args)
        {
            hesaplayici hesap = new hesaplayici(Topla);
            hesap += Cikar;
            hesap += Carp;
            hesap += Bolme;
            hesap.Invoke(10, 5);
                        
        }
        public static void Topla(int a, int b)
        {
            Console.WriteLine("Topla:"+(a+b));
        }

        public static void Cikar(int a, int b) => Console.WriteLine("Cikar:"+(a-b)); 

        public static void Carp(int a, int b)
        {
            Console.WriteLine("Carpma:"+(a * b)); 
        }
        public static void Bolme(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine(0); 
            }
            Console.WriteLine("Bolme:"+(a/b));
        }

    }
}