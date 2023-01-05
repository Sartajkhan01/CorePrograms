﻿namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Programming Problems");
            bool end = true;
            Console.WriteLine("1. FlipCoin\n2. LeapYear Problem\n3. End the Program ");
            while (end)
            {
                Console.WriteLine("Choose an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipcoin = new FlipCoin();
                        flipcoin.Flip();
                        break;
                    case 2:
                        LeapYear checking = new LeapYear();
                        checking.CheckLeapyear();
                        break;
                    case 3:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct option");
                        break;
                }
            }

        }

    }
}