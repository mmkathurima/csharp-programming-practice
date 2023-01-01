﻿using System;

namespace Advanced_Application_Programming
{
    class BeerSwitchOOP
    {
        private int choice, bottles, cost, total;

        public int Choice
        {
            get { return choice; }
            set
            {
                choice = value;
            }
        }
        public int Bottles
        {
            get
            {
                return bottles;
            }
            set
            {
                bottles = value;
            }
        }
        public int Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }

        public BeerSwitchOOP(int choice, int bottles)
        {
            this.Choice = choice;
            this.Bottles = bottles;
        }

        public BeerSwitchOOP()
        {
            this.Choice = 1;
            this.Bottles = 1;
        }

        void Input()
        {
            Console.Write("\n* * * * Jamal and Daughters Pub * * * *\n"
                          + "Beer Brand\t\tPrice\n1) Tusker\t\t100/=\n"
                          + "2) Pilsner\t\t120/=\n3) Smirnoff Ice\t\t140/=\n"
                          + "4) White Cap\t\t90/=\nEnter your choice: ");
            Choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many bottles of Tusker do you want? ");
            Bottles = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.Write("How many bottles of Tusker do you want? ");
                    Bottles = Convert.ToInt32(Console.ReadLine());
                    Cost = 100;
                    break;
                case 2:
                    Console.Write("How many bottles of Pilsner do you want? ");
                    Bottles = Convert.ToInt32(Console.ReadLine());
                    Cost = 120;
                    break;
                case 3:
                    Console.Write("How many bottles of Smirnoff Ice do you want? ");
                    Bottles = Convert.ToInt32(Console.ReadLine());
                    Cost = 140;
                    break;
                case 4:
                    Console.Write("How many bottles of White Cap do you want? ");
                    Bottles = Convert.ToInt32(Console.ReadLine());
                    Cost = 90;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    Input();
                    break;
            }
        }
        void Compute()
        {
            Total = Cost * Bottles;
        }
        void Output()
        {
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("{0} bottles of Tusker will cost you Kshs. {1}", Bottles, Total);
                    break;
                case 2:
                    Console.WriteLine("{0} bottles of Pilsner will cost you Kshs. {1}", Bottles, Total);
                    break;
                case 3:
                    Console.WriteLine("{0} bottles of Smirnoff Ice will cost you Kshs. {1}", Bottles, Total);
                    break;
                case 4:
                    Console.WriteLine("{0} bottles of White Cap will cost you Kshs. {1}", Bottles, Total);
                    break;
            }
        }
        public static void Main(string[] args)
        {
            BeerSwitchOOP beer = new BeerSwitchOOP();
            beer.Input();
            beer.Compute();
            beer.Output();
        }
    }
}
