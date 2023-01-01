﻿using System;

namespace Advanced_Application_Programming
{
    class TaxCalculatorThreeSwitch
    {
        /*
         * Female earning < 15000	12%
        * Female earning >= 15000	14%
        * Male earning < 14000	13%
        * Male earning >= 14000	15%
        */
        public static void Main(string[] args)
        {
        PROMPT:
            Console.Write("1) Male\n2)Female\nEnter gender: ");
            int gender = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter gross pay: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            double tax;
            switch (gender)
            {
                case 2 when salary < 15000:
                    tax = .12 * salary;
                    break;
                case 2 when salary >= 15000:
                    tax = .14 * salary;
                    break;
                case 1 when salary < 14000:
                    tax = .13 * salary;
                    break;
                case 1 when salary >= 14000:
                    tax = .15 * salary;
                    break;
                default:
                    Console.WriteLine("Invalid inputs provided.");
                    goto PROMPT;
            }
            Console.WriteLine("Tax amount is {0:0,0.00}\nNet pay is {1:0,0.00}",
                tax, salary - tax);
        }
    }
}
