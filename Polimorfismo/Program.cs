using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Probando el avion");
            Avion miAvion = new Avion();

            miAvion.arrancarMotor("tracatractraca");
            miAvion.Despegar();
            miAvion.Consucir();
            miAvion.pararMotor("Ploof");
            Console.WriteLine();
            Console.WriteLine($"Probando el coche");
            Coche miCoche= new Coche();
            miCoche.arrancarMotor("grrum grrruum");
            miCoche.Acelerar();
            miCoche.Frenar();
            miCoche.pararMotor("bluuuuf");
            miCoche.Consucir();

            Console.WriteLine();
            Console.WriteLine("Polimorfismo en accion");
            Vehiculo miVehiculo = miCoche;
            miVehiculo.Consucir();//polimorfismo es que un objeto en el mismo programa se comporte de dos formas diferentes

            miVehiculo = miAvion;
            miVehiculo.Consucir();
        }
    }
}
