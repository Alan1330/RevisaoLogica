using System;
using System.Globalization;

namespace Condicional05 {
    internal class Program {
        static void Main(string[] args) {

            string[] dados = Console.ReadLine().Split(' ');
            int codigo = int.Parse(dados[0]);
            int quantidade = int.Parse(dados[1]);
            double paga = 0;
            if (codigo == 1) {
                paga = quantidade * 4.0;
            }

            if (codigo == 2) {
                paga = quantidade * 4.5;
            }

            if (codigo == 3) {
                paga = quantidade * 5.0;
            }

            if (codigo == 4) {
                paga = quantidade * 2.0;
            }

            if (codigo == 5) {
                paga = quantidade * 1.5;
            }
            Console.WriteLine("Total: R$ " + paga.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}