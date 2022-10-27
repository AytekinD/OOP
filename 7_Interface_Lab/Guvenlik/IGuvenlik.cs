using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_Lab.Guvenlik
{
    public interface IGuvenlik
    {
        bool KimlikKontrolEt(KimlikKarti kimlik);
        GirisKarti GirisKartıver(KimlikKarti kimlik);
        KimlikKarti KimlikKartiVer(GirisKarti girisKarti);
    }
}
