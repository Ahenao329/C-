using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
     class Vehiculo
    {


        public void arrancarMotor(string sonidoAlArrancar) {
            Console.WriteLine($"Arrancando el motor:{sonidoAlArrancar} ");
        }

        public void pararMotor(string sonidoParar)
        {
            Console.WriteLine($"Parando el motor:{sonidoParar} ");
        }

        public virtual void Consucir() {
            Console.WriteLine($"Este es el metodo generico para el metodo conducir");
        }
    }
}
