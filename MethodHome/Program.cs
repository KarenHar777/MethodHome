﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHome
{
    internal class Program
    {
        static void Sum(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        static void Sum(int x, int y, int z)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} + {z} = {x + y+z}");
        }
        static void Sum(int x, int y, int z, int w)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} + {z} + {w}= {x + y + z + w}");
        }




        static void Main(string[] args)
        {
            Sum(15, 56);

            Console.ReadKey();
        }
    }
}