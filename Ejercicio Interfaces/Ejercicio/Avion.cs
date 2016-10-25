using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Avion:Vehiculo,IAFIP,IARBA
    {
        protected double _velocidadMaxima;
        public Avion(double precio, double velocidadMaxima):base(precio) 
        {
            this._velocidadMaxima = velocidadMaxima;
        }
        public override double Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
        public virtual double VelocidadMaxima 
        {
            get 
            {
                return this._velocidadMaxima;
            }
            set 
            {
                this._velocidadMaxima = value;
            }
        }
        public double CalcularImpuesto()
        {
            return this._precio * 0.33; 
        }

        public double Impuesto
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

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.27;
        }
        double IARBA.Impuesto
        {
            get
            {
                return ((IARBA)this).CalcularImpuesto();
            }
            set
            {
                this._precio = this._precio + this.CalcularImpuesto();
            }
        }
    }
}
