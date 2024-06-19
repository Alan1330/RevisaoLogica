using System;
using System.Globalization;

namespace Sequencial02 {
    internal class Program {
        static void Main(string[] args) {

            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = Math.Pow(raio, 2) * pi;

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}