using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main()
        {
            Avion UnA = new Avion(100, 999);
            Console.WriteLine(UnA.CalcularImpuesto());
            Console.WriteLine(((IARBA)UnA).CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestoNacional(UnA));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(UnA));
            Console.ReadKey();
        }
    }
}
