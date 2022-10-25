using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class_AnotherProject.Mobilyalar
{
    public enum Cesit
    {
        Tekli=1,
        İkili,
        Uclu,
        L_Koltuk
    }
    public class KoltukTakımı
    {
        public string Marka { get; set; }
        public string Ebat { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public string Malzeme { get; set; }
        public Cesit Cesit { get; set; }

    }
}
