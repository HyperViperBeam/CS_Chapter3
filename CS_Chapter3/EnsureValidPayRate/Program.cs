﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            String rte = Console.ReadLine();
            double rate = Convert.ToDouble(rte);

            if (rate < 5.65 || rate > 49.99)
            {
                rte = Console.ReadLine();
                rate = Convert.ToDouble(rte);
                if (rate < 5.65 || rate > 49.99)
                {
                    Console.WriteLine("ERROR");
                }
            }
            else Console.WriteLine(rate * 40);
        }
    }
}
