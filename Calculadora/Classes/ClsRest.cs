using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    internal class ClsRest
    {
        public Double Restar(Double N1, Double N2)
        {
            double R,r;
            R = N1 - N2;
            r = Math.Round(R, 4);
            return r;
        }


    }
}
