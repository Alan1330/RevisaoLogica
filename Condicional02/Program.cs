using System;

namespace Condicional02 {
    internal class Program {
        static void Main(string[] args) {

            int valor = int.Parse(Console.ReadLine());

            if(valor % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}