using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_SiparisOtomasyonu.Entities
{
    internal class SiparisMaster
    {
        public DateTime SiparisTarihi { get; set; }
        public Kullanici kullanici { get; set; }
        public List<SiparisDetay> SiparisDetays { get; set; }

    }
}
