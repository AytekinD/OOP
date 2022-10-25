using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class_AnotherProject.Mobilyalar
{
    public class YemekTakımı
    {
        public Masa Masa { get; set; }
        public List<Sandalye> Sandalye { get; set; }
        public YemekTakımı(int sandeleSayisi)
        {
            Sandalye = new List<Sandalye>();
            for (int i = 0; i < sandeleSayisi; i++)
            {
                Sandalye.Add(new Sandalye() { Marka = "asd", Renk = "Siyah" });
            }
        }
    }
}
