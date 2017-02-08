using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            String rate = Console.ReadLine();
            double rte = Convert.ToDouble(rate);

            String hours = Console.ReadLine();
            int hrs = Convert.ToInt32(hours);
            double net = 0;
            double gross = hrs * rte;
            double tax = 0;

            if (gross <= 300.00)
            {
                tax = .1;
                net = gross - (gross * tax);

                Console.WriteLine("Gross: $" + gross + " Witholding Tax: " + (tax * 100) + "%" + " Net $" + net);
            }

            else
            {
                tax = .12;
                net = gross - (gross * tax);

                Console.WriteLine("Gross: $" + gross + " Witholding Tax: " + (tax * 100) + "%" + " Net $" + net);
            }
        }
        }
    }
