﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_SiparisOtomasyonu.Entities
{
    internal class SiparisDetay
    {
        public int SiparisId { get; set; }
        public Urun urun { get; set; }
        public decimal ToplamTutar { get; set; }

    }
}
