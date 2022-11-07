using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _11_ArabaKumanda.Program;

namespace _11_ArabaKumanda
{
    internal class Kumanda
    {
        private readonly string _kod;

        public Kumanda(string kod)
        {
            this._kod = kod;
        }

        public event EventTusaBasildi AcmaTusunaBasildi;
        public void Tusabas()
        {
            Console.WriteLine($"{_kod} kodlu kumandaya basildi.");
            AcmaTusunaBasildi(_kod);
        }
    }
}
