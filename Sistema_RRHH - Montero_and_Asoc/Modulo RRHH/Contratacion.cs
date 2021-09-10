using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_RRHH___Montero_and_Asoc.Modulo_RRHH
{
    public class Contratacion
    {
        //Atributos...
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string department { get; set; }
        public string cargo { get; set; }
        public double salary { get; set; }
        public string ID { get; set; }
        
        
        //Constructor de la clase...
        public Contratacion() { }

        
        LogicaArchivo archivo = new LogicaArchivo();//Objeto de la clase logica de archivo....
        public static List<Contratacion> listDatosEmp = new List<Contratacion>();
        public void IngresoEmpleado()
        {
            Console.Clear();
            Contratacion almacena = new Contratacion();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*******************************************");
            Console.WriteLine("*                                         *");
            Console.WriteLine("*          REGISTRO DE EMPLEADO           *");
            Console.WriteLine("*                                         *");
            Console.WriteLine("*******************************************\n");
            Console.WriteLine("*****       DATOS DEL EMPLEADO        ****:\n");
           
            Console.WriteLine("==> Ingrese el nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("==> Igrese la cedula:");
            cedula = Console.ReadLine();
            Console.WriteLine("==> Ingrese el cargo:");
            cargo = Console.ReadLine();
            Console.WriteLine("==> Ingrese el departamento:");
            department = Console.ReadLine();
            Console.WriteLine("==> Ingrese el salario:");
            salary = int.Parse(Console.ReadLine());
            Random aleatorio = new Random();
            int numaleat = aleatorio.Next(1000, 10000);
            almacena.ID = "E-" + numaleat;
            Console.WriteLine("Codigo: " + almacena.ID);

            listDatosEmp.Add(almacena);
            archivo.RegistrarArchivo(ID, nombre, cedula, cargo, department,salary);//Envio de datos al contralador de archivos
            Console.ResetColor();
        }

        //Metodo contratar
        public void Contratar()
        {
            //Mensaje de Aceptacion de contrato...

            Console.WriteLine();//Salto de linea
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"*** EMPLEADO CONTRATADO ***\n" +
                $" => ID:{ID}"+
                $"=> Nombre: {nombre} \n" +
                $"=> Cedula: {cedula} \n" +
                $"=> Cargo: {cargo} \n" +
                $"=> Departamento: {department} \n" +
                $"=> Salario: RD${salary}.00");
            Console.ResetColor();
            Console.ReadKey();
        }
          
    }

   
}
