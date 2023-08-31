using System;
using System.Globalization;

namespace ExFixacao1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite a largura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();
            Console.WriteLine("Digite a altura do retângulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = retangulo.Area(retangulo.Largura, retangulo.Altura);
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));

            double perimetro = retangulo.Perimetro(retangulo.Largura, retangulo.Altura);
            Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));

            double diagonal = retangulo.Diagonal(retangulo.Largura, retangulo.Altura);
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}