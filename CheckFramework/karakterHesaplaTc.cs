using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFramework
{
    public class karakterHesaplaTc
    {
        /// <summary>
        /// Girilen TC değerinin kontrolü
        /// </summary>
        /// <param name="deger"></param>
        /// <returns></returns>
        public static bool KarakterSaysiHesaplaTc(string deger)
        {
            int karakterSayisi = deger.Length;
            if ((karakterSayisi == 11) && (deger.Substring(0, 1) != "0"))
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
