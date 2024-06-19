using System;
using System.Globalization;

namespace Sequencia05 {
    internal class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int unidades = int.Parse(valores[1]);
            double valor = double.Parse(valores[2], CultureInfo.InvariantCulture);


            valores = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(valores[0]);
            int unidades2 = int.Parse(valores[1]);
            double valor2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double pagar = unidades * valor + unidades2 * valor2;

            Console.WriteLine("VALOR A PAGAR: R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}