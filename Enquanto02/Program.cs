using System;

namespace Enquanto02 {
    internal class Program {
        static void Main(string[] args) {

            string[] valor = Console.ReadLine().Split(' ');
            int x = int.Parse(valor[0]);
            int y = int.Parse(valor[1]);


            while (x != 0 && y != 0) {

                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");

                }
                else if (x > 0 && y < 0) {
                    Console.WriteLine("quarto");
                }
                valor = Console.ReadLine().Split();
                x = int.Parse(valor[0]);
                y = int.Parse(valor[1]);
            }
        }
    }
}