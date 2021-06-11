using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenfordLab
{
    public class FirstDigit
    {
        /* Given an integer X, this method returns the first digit
         * 
         * For example,
         *   5 ==> returns 5
         *   10 ==> returns 1
         *   654321 ==> returns 6
         */
        public static int getFirstDigit(int digit) {
            // TODO
            // getting the divisor using the total digits in the number
            int divisor = (int)Math.Pow(10, digit.ToString().Length - 1);
            return digit / divisor;
        }
    }
}
