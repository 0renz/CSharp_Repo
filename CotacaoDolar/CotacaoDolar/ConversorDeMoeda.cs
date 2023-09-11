using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    internal class ConversorDeMoeda
    {
        public static double converteMoeda(double CotDolar, double Dolares)
        {
            double MoedaConvertida = CotDolar * Dolares;
            double ValorASerPago = MoedaConvertida + ((MoedaConvertida / 100) * 6);
            return ValorASerPago;
        }
    }
}
