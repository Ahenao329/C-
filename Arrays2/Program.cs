using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arrayElementos = leerDatos();

            Console.WriteLine("IMPRIMIENDO DESDE LA CONSOLA");
            foreach (int i in arrayElementos) Console.WriteLine(i);



            int[] numeros = new int[4];
            numeros[0] = 7;
            numeros[1] = 4;
            numeros[2] = 3;
            numeros[3] = 12;

 

            ProcesaDatos(numeros);

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }

        
    static void ProcesaDatos(int[] datos)//metodo statico popr quue no estamos trabajando con clases, entonces no toca con metodos stactic
       {

            /*  foreach (int i in datos) { //no funciona
                datos[i]  +=10;
             }*/

            for (int i = 0; i < 4; i++) {
                datos[i] += 10;
            }
        }

        static int[] leerDatos()
        {
            Console.WriteLine("¿Cuantos elementos quieres que tenga el array?");
            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);
            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion{i}");
                respuesta = Console.ReadLine();
                int datosElementos = int.Parse(respuesta);
                datos[i] = datosElementos;

            }
            return datos;
        }   
            }
}
