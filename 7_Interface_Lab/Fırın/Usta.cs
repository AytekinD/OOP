using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_Lab.Fırın
{
    public class Usta:IYogur
    {
        public string Isim { get; set; }

        public void HamurYogur()
        {
            Console.WriteLine(Isim + "Hamur Yogurdu." );
        }
    }
}
