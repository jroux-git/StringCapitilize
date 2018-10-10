using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCapitalize
{
    public static class StringContainsExtension
    {
        public static bool CharArrContains(this char c, char[] charArr)
        {
            return charArr.Any(x=> x == c);
        }
    }
}
