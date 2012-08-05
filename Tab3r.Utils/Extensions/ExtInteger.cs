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
            return (value % 2 == 0) ? false : true;
        }

        public static bool isEven(this int value)
        {
            return (value % 2 == 0) ? true : false;
        }
    }
}
