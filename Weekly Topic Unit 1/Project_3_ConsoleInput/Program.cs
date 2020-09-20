﻿using System;

// Prof Reynolds

namespace Project_3_ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";

            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter a new last name:");
            lastName = Console.ReadLine();

            Console.WriteLine("New name: " + firstName + " " + lastName);

            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
    }
}
