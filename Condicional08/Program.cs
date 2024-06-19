using System;
using System.Globalization;

namespace Condicional08 {
    internal class Program {
        static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.0;

            if (salario <= 2000.0) {
                Console.WriteLine("Isento");
            }

            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (salario <= 4500.0) {
                imposto = 1000.0 * 0.08; // faixa abaixo de 3mil -2mil
                imposto = imposto + (salario - 3000.0) * 0.18;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else {
                imposto = 1500 * 0.18 + 1000.0 * 0.08;
                imposto = imposto + (salario - 4500.0) * 0.28;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}