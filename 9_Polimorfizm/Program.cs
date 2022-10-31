using _9_Polimorfizm.AlanHesabi;

namespace _9_Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare();
            kare.Kenar = 5;
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 5;
            dikdortgen.UzunKenar = 15;

            Console.WriteLine("Dikdortgen alani:"+dikdortgen.Alan());

            Console.WriteLine("Kare Alani:" + kare.Alan());
            Daire daire = new Daire();
            daire.YariCap = 5;
            Console.WriteLine("Daire Alani:"+ daire.Alan());


        }
    }
}