﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for ( int i = 100;  i >=1 ; i-- ) {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            for (int i = 100; i >0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 100; i > 0; --i)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 100; i >= 1; --i)
            {
                Console.Write(i + " ");
            }
        }
    }
}
