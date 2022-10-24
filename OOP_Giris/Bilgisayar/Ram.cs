using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris.Bilgisayar
{
    public enum RamTipi
    {
        DDR=1,
        DDR2,
        DDR3,
        DDR4
    }

    public class Ram
    {
        public RamTipi Tip { get; set; }
        public string Marka { get; set; }
        public string kapasitesi { get; set; }

    }
}
