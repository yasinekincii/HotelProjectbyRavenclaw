using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltayPansiyon.UI.Comman
{
    public class Oda
    {
        public byte YatakSayisi { get; set; }

        public int OdaNumarasi { get; set; }

        public sbyte KatNo { get; set; }

        public double GunlukFiyat { get; set; }

        
        public OdaDurumu OdaDurumu { get; set; }
        public override string ToString()
        {
            return OdaDurumu.ToString();
        }
    }
}
