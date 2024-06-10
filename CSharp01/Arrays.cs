using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp01
{
     class Arrays
    {
        static void Main(string[] args)
        {
            var num = new[] { 3, 7, 9, 2, 14, 6 };
            Console.WriteLine(num.Length);

            var numList = new List<int>() {2,4,6,8};
        }
    }
}
