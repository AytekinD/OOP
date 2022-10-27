using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_Lab.Guvenlik
{
    public class GuvenlikGorevlisi : KisiBase, IGuvenlik
    {
        List<KimlikKarti> kimlikKartlari;

        int _kartNo = 0;
        //İlk calisan metoddur
        public GuvenlikGorevlisi()
        {
            kimlikKartlari = new List<KimlikKarti>();
        }
        public GirisKarti GirisKartıver(KimlikKarti kimlik)
        {
            GirisKarti girisKarti = new GirisKarti();
            girisKarti.GirisKartNo = ++_kartNo;
            girisKarti.Kimlik = kimlik;
            kimlikKartlari.Add(kimlik);
            return girisKarti;
        }

        public KimlikKarti KimlikKartiVer(GirisKarti girisKarti)
        {
            var kimlik = girisKarti.Kimlik;
            
            kimlikKartlari.Remove(kimlik);
            return kimlik;

        }

        public bool KimlikKontrolEt(KimlikKarti kimlik)
        {
            throw new NotImplementedException();
        }
        public void KimlikleriListele()
        {
            foreach (var item in kimlikKartlari)
            {
                Console.WriteLine(item.TcNo);
            }
        }
    }
}
