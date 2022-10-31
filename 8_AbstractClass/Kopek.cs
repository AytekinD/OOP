using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AbstractClass
{
    public class Kopek : BaseHayvan
    {
        public override int AyakSayisi { get; set; }

        public override string Sescikar()
        {
            return "Havv";
        }
    }
}
