using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInterface
{
    public class multiplicacion : IOperacion

    {
        public double resultado { get ; set ; }

        public void Calcular(double op1, double op2)
        {
            resultado = op1*op2;
        }

        public void Mostrar()
        {
           Console.WriteLine(" EL RESULTADO DE LA MULTIPLICACION ES {0} ",resultado) ;
        }
    }
}
