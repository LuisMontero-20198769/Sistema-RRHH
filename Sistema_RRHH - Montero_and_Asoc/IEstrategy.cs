using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_RRHH___Montero_and_Asoc
{
    interface IEstrategy
    {
        void Generar_Archivo(string id,string nombre, string cedula, string cargo, string department, double salary);
    }
}
