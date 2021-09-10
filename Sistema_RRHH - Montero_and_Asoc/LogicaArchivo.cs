using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_RRHH___Montero_and_Asoc
{
    class LogicaArchivo
    {
        public void RegistrarArchivo(string id, string nombre, string cedula, string cargo, string department, double salary)
        {
            CONTEXTO contexto = null;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n*****          SELCCIONE COMO GUARDAR EL ARCHIVO          *****");
            Console.WriteLine("[1] Archivo TXT         [2] Archivo EXCEL         [3] Archivo JSON");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("\nHaz seleccionado archivo tipo TXT!!\n");
                EmpleadoTXT txt = new EmpleadoTXT();
                contexto = new CONTEXTO(txt);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("\nHaz seleccionado archivo tipo EXCEL!!\n");
                EmpleadoEXCEL excel = new EmpleadoEXCEL();
                contexto = new CONTEXTO(excel);
            }
            else if (opcion == 3)
            {
                Console.WriteLine("\nHaz seleccionado archivo tipo JSON!!\n");
                EmpleadoJSON json = new EmpleadoJSON();
                contexto = new CONTEXTO(json);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nALERTA!!\n");
                
            }
            Console.ResetColor();
            contexto.CreadorArchivo(id, nombre, cedula, cargo, department, salary);
        }
    }
}
