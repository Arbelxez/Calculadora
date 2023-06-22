using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    internal class ClsMultiplication
    {
        public Double Multiplicar(Double N1, Double N2)
        {
            double M,m;
            M = N1 * N2;
            m = Math.Round(M, 4);

            return m;
        }


    }
}
