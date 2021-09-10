using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_RRHH___Montero_and_Asoc.Modulo_RRHH
{
    class FachadaRRHH
    {
        //Variables de referencia...
        Contratacion contrato = new Contratacion();
        private Desvinculacion salir;


        public void UsarContratar()
        {

            contrato.IngresoEmpleado();
            contrato.Contratar();//Llamada al metedo contratar...
            Console.ReadKey();
          
        }

        public void UsarDesvincular()
        {
            //Console.WriteLine("*** DESVINCULACION DE EMPLEADO ***");
            //Console.WriteLine("==> Ingrese la cedula del empleado: ");
            //double cedula = double.Parse(Console.ReadLine());
            //salir = new Desvinculacion(cedula);

        }

        public List<string> empleados = new List<string>();
        
        //public void AgregarSub(Contratacion persona)
        //{
        //    empleados.Add(persona);

        //}




    }
}
