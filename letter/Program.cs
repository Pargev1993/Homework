﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("letter");
            char y = char.Parse(Console.ReadLine());
            if (char.IsLower(y))
            {
                y = char.ToUpper(y);
                Console.WriteLine(y);
            }
            else
            {
                
                Console.WriteLine(y);

            }
            Console.ReadLine();
        }
    }
}
