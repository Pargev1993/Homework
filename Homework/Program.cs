using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weak_days
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Days of the week \n Select the number which day of week you want to know");

            byte day = Convert.ToByte(Console.ReadLine());
            if (day == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Monday");
            }
            else if (day == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Tuesday");
            }
            else if (day == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wednesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (day == 5)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("friday");
            }
            else if (day == 6)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("saturday");
            }
            else if (day == 7)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("there is no such day of the week");
            }
            Console.ReadKey();
        }
    }
}
