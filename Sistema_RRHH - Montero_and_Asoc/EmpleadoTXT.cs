using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sistema_RRHH___Montero_and_Asoc
{
    class EmpleadoTXT : IEstrategy
    {
        public void Generar_Archivo(string id, string nombre, string cedula, string cargo, string department, double salary)
        {
            StreamWriter TXT = new StreamWriter("empleado.txt");
            TXT.WriteLine(

             $"ID: {id}"+
             $"Nombre: {nombre}\n" +
             $"Cedula:  {cedula}\n" +
             $"Cargo : {cargo} \n" +
             $"Departamento :  {department} \n" +
             $"Salario: {salary} \n"
             );
            TXT.Close();
        }
    }
}
