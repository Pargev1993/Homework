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
            Console.WriteLine("Choose your geometric figures:\nif square press-1\nif circle press-2\nif rectangle press-3 ");
            byte figur = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("enter figurs size ");
            if (figur == 1 || figur == 3)
            { int A = Convert.ToInt32(Console.ReadLine()); int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("figur area is " + (A * B)); }
            else if (figur == 2)
            { Double R = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("figur are is " + (3.14 * Math.Pow(R,2))); }
            Console.ReadKey();
        }
    }
}
    