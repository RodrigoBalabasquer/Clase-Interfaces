﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public interface IAFIP
    {
        double CalcularImpuesto();
        double Impuesto
        {
            get;
            set;
        }
    }
}
