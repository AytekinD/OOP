using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Personeller
{
    public enum Seviye
    {
        Baslangic=1,
        Orta,
        Usta
    }

    public class IT:BasePersonel
    {
        public Seviye Seviye { get; set; }
        public override double MaasHesapla()
        {
            base.MaasHesapla();

            switch (Seviye)
            {
                case Seviye.Baslangic:
                    Maas += Maas * 0.1;
                    break;
                case Seviye.Orta:
                    Maas += Maas * 0.2;
                    break;
                case Seviye.Usta:
                    Maas += Maas * 0.5;
                    break;
                default:
                    break;
            }
            return Maas;
        }
    }
}
