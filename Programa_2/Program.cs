using System;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Globalization;

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

            string frase, x, y, z;

            /*
            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < vet.Length; i++)
            {
                if (i < (vet.Length) - 1)
                    Console.Write(vet[i] + " - ");
                else
                    Console.Write(vet[i]);
            }
            

            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);

            Console.WriteLine("Digite um caracter: ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(ch);

            Console.WriteLine("Digite um número quebrado: "); // PC em PT-BR -> 4.5 = 4,5
            float num = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(num.ToString(CultureInfo.InvariantCulture));

            */

            string[] dados = Console.ReadLine().Split(' ');

            string nome2 = dados[0];
            char sexo = char.Parse(dados[1]);
            int idade2 = int.Parse(dados[2]);
            double altura = double.Parse(dados[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome2);
            Console.WriteLine(sexo);
            Console.WriteLine(idade2);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
