using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AbstractClass.MuzikAletleri
{
    //Abstract classlar sadece kalıtım vermek icin tasarlanmistir.Instance alinamazlar.
    //Yani newlenemezler
    public abstract class MuzikAleti
    {
        public string Marka { get; set; }
        public string Aciklama { get; set; }
        //abstract class larin en buyuk ozelligi de icerisinde Abstract olan yada olmayan metodlari barindirabilirler.
        //Abstract metodlar kalitim alinan yerde implimente edilmek zorundadir.
        //Yani Metodun govdesi kalitim alinan yerde yazilacaktir.Interfacedeki gibi metod imzasi yeterlidir.
        public abstract string Cal();
        //public abstract string Cal(string ses);
        public virtual string AkortEt()
        {
            return Marka + "Akor Edildi";
        }


        /*
            Abstract Metodlari tanimlarken dikkat edilmesi gerekenler

            1-github dan yaz buralari

         */




    }
}
