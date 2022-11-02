using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Event
{
    public delegate void MetodTipi(object sender);
    public class Bagiran
    {
        public string Ad { get { return "Ali"; } }
        public event MetodTipi Bagirdim;
        public void HerhangiBirIslemYap()
        {
            MessageBox.Show("aaaaaa");
            Bagirdim(this);
        }
    }
}
