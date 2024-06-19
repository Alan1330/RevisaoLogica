using System;

namespace Enquanto01 {
    internal class Program {
        static void Main(string[] args) {
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2022) {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}