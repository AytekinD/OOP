using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Araba
{
    public class Grandtour : Clio
    {
        public Grandtour(bool sisLambasi, double _fiyat, bool KoltukIsitma) : base(sisLambasi, _fiyat)
        {
        }

        public bool KoltukIsitma { get; set; }
        public bool ElektrikliKoltukAyari { get; set; }
        public override double FiyatHesap()
        {
            double Fiyat = base.FiyatHesap();

            if (KoltukIsitma)
            {
                Fiyat += 1000;
            }
            if (ElektrikliKoltukAyari)
            {
                Fiyat += 800;
            }


            return Fiyat;
        }
    }
}
