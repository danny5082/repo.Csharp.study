﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };
            ArrayList list1 = new ArrayList(arr);

            ArrayList list2 = new ArrayList();
            list2.Add(1);
            list2.Add(2);

            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
