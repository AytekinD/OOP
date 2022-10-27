using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_Lab.Ucak
{
    public class Ucak:IUcak
    {
        public string SirketIsmi { get; set; }
        public string Model { get; set; }
        

        public void InisYap()
        {
            throw new NotImplementedException();
        }

        public void KalkısYap()
        {
            throw new NotImplementedException();
        }

        public void YolcuBindir()
        {
            throw new NotImplementedException();
        }

        public void YolcuIndir()
        {
            throw new NotImplementedException();
        }
    }
}
