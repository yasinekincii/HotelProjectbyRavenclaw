using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFramework
{
    public static class Validation
    {
        /// <summary>
        /// Girilen değerlerin kontrolü
        /// </summary>
        /// <param name="AdSoyad"></param>
        /// <param name="DogumTarihi"></param>
        /// <param name="Tc"></param>
        /// <param name="TelNo"></param>
        /// <returns></returns>
        public static bool DegerlerinKontrolu(string AdSoyad, string DogumTarihi, string Tc, string TelNo)
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
