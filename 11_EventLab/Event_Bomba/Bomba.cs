using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EventLab.Event_Bomba
{    
    internal class Bomba
    {
        public Bomba()
        {

        }

        public void Patla()
        {
            Console.WriteLine("Booommm");
            Environment.Exit(0); //Cikis yapmaya yariyor.
        }

    }
}
