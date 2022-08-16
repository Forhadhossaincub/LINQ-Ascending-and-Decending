using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Ascending_and__Decending
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 10, 20, 51, 5, 33, 1, 2, 4, 5, 7, 11 };

            Console.WriteLine("Ascending Order :");

            var posNums = from n in nums
                          orderby n ascending
                          select n;

            foreach(int i in posNums)
            {
                Console.WriteLine($"{i}  \t" );
            }

            Console.WriteLine("Descending Order :");

            var posNums2 = from n in nums
                          orderby n descending
                          select n;

            foreach (int i in posNums2)
            {
                Console.WriteLine($"{i}  \t");
            }

            Console.ReadKey();

        }
    }
}
