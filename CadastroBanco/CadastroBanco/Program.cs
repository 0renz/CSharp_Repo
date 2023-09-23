using System;
using System.Globalization;

namespace CadastroBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            char HaveraDeposito;
            double depIn;

            Console.WriteLine("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Haverá depósito inicial? (s/n)");
            HaveraDeposito = char.Parse(Console.ReadLine());

            if (HaveraDeposito == 's' || HaveraDeposito == 'S')
            {
                Console.WriteLine("\nDigite o valor do depósito inicial: ");
                depIn = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, nome, depIn);
            }
            else
            {
                conta = new Conta(numero, nome);
            }

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine("\nDigite o valor para depósito: ");
            depIn = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(depIn);

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine("\nDigite o valor para saque: ");
            depIn = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(depIn);

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}