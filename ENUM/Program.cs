using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*   //si queremos valores nulos con con tipo enum
               Estaciones? alergias = null; //se debe poner el ? 
               Estaciones alergia = Estaciones.primavera;
               string La_Alergia = alergia.ToString();//no es string si queremos verlo como string tocaria convertirlo
               Console.WriteLine(alergia);  */

            /* Bonus Antonio = Bonus.bueno;

             double bonusAntonio = (double)Antonio;
             double salarioAntonio = 1500 + bonusAntonio;

             Console.WriteLine("Antonio tiene un bonus " + Antonio  + " su valor es de " + bonusAntonio + " " + salarioAntonio); 
             Console.WriteLine(bonusAntonio); */

            Empleado Juan = new Empleado(Bonus.estra, 1900.50);

            Console.WriteLine("El salario del empleado es: " + Juan.getSalario());

        }

    }
    /* enum Estaciones { primavera, verano, octoño, invierno };*/
    class Empleado {

        public Empleado(Bonus bonusEmpleado, double salario) 
        { 
         bonus = (double)bonusEmpleado; 
         this.salario = salario;
        }


        public double getSalario()
        {
            return salario + bonus;
        }


    private double salario, bonus;
    
    }
    enum Bonus { bajo=500, normal = 1000, bueno = 3000, estra = 3000};
}
  

