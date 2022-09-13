using System;

namespace Lesson05_GitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int spindulys = 6371;
            double variable = 4 / 3 * Math.PI * Math.Pow(spindulys, 3);
            Console.WriteLine($"rutulio turis V = {variable}, kai spindulio ilgis {spindulys}km");

        }
    }
}
