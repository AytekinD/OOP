using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_Lab.Fırın
{
    public class Firin 
    {
        public void EkmekPisir(List<Urun> malzemeler, Usta usta)
        {
            usta.HamurYogur();
            foreach (var item in malzemeler)
            {
                Console.WriteLine(item.Miktar + " " +item.birim);
            }
        }
        public void EkmekPisir(List<Urun> malzemeler, YogurmaMakinasi makina)
        {
            makina.HamurYogur();
            foreach (var item in malzemeler)
            {
                Console.WriteLine(item.Miktar + " " + item.birim);
            }
        }
        //BURADA MAKİNA VEYA USTA BELLİ DEGİSKEN İSE DİREK İNTERFACE İ KULLANARAK BU İNTERFACE DEN KALITIM ALAN HERKES 
        //BU İSİ YAPABİLSİN DİYE BU SEİLDE DE GOSTERİLİR.

        public void EkmekPisir(List<Urun> malzemeler, IYogur yogurucu)
        {
            yogurucu.HamurYogur();
            foreach (var item in malzemeler)
            {
                Console.WriteLine(item.Miktar + " " + item.birim);
            }
        }
    }
}
