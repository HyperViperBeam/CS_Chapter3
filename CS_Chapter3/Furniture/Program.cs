using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            String furniture = Console.ReadLine();

            if (furniture.ToLower().Equals("p")) {
                Console.WriteLine("Pine tables cost $100");
            }

           else if (furniture.ToLower().Equals("m")) {
                Console.WriteLine("Mahogney tables cost $310");
            }

           else if (furniture.ToLower().Equals("o"))
            {
                Console.WriteLine("Oak tables cost $225");
            }

            else Console.WriteLine("$0");
        }
    }
}
