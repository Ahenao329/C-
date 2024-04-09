using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            av1.mostrarAviso();


            AvisosTrafico av2 = new AvisosTrafico(" Jefatura Provincial Madrid ", " SANCION DE VELOCIDAD: 300$ ", " 02-05-19 ");

            av2.getFehca();

            av2.mostrarAviso();

        }
    }
}
