using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFramework
{
    public class KarakterHesapala
    {
        /// <summary>
        /// Girilen telefon numarasının değer kontrolü
        /// </summary>
        /// <param name="deger"></param>
        /// <returns></returns>
        public static bool KarakterSayisiHesapla(string deger)
        {
            int karakterSayisi = deger.Length;
            if ((karakterSayisi == 14) && (deger.Substring(0, 1) != "0"))
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
