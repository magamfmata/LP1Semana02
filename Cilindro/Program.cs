﻿using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");

            Console.WriteLine("Insira a altura do Cilindro:");
            string a = Console.ReadLine();

            Console.WriteLine("Insira o raio do Cilindro:");
            string r = Console.ReadLine();

            double a_convert = double.Parse(a);
            double r_convert = double.Parse(r);
            double pi = Math.PI;

            double V = a_convert *Math.Pow(r_convert,2) * pi;
            string c = $"{V:f3}";
            Console.WriteLine (c);



        }
    }
}
