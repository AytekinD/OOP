using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Araba
{
    public class Clio:BaseAraba
    {
        public bool SisLambasi { get; set; }

        private double _fiyat = 400000;

        public double Fiyat
        {
            get { return _fiyat; }
            private set { _fiyat = value; }
        }
        public Clio(bool sisLambasi, double _fiyat)
        {
            SisLambasi = sisLambasi;
            Fiyat = _fiyat;
           
        }

        public override double FiyatHesap()
        {
            if (Km >= 50000)
            {
                Fiyat -= Fiyat * 0.02;
            }
            if (Yil <= 2020)
            {
                Fiyat -= Fiyat * 0.01;
            }
            if (SisLambasi)
            {
                Fiyat += 450;
            }
            return Fiyat;

        }
    }
}
