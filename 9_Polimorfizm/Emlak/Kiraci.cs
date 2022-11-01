using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Emlak
{
    public class Kiraci : BaseKonut
    {
        public string AdSoyad { get; set; }

        public override string ToString()
        {
            return "AdSoyad:" + AdSoyad + "\n" + "IlanNo:" + IlanNo + "\n" + "m2:" + m2 + "\n" + "Esyali:" + Esyali + "\n" + "Site:" + Site + "\n" + "Bulunduğu Kat:"  + BulunduguKat + "\n" + "Kimden:" + Kimden.Emlakci;
        }
    }
}
