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
            if (figur == 1|| figur==3)
            {   Console.WriteLine("enter figurs size ");
                int A = Convert.ToInt32(Console.ReadLine());
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("area is "+A*B);}
                else  if (figur==2)
            {  double R = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("area is"+ 3.14* Math.Pow(R,2));}
                else
            { Console.WriteLine("wrong"); }
                Console.ReadKey(); }
        }
    }
