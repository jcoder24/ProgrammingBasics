using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllInOneCSharp
{
    class Concat
    {
        static void Main(string[] args)
        {
            String str1, str2;
            str1 = "Hello";
            str2 = "World";
            Console.WriteLine("String after concatenation is - {0}", String.Concat(str1, str2));
            Console.ReadKey();
        }
    }
}
