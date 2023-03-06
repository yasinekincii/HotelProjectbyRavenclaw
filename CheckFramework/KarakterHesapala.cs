using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFramework
{
    public class KarakterHesapala
    {
        public static bool KarakterSayisiHesapla(string deg)
        {
            int karakterSayisi = deg.Length;
            if ((karakterSayisi == 14) && (deg.Substring(0, 1) != "0"))
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
