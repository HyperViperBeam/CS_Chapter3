using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            String GPA = Console.ReadLine();
            double gpa = Convert.ToDouble(GPA);

            String test = Console.ReadLine();
            int tests = Convert.ToInt32(test);

            if (gpa >= 3.0 && tests >= 60 || gpa < 3.0 && tests >= 80)
            {
                Console.WriteLine("Accpeted!");
            }
            else Console.WriteLine("OBJECTION!");
        }
    }
}
