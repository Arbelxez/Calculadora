using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    internal class ClsSum
    {
        public Double Sumar(Double N1, Double N2)
        {
            double S,s;
            S = N1 + N2;
            s = Math.Round(S, 4);
            return s;
        }


    }
}
