using static _11_EventYangin.Program;

namespace _11_EventYangin
{
    internal class Kablo
    {
        public event EventTip Yandim; 
        public Kablo()
        {
        }

        public void AkimGecir()
        {
            // bla bla

            bool KisaDevreVarmi = true;
            if (KisaDevreVarmi)
            {
                Console.WriteLine("Kablo yandi.");
                Yandim(this);
            }
        }

    }
}