﻿using System;

namespace Firs_Prjct
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Plz enter a num:");
            string number = Console.ReadLine();
            num = int.Parse(number);
            num *= 3;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
