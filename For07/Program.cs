using System;
using System.Globalization;

namespace For06 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                int a = (int) Math.Pow(i, 2);
                int b = (int) Math.Pow(i, 3);

            Console.WriteLine(i + " " + a + " " + b);
            }
        }
    }
}