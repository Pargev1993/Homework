using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Days of the week \n Select the number which day of week you want to know");
            string weekday = Convert.ToString(Console.ReadLine());


            switch (weekday)
            {
                case "1":
                    weekday = "Monday"; Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "2":
                    weekday = "Tuesday"; Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "3":
                    weekday = "Wednesday"; Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "4":
                    weekday = "Thursday"; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "5":
                    weekday = "Friday"; Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "6":
                    weekday = "Saturday"; Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "7":
                    weekday = "Sunday"; Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    {
                        Console.WriteLine("there is no such day of the week");
                    }
                    break;
            }
            Console.WriteLine(weekday);
            Console.ReadKey();
        }
    }
}