using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltayPansiyon.UI.Comman
{
    public class OdaRezarvasyon
    {
        public Oda OdaBilgileri { get; set; }

        public Musteri MusteriBilgileri { get; set; }

        public DateTime GirisTarihi { get; set; }

        public DateTime TahminiCikisTarihi { get; set; }
        public override string ToString()
        {
            return MusteriBilgileri.AdSoyad + " " + MusteriBilgileri.TC + " " + GirisTarihi;
        }
    }
}
