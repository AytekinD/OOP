using static _11_EventLab.Program;

namespace _11_EventLab.Event_Bomba
{
    internal class Telefon
    {
        public event EventTip KelimeKullanildi;
        public Telefon()
        {
        }

        public void Gorusme()
        {

            Console.WriteLine("Aloo..");
            string input = Console.ReadLine();

            if (input.Contains("Aliveli4950"))
            {
                KelimeKullanildi();
            }
            else if(input=="Kapat")
            {
                return;
            }
            Gorusme();
        }

    }
}