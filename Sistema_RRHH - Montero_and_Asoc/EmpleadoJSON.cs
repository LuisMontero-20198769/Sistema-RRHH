using System;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Sistema_RRHH___Montero_and_Asoc
{
    class EmpleadoJSON : IEstrategy
    {
        public void Generar_Archivo(string id, string nombre, string cedula, string cargo, string department, double salary)
        {
            string almacena = $"*****  DATOS DEL EMPLEADO ********" +
                $"\nID: {id}\n"+
                $"Nombre: {nombre}\n" +
                $"Cedula: {cedula}\n" +
                $"Cargo: {cargo}\n" +
                $"Departamento: {department}\n" +
                $"Salary: {salary}\n";
            string pathFile = "empleados.json";
            string vJson = JsonConvert.SerializeObject(almacena, (Newtonsoft.Json.Formatting)System.Xml.Formatting.None);
            File.AppendAllText(pathFile, vJson);
            Console.WriteLine("\nArchivo JSON guardado!!\n");
        }
    }
}
