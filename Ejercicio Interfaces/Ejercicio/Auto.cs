using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Auto:Vehiculo
    {
        protected string _patente;
        public Auto(double precio, string patente):base(precio) 
        {
            this._patente = patente;
        }
        public override double Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
        public virtual string Patente 
        {
            get 
            {
                return this._patente;
            }
            set 
            {
                this._patente = value;
            }
        }
        public void MostrarPatente() 
        {
            Console.WriteLine("Patente: " + this._patente);
        }
    }
}
