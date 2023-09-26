using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInterface
{
    public class suma : IOperacion
    {
        private double r=0;

        public double resultado { get ; set ; }

        public  void Calcular(double op1, double op2)
        {
            r = op1 + op2;
        }

        public void Mostrar()
        {
            Console.WriteLine(" EL RESULTADO DE LA SUMA ES {0} ",r);
        }
    }
}
