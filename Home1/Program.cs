using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input single digit");
            byte n = byte.Parse(Console.ReadLine());
            if (n < 10 && n > 0)
            {
                for (int i = 1; i < n; i++)
                {
                    Console.WriteLine($"{i}");

                }
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();
        }
    }
}
