using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFramework
{
    public static class BosDegerKontrolEt
    {
        /// <summary>
        /// girilen string değer boş mu kontrolü
        /// </summary>
        /// <param name="deger"></param>
        /// <returns></returns>
        public static bool DegerBosmu(string deger)
        {
            
            if (!string.IsNullOrEmpty(deger) && !string.IsNullOrWhiteSpace(deger))
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
