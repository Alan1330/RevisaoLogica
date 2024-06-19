using System;

namespace For02 {
    internal class Program {
        static void Main(string[] args) {

            int valor = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;
            for (int i = 1; i <= valor; i++) {
                int dado = int.Parse(Console.ReadLine());
                if (dado >= 10 && dado <= 20) {
                    dentro++; // dentro = dentro +1
                }
                else { fora++; }

            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}