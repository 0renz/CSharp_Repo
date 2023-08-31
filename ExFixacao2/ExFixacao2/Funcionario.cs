using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace ExFixacao2
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double Porcentagem)
        {
            SalarioBruto += (SalarioBruto / 100.0) * Porcentagem;
        }
      
        public override string ToString()
        {
            return Nome + ", $" +
                SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
