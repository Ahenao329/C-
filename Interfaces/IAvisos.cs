using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
     interface IAvisos
    {

        //En un aviso es fundamental mostrar el Aviso con su fecha, por eso, nos aseguramos de que se cumpla con las interfaces
        void mostrarAviso();

        string getFehca();   
    }
}
