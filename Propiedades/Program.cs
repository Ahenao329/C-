using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {

          /* Empleado Juan = new Empleado("Juan");

            /*Juan.SALARIO = 1200;
            Juan.SALARIO  += 700;*/
           // Juan.SALARIO = -333;
          //  Console.WriteLine("El salario del empleado es: " + Juan.SALARIO);
            /*  Juan.setSalario(1200);

              Console.WriteLine("El salario del empleado es: " + Juan.getSalario());

             // Juan.salario  += 700; <-- sin encapsular*/


            Empleado empleado1 = new Empleado(1200, 250);
            empleado1.cambiarSalario(empleado1, 100);
            Console.WriteLine(empleado1);
         }
    }

   public struct Empleado //los cambios no se ven reflejados por ser estructura 
    {
       /* public Empleado(string nombre)
        {
            this.nombre = nombre;
        }*/

        public Empleado(int salario, int comision) { 
            this.salario = salario;
            this.comision = comision;
        }

        public override string ToString()
        {
            return String.Format("Salario y comision del empleado {0}, {1}", this.salario, this.comision);
        }

        public void cambiarSalario(Empleado emp, double incremento)
        {
            emp.salario += incremento;
            emp.comision += incremento;
        }
        /* public void setSalario(double salario)
         {
             if (salario < 0)
             {
                 Console.WriteLine("El salario no puede ser negativo, se asignara 0 como salario");
                 this.salario = 0;
             }
             else
             {
                 this.salario = salario;
             }
         }*/


        /*public double getSalario()
         {
          return salario;
         }*/


        //PROPIEDADES*************************************PROPIEDADES|\\

        private double evaluarSalario(double salario)
        { 
        if (salario < 0) {return 0;

        }else return salario;    
        }


        //Propiedades
       /* public double SALARIO
        {
            get { return this.salario; }
            set { this.salario = evaluarSalario(value); }
        }*/


        public double SALARIO
        {
            get => this.salario;
            set => this.salario = evaluarSalario(value);
        }
        //campos encapsulados
        private double salario, comision;
       // private string nombre;
    }
}
