using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AbstractClass
{
    public abstract class BaseHayvan
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        

        public abstract int AyakSayisi { get; set; }
        public abstract string Sescikar();
        public override string ToString()
        {
            return Ad + " " + Yas;
        }

    }
}
