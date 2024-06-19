using System;
using System.Globalization;

namespace For05 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= n; i++) {
                fatorial = fatorial * i;
            }
                Console.WriteLine(fatorial);
        }
    }
}