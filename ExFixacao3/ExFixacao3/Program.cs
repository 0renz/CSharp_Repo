using System.Globalization;

namespace ExFixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            bool validaNota;

            Console.WriteLine("Nome do aluno: ");
            a.Nome = Console.ReadLine();

            do
            {
                validaNota = true;
                Console.Clear();
                Console.WriteLine("Nota 1 do aluno: ");
                a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Nota 2 do aluno: ");
                a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Nota 3 do aluno: ");
                a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if ((a.Nota1 > 30 || a.Nota1 < 0) ||
                    (a.Nota2 > 35 || a.Nota2 < 0) ||
                    (a.Nota3 > 35 || a.Nota3 < 0))
                {
                    Console.WriteLine("Erro na validação de notas, tente novamente.");
                    System.Threading.Thread.Sleep(2000);
                    validaNota = false;
                }
            } while (!validaNota);


            Console.WriteLine("NOTA FINAL: " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Falta " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}