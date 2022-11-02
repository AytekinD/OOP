namespace _11_EventAraba
{
    internal class Araba
    {
        private int maxHiz;
        public event EventTip HareketEdiyorum;

        public Araba(string plaka, int maxHiz)
        {
            Plaka = plaka;
            this.maxHiz = maxHiz;
        }
        
        public string Plaka { get; private set; }
        public bool ArabaCAlisiyorMu { get; set; }
        public Sofor Sofor { get;  set; }

        public void Calis(int gazOrani, object gazaBasan)
        {
            Sofor = (Sofor)gazaBasan;
            int hiz = HizHesapla(gazOrani);
            ArabaCAlisiyorMu = true;
            Console.WriteLine($"Araba {hiz} hizla gidiyor");
            while (ArabaCAlisiyorMu)
            {
                HareketEdiyorum(hiz,this);
            }
        }

        private int HizHesapla(int gazOrani)
        {
            return maxHiz * gazOrani / 100;
        }
    }
}