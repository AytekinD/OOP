using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris.Bilgisayar
{
    /*
        Enumlar default olarak integer veri tipindeir.
        istenirse degistirilebilir
        secmeli durumlarda kullanilir.
        Her bir duruma bir numara verir.
        Eger numara verme isek 0'dan baslar.
     */

    public enum IslemciTipi
    {
        AMD=1,
        Intel
    }

    public class CPU
    {
        public IslemciTipi IslemciTipi { get; set; }

    }
}
