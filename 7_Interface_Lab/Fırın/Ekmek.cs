using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_Lab.Fırın
{
    public class Ekmek : IHamur
    {
        public double Gramaj { get; set; }

        public void Mayalama()
        {
            throw new NotImplementedException();
        }

        public void SuKat()
        {
            throw new NotImplementedException();
        }

        public void UnKat()
        {
            throw new NotImplementedException();
        }

        public void Yogur()
        {
            throw new NotImplementedException();
        }
    }
}
