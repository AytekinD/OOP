using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class_AnotherProject.Mobilyalar
{
    public class Masa
    {
        public string Marka { get; set; }
        public string model { get; set; }
        public string Renk { get; set; }
        public string Malzeme { get; set; }
        public string Ebat { get; set; }

        /*
         Constructer : Yapici Metod
        Nesne ilk olarak new lendigi zaman calisan metoddur.
        Yapici metodlarin geri donus degerleri yoktur.
        o yuzden sadece classlar ozel metoddur.
         */
        //Herhangi bir parametre almayan yapici metoddur.
        //Bos constructer da denir

        public Masa()
        {

        }
        public Masa(string Marka)
        {

        }
        public Masa(string Marka, string Renk)
        {

        }

    }
}
