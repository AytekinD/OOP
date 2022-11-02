namespace _11_EventAraba
{
    public delegate void EventTip(int a, object sender);
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba("34 A 487",160);
            Polis polis = new Polis("Guven Kaya");
            Sofor sofor = new Sofor("Ali Yilmaz");
            araba.HareketEdiyorum += polis.HizKontrolEt;
            sofor.GazaBastim += araba.Calis;

            sofor.GazaBas();

            Console.ReadLine();

        }
    }
}