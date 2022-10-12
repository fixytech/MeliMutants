using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Services
{
    public class StatsClass
    {
        public String Ratio(int valueOne, int valueTwo)
        {

            if (valueOne != 0 && valueTwo != 0)
            {
               var gcd = GCD(valueOne, valueTwo);
                return string.Format("{0}:{1}", valueOne / gcd, valueTwo / gcd);
            }

            return string.Format("{0}:{1}", 0, 0);

        }
        static int GCD(int a, int b)
        {
            return b == 0 ? Math.Abs(a) : GCD(b, a % b);
        }

    }
}
