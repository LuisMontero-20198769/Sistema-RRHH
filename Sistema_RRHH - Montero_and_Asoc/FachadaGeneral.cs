using Sistema_RRHH___Montero_and_Asoc.Modulo_Nomina;
using Sistema_RRHH___Montero_and_Asoc.Modulo_RRHH;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_RRHH___Montero_and_Asoc
{
    class FachadaGeneral
    {
        //Objetos...
         FachadaRRHH fach_rrhh = new FachadaRRHH();//Creando el objeto de tipo fachada RRHH (RECURSOS HUMANOS)
         FachadaNomina nomina = new FachadaNomina();
        public void Servicios(){
            int opcion;//Variable 
            do{
                Console.Clear();//Limpiar pantallaa
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("********************************************");
                Console.WriteLine("*                                          *");
                Console.WriteLine("*  MONTERO & ASOC. ARQUITECT SOFTWARE INC. *");
                Console.WriteLine("*         'Hacemos lo que imagines'        *");
                Console.WriteLine("*                                          *");
                Console.WriteLine("********************************************\n");
                Console.WriteLine("-----//               Menu            //-----\n");
                Console.WriteLine("[1]Contratar   [2]Pagar  [3]Desvincular  [4]Salir");
                Console.ResetColor();
                opcion = int.Parse(Console.ReadLine());//Lee la opcion deseada....
                Console.WriteLine();//Salto de linea..
                switch (opcion)
                {
                    case 1:
                        fach_rrhh.UsarContratar();
                        break;
                    case 2:
                        nomina.UsarPago();
                        break;
                    case 3:
                        fach_rrhh.UsarDesvincular();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Haz elegido salir! :)");
                        Console.ResetColor();
                        break;
                }
            } while (opcion != 4);
        }

    }
}
