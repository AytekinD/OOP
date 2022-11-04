namespace _14_ActionDelegate
{
    internal class Program
    {
        delegate void NormalDelegate(long sayi);
        static void Main(string[] args)
        {
            NormalDelegate kareal;
            kareal = karesiniAl;
        }
        private static void karesiniAl(long sayi)
        {
            Console.WriteLine(Math.Pow(sayi,2).ToString());
        }
    }
}