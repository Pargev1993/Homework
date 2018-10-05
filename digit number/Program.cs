using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_figures
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a four-digit number ");
            int digitnumber = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (digitnumber >= 1000 && digitnumber <= 9999)
            {
                int num_1 = digitnumber / 1000;
                int num_2 = digitnumber % 1000 / 100;
                int num_3 = digitnumber % 1000 % 100 / 10;
                int num_4 = digitnumber % 1000 % 100 % 10;
                result = num_1 + num_2 + num_3 + num_4;
                Console.WriteLine("result=" + result);
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadLine();
        }
    }
}