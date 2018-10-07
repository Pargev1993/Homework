using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number more tne first number " );
            int B = Convert.ToInt32(Console.ReadLine());
            if (A<B)
                for (int i = A; i <B; i++)
                {
                    Console.WriteLine(i);
                    
                   
                }
            Console.WriteLine("-----");
            Console.WriteLine(B - A);
            Console.ReadKey();
        }
    }
}
