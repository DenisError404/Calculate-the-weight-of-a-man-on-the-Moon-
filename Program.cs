using System;
using Microsoft.VisualBasic;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your current weight: ");
            double weightEarth = double.Parse(Console.ReadLine());

            double weightMoon = weightEarth * 0.17;
            Console.WriteLine("Your weight {0} kg. on the Moon will be: {1} kg.", weightEarth, weightMoon);

            Console.ReadKey();

        }
    }
}

