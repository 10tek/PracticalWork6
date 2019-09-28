using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW6
{
    class Program
    {
        static void Main(string[] args)
        {
            var startIndex = -2;
            var endIndex = 1;
            Random random = new Random();
            RangeOfArray array = new RangeOfArray(startIndex, endIndex);

            for (var i = startIndex; i < endIndex; i++)
            {
                array[i] = random.Next(0, 10);
            }

            for (var i = startIndex; i < endIndex; i++)
            {
                Console.WriteLine(array[i]);
            }

            array[2] = 23;

            Console.ReadKey();
        }
    }
}
