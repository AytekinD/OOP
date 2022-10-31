using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Personeller
{
    public enum Performans
    {
        Zayif=1,
        Orta,
        Iyi,
        CokIyi
    }

    public class ItMuduru:IT
    {
        public Performans Performans { get; set; }
        public override double MaasHesapla()
        {
            base.MaasHesapla();

            switch (Performans)
            {
                case Performans.Zayif:
                    Maas += Maas * (-0.1);
                    break;
                case Performans.Orta:
                    Maas += Maas * 0.1;
                    break;
                case Performans.Iyi:
                    Maas += Maas * 0.25;
                    break;
                case Performans.CokIyi:
                    Maas += Maas * 0.5;
                    break;
                default:
                    break;
            };
            return Maas;
        }
    }
}
