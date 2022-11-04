namespace _13_GenelTekrar
{
    internal class Program
    {
        struct Kisi
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string SurName { get; set; }
            public string Description { get; set; }
        }
        public interface Iinterface
        {
            void test();
        }
        class a
        {

        }
        struct Person : Iinterface
        {
            public void test()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            #region Partial Class

            Kisi Ali = new Kisi();
            Ali.Name = "Ali";

            #endregion

            #region Struct ile Class arasindaki farklar

            //Struct (Yapi) : birbiriyle iliskili degiskenlerin bir isim altinda toplanmasina verilen isimdir.
            //Structlar Baska bir structdan veya class dan kalıtım alamaz. Ancak İnterfacelerden kalıtım alabilirler.
            //Structlar Stack de tutulur. 64 Kb siniri vardir.

            #endregion

            #region Erisim Belirtecleri
            //public : Her taraftan ulasilabilir.
            //private : Sadece Class icerisinden ulasilabilir.
            //Protected : Instance alindiginda ulasilamaz Ancak miras verilen yerlerden ulasilabilir
            //Internal : Programin calistigi assembbly
            //protected Internal : SAdece tanimlandigi sinifta 
            #endregion

            #region Event

            

            #endregion
        }
    }
}