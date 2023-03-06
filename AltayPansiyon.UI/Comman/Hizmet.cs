using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltayPansiyon.UI.Comman
{
    public class Hizmet
    {
        public Hizmet( )
        {

        }
        public String MusteriTc { get; set; }

        public List<Malzeme> malzeme { get; set; }

        public DateTime GercekCikisTarihi { get; set; }
        public double ToplamFiyat { get; set; } = 0;
        public double TopFiyat(DateTime giris,double odaFiyat,double malzemelerinToplamFiyati )
        {
            int kaldigiGünSayisi=GercekCikisTarihi.DayOfYear - giris.DayOfYear;
            ToplamFiyat = (odaFiyat*kaldigiGünSayisi)+malzemelerinToplamFiyati;
            return ToplamFiyat;
        }

        public override string ToString()
        {
            return ToplamFiyat.ToString();
        }

    }
}
