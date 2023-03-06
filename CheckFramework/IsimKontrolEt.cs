using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFramework
{
    public class IsimKontrolEt
    {
        public static bool KontrolEt(string ad)
        {
            bool hasSay = false;


            foreach (char c in ad)
            {
                if (Char.IsNumber(c))
                {
                    hasSay = true;
                    break;
                }
            }

            if (!hasSay)
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
