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
            string digitnumber = Convert.ToString(Console.ReadLine());
            int number =Convert.ToInt32(digitnumber[0] + digitnumber[1] + digitnumber[2] + digitnumber[3]);
            Console.WriteLine(number);
            Console.WriteLine(digitnumber[2]);
            Console.ReadKey();


        }
    }
}