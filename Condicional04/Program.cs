using System;

namespace Condicional04 {
    internal class Program {
        static void Main(string[] args) {

            string[] s = Console.ReadLine().Split(' ');
            int inicio = int.Parse(s[0]);
            int final = int.Parse(s[1]);

            int duracao = 0;
            if (inicio > final) {
                duracao = 24 + final - inicio;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            else {
                duracao = final - inicio;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }

        }
    }
}