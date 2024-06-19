using System;

namespace Condicional03 {
    internal class Program {
        static void Main(string[] args) {

            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int g = 0;  // g de grande
            int p = 0;  // p de pequeno


            if (a > b) {
                g = a;
                p = b;
            }
            else {
                g = b;
                p = a;
            }


            if (g % p == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao Sao Multiplos");
            }
        }
    }
}