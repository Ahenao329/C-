using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //array implicitos

            //var datos = new[] {"Juan", "Diaz", 15} //Falla poe que no podra detectar que tipo es

            var valoree = new[] { 15, 35, 75.5, 28.5 }; //los toma como doubbles

            //arrays de objectos
            Empleados Ana = new Empleados("Ana", 27);
            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = new Empleados("Sara", 37);//1 forma de lllenarlo

            arrayEmpleados[1] = Ana;//2forma de llenarlo 



            //ARRAAY DE TIPOS O CLASES ANONIMAS
            var personas = new[]
            {
             new{ nombre = "Juan", Edad = 19} ,
            new { nombre = "Juan", Edad = 19 },
            new { nombre = "Juan", Edad = 19 }
             };

            //nsole.WriteLine(personas[1]);
     /* for (int i = 0; i <=3; i++)
            {

                Console.WriteLine(valoree[i]);

            }*/


            for(int i = 0; i < arrayEmpleados.Length; i++) //acediendo a un solo de los cambios 
            {
           
                Console.WriteLine(arrayEmpleados[i].nombre);

            }


            /* nt contador = 0;
                for (int i =15; i >=11; i--)
                {

                    Console.WriteLine(valoree[contador]);
                    contador++; 

                }*/


            //bucle foreach es super util para ver lo que hay en arrays 

            foreach (Empleados variable in arrayEmpleados) {
                Console.WriteLine(variable.nombre);
            }

        }

      class Empleados
        {
            public Empleados(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
          public string nombre { get; }
            int edad;
        }
    }
}