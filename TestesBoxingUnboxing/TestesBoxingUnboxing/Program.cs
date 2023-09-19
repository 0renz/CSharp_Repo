namespace TestesBoxingUnboxingForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            Object obj = x; //boxing
            Console.WriteLine(obj);

            int y = (int)obj; //unboxing
            Console.WriteLine(y);

            string[] vect = new string[] {"AAAAA", "BBBBB", "CCCCC"};

            foreach (string ve in vect) // para cada "ve" contido em "vect"
            {
                Console.Write(ve + " ");
            }
        }
    }
}