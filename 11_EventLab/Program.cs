using _11_EventLab.Event_Bomba;

namespace _11_EventLab
{
    internal class Program
    {
        public delegate void EventTip();
        static void Main(string[] args)
        {

            #region Bomba Örnegi
            // Telefon gorusmasinde "Aliveli4950" kelimesi gecerse bomba patlasin

            Telefon telefon = new Telefon();
            Bomba bomba = new Bomba();
            telefon.KelimeKullanildi += bomba.Patla;

            telefon.Gorusme();

            

            #endregion

        }
    }
}