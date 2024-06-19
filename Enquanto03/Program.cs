using System;

namespace Enquanto03 {
    internal class Program {
        static void Main(string[] args) {

            int valor = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (valor != 4) {

                if (valor == 1) { alcool++; }
                else if (valor == 2) { gasolina++; }
                else if (valor == 3) { diesel++; }
                valor = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}