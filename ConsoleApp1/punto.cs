using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class punto
    {
        private int x, y;
        private static int contadorObjetos=0;   //ejemplo static
        public punto()
        {
            this.x = 0;
            this.y = 0;
            contadorObjetos++;
        }


        public punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorObjetos++;//para contador general de objetos
        }


        public double distanciaHasta(punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;    
            double distanciaPuntos= Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
                return distanciaPuntos;
        }

       /* public static int contadorDeObjetos() { 
        return contadorObjetos;
        }*/
       public   static  int contadorDeObjetos()=> contadorObjetos;
    }
}//no es necesario que el metodo sea statico, pero es mejor 
