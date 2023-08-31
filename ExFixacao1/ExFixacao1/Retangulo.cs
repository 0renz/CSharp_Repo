namespace ExFixacao1
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area(double L, double A)
        {
            return L * A;
        }
        public double Perimetro(double L, double A)
        {
            return (L + A) * 2;
        }
        public double Diagonal(double L, double A)
        {
            return Math.Sqrt(Math.Pow(L, 2) + Math.Pow(A, 2));
        }
    }
}
