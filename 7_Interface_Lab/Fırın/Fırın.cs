using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_Lab.Fırın
{
    public class Fırın : IFırın
    {
        public int Odun { get; set; }
        public string Ates { get; set; }
        public void Pisir()
        {
            throw new NotImplementedException();
        }
    }
}
