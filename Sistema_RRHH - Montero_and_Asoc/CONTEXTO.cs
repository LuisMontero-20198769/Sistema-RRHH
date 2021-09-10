using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_RRHH___Montero_and_Asoc
{
    class CONTEXTO 
    {
        IEstrategy estrategia;
        public CONTEXTO(IEstrategy objeto)
        {
            this.estrategia = objeto;
        }
        public void CreadorArchivo(string id, string nombre, string cedula, string cargo, string department, double salary)
        {
            estrategia.Generar_Archivo(id, nombre, cedula, cargo, department, salary);
        }

    }
}
