using System;

namespace Lesson05_GitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kajus

            double variable;

            int spindulys = 6371;
            double turis = 4 / 3 * Math.PI * Math.Pow(spindulys, 3);

            variable = turis;
            Console.WriteLine(variable);

            //kotryna

            double variable2;

            double radius = 6372;
            double pi = Math.PI;
            double area = (4 * pi * Math.Pow(radius, 3)) / 3;

            variable2 = area;
            Console.WriteLine(variable2);

            //karolis

            double variable3;
            double a = 10.0;
            double b = 15.0;
            double c;
            double sum = 0;

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine(c);
            variable3 = c;

            //bendra

            sum = variable3 + variable2 + variable;
            Console.WriteLine($"Suma: {sum}");
            double average = sum / 3;
            Console.WriteLine($"Vidurkis: {sum}");

        }
    }
}
