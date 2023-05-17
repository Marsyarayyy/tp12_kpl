using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul12_1302213003
{
    public class Tanda
    {
        public static string CariTandaBilangan(int a)
        {
            if (a < 0)
            {
                return "Negatif";
            }
            else if (a > 0)
            {
                return "Positif";
            }
            else if (a == 0)
            {
                return "Nol";
            }
            return "input tidak valid";
        }
    }
}
