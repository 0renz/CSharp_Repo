using System.Collections.Generic;

namespace TesteListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string> { "AAAAA", "BBBBB" };

            list.Add("Ronaldo");
            list.Add("Rodolfo");
            list2.Add("Mauricio");

            list.Insert(1, "Paulo");

            Console.WriteLine(list);
            Console.WriteLine(list2);

            foreach (string name in list)
                Console.Write(name + " ");

            Console.WriteLine("");

            foreach (string name in list2)
                Console.Write(name + " ");

            Console.WriteLine("\n" + list.Count());

            string s1 = list.Find(Test);
            Console.WriteLine("First 'R' of the first list: " + s1);
            // retorna o primeiro nome da lista o qual possue 'A' como primeiro elemento da string

            string s2 = list2.Find(x => x[0] == 'B');
            Console.WriteLine("First 'B': of the second list: " + s2);
            // fazendo a mesma coisa sem uma função, apenas com uma expressão lambda

            string s3 = list.FindLast(x => x[0] == 'R');
            Console.WriteLine("Last 'R' of the first list: " + s3);
            // fazendo a mesma coisa sem uma função, apenas com uma expressão lambda

            int pos1 = list.FindIndex(x => x[0] == 'R');
            Console.WriteLine("First position 'R': " + pos1);
            // encontrar os indices
            int pos2 = list.FindLastIndex(x => x[0] == 'R');
            Console.WriteLine("Last position 'R': " + pos2);

            List<string> Result = list.FindAll(x => x.Length == 5);
            foreach (string name in Result)
                Console.Write(name + " ");
            // cria uma lista filtrada

            list2.Remove("AAAAA");
            // elemento AAAAAA removido
            Console.WriteLine("");
            foreach (string name in list2)
                Console.Write(name + " ");

            list2.RemoveAll(x => x[0] == 'B');
            // BBBBB removido (e todos aqueles que começam com 'B')

            Console.WriteLine("");
            foreach (string name in list2)
                Console.Write(name + " ");

            list2.RemoveAt(0);
            // remove pelo índice
            Console.WriteLine("\nLista 2: ");
            foreach (string name in list2)
                Console.Write(name + " ");


            list.RemoveRange(0, 3);
            // a partir do indice x remove x elementos 

            Console.WriteLine("Lista 1: ");
            foreach (string name in list)
                Console.Write(name + " ");

        }

        static bool Test(string s)
        {
            return s[0] == 'R';
        }
    }
}