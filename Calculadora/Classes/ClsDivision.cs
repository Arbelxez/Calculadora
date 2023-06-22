using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    internal class ClsDivision
    {
        public Double Dividir(Double N1, Double N2)
        {
            double D,d;
            D = N1 / N2;
            d = Math.Round(D,4);
            return d;
        }


    }
}
