using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.AlanHesabi
{
    public class Dikdortgen : AlanVeCevre
    {
        public int UzunKenar { get; set; }
        public int KisaKenar { get; set; }

        public override double Alan()
        {
            return UzunKenar * KisaKenar;
        }
        public override double Cevre()
        {
            return (UzunKenar+KisaKenar)*2;
        }
    }
}
