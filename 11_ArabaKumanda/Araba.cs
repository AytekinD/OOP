using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ArabaKumanda
{
    internal class Araba
    {
        private readonly string _kod;
        public Araba(string kod)
        {
            this._kod = kod;
        }
        public void SinyalAl(string kod)
        {
            if (_kod == kod)
            {
                KapilariAc();
            }
            else
            {
                Console.WriteLine($"Yanlis kumandadan sinyal alindi. Alinan kod: {kod}");
            }
        }

        private void KapilariAc()
        {
            Console.WriteLine($"Kapilar {_kod} Acildi");
        }
    }
}
