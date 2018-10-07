using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number");
            int max = 300;
            int n = Convert.ToInt32(Console.ReadLine());
            int A = 0;

            for (int i = 2; i <= max; i += 2)
            {
                Console.WriteLine(A += i);

            }
            Console.ReadKey();
        }
    }
}
