using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            //realizarTarea();
            // Console.WriteLine(intento(7, 6));

            /*clases anonimas*/
            var miVariable = new { Nombre = "Juan", Edad = 19 };
            Console.WriteLine(miVariable.Nombre + " ", miVariable.Edad);
            var miOtraVariable= new { Nombre ="Ana", Edad =25 };
            miVariable = miOtraVariable;
            
            
        }

        // static double intento(double var1, int var2) => (var1 / var2);

        static void realizarTarea()
        { 
            punto origen = new punto();
            punto destino = new punto(128,80);

           // origen.contadorDeObjetos(); vemos que no se puede llamar desde una instancia
            double distancia= origen.distanciaHasta(destino);
            Console.WriteLine($"la distancia entre los puntos es de: {distancia}");
            Console.WriteLine($"Numero de objetos creados: {punto.contadorDeObjetos()}");//si se puede llamar desde la clase, saldra la santidad de objetos que instanciemos.
            }
    }
                
       
    }

