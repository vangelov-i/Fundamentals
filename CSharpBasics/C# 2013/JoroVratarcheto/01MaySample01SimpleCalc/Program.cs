﻿using System;

//18:30 - 18:50

namespace _01MaySample01SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());

            if (x==0 && y==0)
            {
                Console.WriteLine("0");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
            }
            else if (x <0 && y >0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y <0)
            {
                Console.WriteLine("3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("5");
            }
            else
            {
                Console.WriteLine("6");
            }

        }
    }
}
