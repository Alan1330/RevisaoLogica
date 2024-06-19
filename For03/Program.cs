using System;
using System.Globalization;

namespace For03 {
    internal class Program {
        static void Main(string[] args) {

            int valor = int.Parse(Console.ReadLine());
            double media = 0.0;

            for (int i = 0; i < valor; i++) {
                string[] dado = Console.ReadLine().Split(' ');
                double a = double.Parse(dado[0], CultureInfo.InvariantCulture);
                double b = double.Parse(dado[1], CultureInfo.InvariantCulture);
                double c = double.Parse(dado[2], CultureInfo.InvariantCulture);
                media = (a * 2 + b * 3 + c * 5) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}