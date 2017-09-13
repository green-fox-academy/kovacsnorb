﻿using System;
using System.Collections.Generic;

namespace Lists_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list. 
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines

            list[1] = "Croissant";
            list[3] = "Ice cream";

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0}, ", list[i]);
            }

            Console.ReadLine();
        }
    }
}
