using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* caballo Babieca = new caballo("Babieca");
            IMamiferosTerrestres IMiBabieca = Babieca; // Principio de sustitucion "Es  un", estamos diciendo que un caballo es un mamifero terrestre

            Humano Humano = new Humano("Jose");

            Gorila gorila = new Gorila("Kong");

            /*  Humano.getNombre();
              Humano.cuidarCrias();*/
            // caballo animal = new Mamiferos("bucefalo");//esto esta mal, esta justo al revez
           /* Mamiferos animal = new caballo("Bucefalo"); //PRINCIPIO DE SUSTITUCION:
            caballo Bucefalo = new caballo("Bucefalo");

            animal = Bucefalo;
            //Bucefalo = animal; //Error



            //jerarquia object

            object miAnimal = new caballo("Bucefalo");
            // object miMamifero = new Mamiferos("Waly");


            //arrays
            Mamiferos[] almacenAnimales = new Mamiferos[3];
            almacenAnimales[0] = Babieca;
            almacenAnimales[1] = Humano;
            almacenAnimales[2] = gorila;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].peensar();


            }
            Ballena miWally = new Ballena("Wally");
            miWally.nadar();
            Console.WriteLine("Numero de patas de mi babieca " + IMiBabieca.numeroPatas());//Asi sabe que me estoy refiriendo al numero de patas del mamifero terrestre*/


    //Ejecucion de metodo y clase abstracta
            lagartija Juancho = new lagartija("Juancho");
            Juancho.getNombre();
            Juancho.respirar();

            Humano Juan = new Humano("Juan");
            Juan.respirar();
            Juan.getNombre();



        }

    }

    /********************************INTERFACES***************************************************/
     interface IMamiferosTerrestres
        {
            int numeroPatas(); //Los metodos de la interfaz no se desarrollan, no se habre yave, ni se cierra yave, no hay codigo ni modificadores en los metodos
        }

     interface IAnimalesYDeportes
        {
             string tipoDeporte();
             Boolean esOlimpico();
         }

      interface ISaltoConPatas
        {
             int numeroPatas(); //Los metodos de la interfaz no se desarrollan, no se habre yave, ni se cierra yave, no hay codigo ni modificadores en los metodos
         }
    abstract class Animales //la clase abstrata, padr o de mayor jerarquia
    {

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre(); // asi, por que no es el mismo para todos

    }


    class lagartija : Animales
    {

        public lagartija( string nombre) 
        {
            nombreReptil = nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil: " + nombreReptil);
        }

        private string nombreReptil;
    }
    class Mamiferos : Animales
    {
       
        public Mamiferos(string nombre)
        {

            nombreSerVivo = nombre;
        }

        public virtual void peensar()
        {// caundo tenemos metodos hijos que necesitan modificar el padre, podemos definir el metodo virtual, asi le indicamos que todas las sub-clases de mamiferos deberian  tener un metodo pensar que modifiquen el metodo pensar de la clase mamifero, mya sea agregandole o quitandole algo, pero deben ser toda
            Console.WriteLine("Pensamiento basico instintivo");
        }


        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del ser viivo es: " + nombreSerVivo);
        }
        private string nombreSerVivo;


    }

    class caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    { //heredamos lo de mamiferos

        public caballo(string nombreCaballo) : base(nombreCaballo)
        {



        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
        /* public int numeroPatas()
         {
             return 4;
         }*/

        int IMamiferosTerrestres.numeroPatas()
        {
            return 4;
        }
        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }
        public string tipoDeporte()
        {
            return "Hipica";
        }

        public Boolean esOlimpico() { 
            return true;
        }
    }

    class Humano : Mamiferos
    { //heredamos lo de mamiferos

        public Humano(string nombreHumano) : base(nombreHumano)
        {



        }
        public void peensar()//me lo subraya por que ya existe en mamiferos, y lo que bhace es anular el metodo pensar que esta heredando de mamiferos, si le agregaramos un parametro ya seria una sobrecarga y quitaria la advertencia
        {
            Console.WriteLine("Soy capaz de pensar ¿? o no");
        }
    }
    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {
        }

        public void nadar() {
            Console.WriteLine("Soy capas de nadar");
        }

    }



     sealed class Gorila : Mamiferos, IMamiferosTerrestres
        {

            public Gorila(string nombreGorila) : base(nombreGorila)
            {



            }
            //heredamos lo de mamiferos
            public void trepar()
            {
                Console.WriteLine("Soy capaz de trepar");
            }
            public override void peensar()//Cuando decimos override, le estamos diciendo que es la modificacion del metodo padre
            {
                Console.WriteLine("Soy capaz de pensar y soy gorila");
            }

            public int numeroPatas() 
            {
            return 2;
            }
        }
    //Metod que intento heredar de una clase sealed

       /* class Chimpanse : Gorila
        {
        public Chimpanse(string nombreChimpance) : base(nombreChimpance)
        { 
        
        }
        
    
    
        }*/


    }

