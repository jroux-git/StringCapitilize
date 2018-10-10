using System;
using System.Text;

namespace StringCapitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCapitalizeHelper sc = new StringCapitalizeHelper();
            char[] delim = new char[] {'_', 'l' };
            string result = sc.ConvertCaps("Hello_world", delim);

            Console.WriteLine(result);
            Console.Read();
        }

        
    }
}
