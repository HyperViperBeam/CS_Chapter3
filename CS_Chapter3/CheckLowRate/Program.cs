using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            String rate = Console.ReadLine();
            double rte = Convert.ToDouble(rate);
          
                if (rte < 5.65)
                {
                    Console.WriteLine("ERROR");
                }

                else Console.WriteLine("OK");
            }  
    }
}
