using System;
using System.Text;

namespace StringCapitalize
{
    public class StringCapitalizeHelper
    {
        public string ConvertCaps(string s, char[] charArr)
        {
            s = s.Trim();

            if (s.Length <= 0)
                throw new ArgumentException("No input string provided");

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                result.Append(s[i]);

                if (i > 0 && s[i].CharArrContains(charArr) && !s[i - 1].CharArrContains(charArr))
                    result[i - 1] = char.ToUpper(result[i - 1]);
            }

            return result.ToString();
        }
    }
}
