using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int K = Convert.ToInt32(Console.ReadLine());
            if (N > 0)

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(K);

                }
            else
            {
                Console.WriteLine("mistake");
            }
                Console.ReadKey();
            
        }
    }
}
