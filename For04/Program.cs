using System;
using System.Globalization;
using System.Linq;

namespace For04 {
    internal class Program {
        static void Main(string[] args) {

            int valor = int.Parse(Console.ReadLine());
            int n = 0;
            int d = 0;
            double divisao = 0.0;

            for (int i = 0; i < valor; i++) {
                string[] dado = Console.ReadLine().Split(' ');
                n = int.Parse(dado[0]);
                d = int.Parse(dado[1]);
                if (d == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    divisao = (double) n / d;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}