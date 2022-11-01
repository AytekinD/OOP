using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Araba
{       
    public enum Model
    {
        Clio=1,
        Espace,
        Fluence,
        Laguna,
        Megane,
        Latitude
    }
    
    public abstract class BaseAraba
    {
        public string Marka { get; set; }
        public Model Model { get; set; }
        public int Yil { get; set; }
        public string Yakit { get; set; }
        public int Km { get; set; }
        public string Renk { get; set; }


        public abstract double FiyatHesap();
        


    }
}
