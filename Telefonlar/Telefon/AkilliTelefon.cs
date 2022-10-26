using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonlar.Emlak
{
    public enum IsletimSis
    {
        Android = 1,
        IOS,
        HarmonyOs

    }

    public class AkilliTelefon : BaseTelefon, ITelefon
    {
        public string Pil { get; set; }
        public byte KameraMP { get; set; }
        public int Kapasite { get; set; }
        public int Boyutar { get; set; }
        public IsletimSis isletim { get; set; }

        public void AramaYap()
        {
            throw new NotImplementedException();
        }

        public void mesajAt()
        {
            throw new NotImplementedException();
        }

        public void SarjOl()
        {
            throw new NotImplementedException();
        }
    }
}
