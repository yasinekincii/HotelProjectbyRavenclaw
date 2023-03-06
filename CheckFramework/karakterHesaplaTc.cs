using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFramework
{
    public class karakterHesaplaTc
    {
        public static bool KarakterSaysiHesaplaTc(string deg)
        {
            int karakterSayisi = deg.Length;
            if ((karakterSayisi == 11) && (deg.Substring(0, 1) != "0"))
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
