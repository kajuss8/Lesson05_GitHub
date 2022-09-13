using System;

namespace Lesson05_GitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double variable3= 333;
            double a = 10.0;
            double b = 15.0;
            double c;
            double sum = 0;

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(c);
            variable3 = c;

            //double sum = variable3 + variable2 + variable;
            Console.WriteLine($"Suma: {sum}");
            double average = sum / 3;
            Console.WriteLine($"Vidurkis: {sum}");

            int spindulys = 6371;
            double variable = 4 / 3 * Math.PI * Math.Pow(spindulys, 3);
            Console.WriteLine($"rutulio turis V = {variable}, kai spindulio ilgis {spindulys}km");
            Console.WriteLine();


        }
    }
}
