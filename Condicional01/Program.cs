using System;

namespace Condicional01 {
    internal class Program {
        static void Main(string[] args) {

            int valor = int.Parse(Console.ReadLine());

            if(valor < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}