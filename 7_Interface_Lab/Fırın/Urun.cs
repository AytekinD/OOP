using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_Lab.Fırın
{
    public enum Birim
    {
        Adet,
        Gram,
        Mlitre
    }
    public class Urun
    {
        public string Isim { get; set; }
        public decimal Miktar { get; set; }
        public Birim birim { get; set; }

        public decimal Fiyat { get; set; }
    }
}
