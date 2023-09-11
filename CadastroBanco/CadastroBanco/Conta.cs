using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBanco
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double ValorEmConta { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double valoremconta) : this(numero, nome)
        {
            ValorEmConta = valoremconta;
        }

        public void Deposito(double depIn)
        {
            ValorEmConta += depIn;
        }

        public void Saque(double depIn)
        {
            double taxa = 5.00;
            ValorEmConta -= (depIn + taxa);
        }

        public override string ToString()
        {
            return "Conta: " +
                Numero + "\tTitular: " +
                Nome + "\t\tSaldo: $" +
                ValorEmConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
