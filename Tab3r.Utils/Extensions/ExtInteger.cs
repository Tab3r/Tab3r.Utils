using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tab3r.Utils.Extensions
{
    public static class ExtInteger
    {
        public static bool isOdd(this int value)
        {
            if (value % 2 == 0)
                return false;
            else return true;
        }

        public static bool isEven(this int value)
        {
            if (value % 2 == 0)
                return true;
            else return false;
        }
    }
}
