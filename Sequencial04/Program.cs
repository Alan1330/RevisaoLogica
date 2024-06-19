using System;
using System.Globalization;

namespace Sequencia04 {
    internal class Program {
        static void Main(string[] args) {

            int numero = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double recebe = horas * valor;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + recebe.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}