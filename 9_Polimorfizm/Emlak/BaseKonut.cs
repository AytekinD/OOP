using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _9_Polimorfizm.Emlak
{
    public enum Kimden
    {
        Sahibinden=1,
        Emlakci
    }
    public enum EmlakTipi
    {
        Daire=1,
        Residance,
        MustakilEv,
        Villa,
        Yali
    }
    public class BaseKonut
    {
        public string IlanNo { get; set; }
        public EmlakTipi EmlakTipi { get; set; }
        public DateTime IlanTarihi { get; set; }
        public int m2 { get; set; }
        public byte OdaSayisi { get; set; }
        public bool Esyali { get; set; }
        public bool Site { get; set; }
        public byte BulunduguKat { get; set; }
        public Kimden Kimden { get; set; }
        public int Aidat { get; set; }
        public double Masraf { get; set; }

        private double _Kira=2500;

        public double Kira
        {
            get { return _Kira; }
            set { _Kira = value; }
        }
        public virtual double KiraHesapla()
        {
            if (m2 > 50)
            {
                int fark = m2 - 50;
                Kira += fark * 100;
            }
            if (Esyali)
            {
                Kira += 1000;
            }
            if (Site)
            {
                Kira += 2000;
                Kira += Aidat;
            }
            if (BulunduguKat > 0)
            {
                Kira += 500;
            }                                          
            return Kira;
        }
        public virtual double GirisMasrafi()
        {
            if (Kimden == Kimden.Sahibinden)
            {
                double Depozito = Kira * 2;
                Masraf = Depozito;
            }
            else
            {
                double Depozito = Kira * 2;
                double Komisyon = Kira * 12 * 0.1;
                Masraf = Komisyon + Depozito;
            }
            return Masraf;
        }
    }
}
