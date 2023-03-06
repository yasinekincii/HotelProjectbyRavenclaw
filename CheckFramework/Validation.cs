using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFramework
{
    public class Validation
    {


        public static bool Validation1(string AdSoyad, string DogumTarihi, string Tc, string TelNo)
        {
            

            if (BosDegerKontrolEt.DegerBosmu(AdSoyad)
                && BosDegerKontrolEt.DegerBosmu(DogumTarihi)
                && BosDegerKontrolEt.DegerBosmu(Tc)
                && IsimKontrolEt.KontrolEt(AdSoyad)
                && KarakterHesapala.KarakterSayisiHesapla(TelNo)
                && karakterHesaplaTc.KarakterSaysiHesaplaTc(Tc)
                )
            {
                return true;
            }
            else
            {
                return false;
            }


            
        }


             








    }
}
