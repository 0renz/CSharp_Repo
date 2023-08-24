using System;
using System.Collections.Concurrent;
using System.Collections.Specialized;

namespace Projeto_1
{
    class Program
    {
        static void Main(String[] Args)
        {
            int idade = 19;
            string nome = "lorenzo";
            double saldo = 1000.34123;

            Console.WriteLine("Meu nome é " + nome + ", eu tenho " + idade + " anos e meu saldo é " + saldo.ToString("F2")); // Concatenação!
            Console.WriteLine("Meu nome é {0}, eu tenho {1} anos e meu saldo é {2:F2}", nome, idade, saldo); // Placeholders!
            Console.WriteLine($"{nome} tem {idade} e {saldo:F2} na conta"); // Interpolação!

            double a = 5.15;
            int b = 1;

            b = (int)a;
            Console.WriteLine(b);

            a = a / b;
            Console.WriteLine(a);

            Console.WriteLine(Math.Pow(2, 10));
            Console.WriteLine(Math.Sqrt(32));
        }
    }
}