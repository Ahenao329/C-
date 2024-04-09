using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
     class Avion: Vehiculo
    {

public void Aterrizar(){
            Console.WriteLine("Aterrizando");
        }

        public void Despegar() {
            Console.WriteLine("Despegando");

        }

        public override void Consucir()
        {
            Console.WriteLine("volando los cielos");

        }
    }
}
