using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Comercial:Avion,IARBA
    {
        public Comercial(double precio,double velocidad):base(precio,velocidad)
        {

        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.25; 
        }
        double IARBA.Impuesto
        {
            get
            {
                return this.CalcularImpuesto();
            }
            set
            {
                this._precio = this._precio + this.CalcularImpuesto();
            }
        }
    }
}
