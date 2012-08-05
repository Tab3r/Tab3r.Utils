using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tab3r.Utils.Extensions
{
    public static class ExtLong
    {
        public static bool isOdd(this long value)
        {
            return (value % 2 == 0) ? false : true;
        }

        public static bool isEven(this long value)
        {
            return (value % 2 == 0) ? true : false;
        }
    }
}
