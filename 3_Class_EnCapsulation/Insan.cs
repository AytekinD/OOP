using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class_EnCapsulation
{
    public class Insan
    {
        private string _ad;
        private string _soyad;
        private int _biriktirdigiPara;
        private bool _guveniyorMu=false;

        public Insan(string ad, string soyad)
        {
            _ad = ad;
            _soyad = soyad;
            _biriktirdigiPara = 10;
        }
        public void HarclikAl(int harclik)
        {
            if (harclik < 0)
            {
                throw new Exception("Baba ");
            }
            if (harclik < 50)
            {
                throw new Exception();
            }
            _biriktirdigiPara += harclik;
        }
        public void Harca(int miktar)
        {
            if (_biriktirdigiPara <= miktar)
            {
                throw new Exception("Bu kadar param yok");
            }
            _biriktirdigiPara -= miktar;
        }
        public int GetPara(string kimsin)
        {
            if (kimsin == "Baban")
            {
                return _biriktirdigiPara / 10;
            }
            return _biriktirdigiPara;
        }
        //Sartsiz property
        //public int BiriktirdigiPara { get; set; }

        public int Boyu { get; } // ReadOnly Property denir

        public int Kilosu { get; private set; } //Class haric readonly

        public int Yas { set { } } //write only property tipidir

        //Sartli geri bildirim yaptigimiz EnCapsulation
        //Full Property
        public int BiriktirdigiPara
        {
            get
            {
                if (_guveniyorMu = true)
                {
                    return _biriktirdigiPara;
                }
                return 0;
            }
            set
            {
                if (value > 0)
                {
                    _biriktirdigiPara=value;
                }
            }
        }

    }
}
