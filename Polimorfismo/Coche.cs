using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
     class Coche: Vehiculo
    {

        public void Acelerar() {
            Console.WriteLine("Acelerando");

        }

        public void Frenar()
        {
            Console.WriteLine("Frenando");

        }
    }
}
