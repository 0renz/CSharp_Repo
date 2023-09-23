using System;
using System.Globalization;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dolar?");
            double CotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            double Dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorConvertido = ConversorDeMoeda.converteMoeda(CotDolar, Dolares);
            Console.WriteLine("Valor a ser pago em reais: " + valorConvertido.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
