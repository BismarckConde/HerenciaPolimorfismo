﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInterface
{
    public interface IOperacion
    {
        double resultado { get; set; }
        void Calcular(double op1, double op2);
        void Mostrar();
        
    }
}
