using System;
using System.Globalization;

namespace ExFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.WriteLine("Nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + f);

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(Porcentagem);

            Console.Write("Dados atualizados: " + f);
        }
    }
}