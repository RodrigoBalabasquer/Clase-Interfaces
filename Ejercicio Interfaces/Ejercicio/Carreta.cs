using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Carreta:Vehiculo,IARBA
    {
        public Carreta(double precio):base(precio)
        { }
        public override double Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }

        public double CalcularImpuesto()
        {
            return this._precio * 0.18; 
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
