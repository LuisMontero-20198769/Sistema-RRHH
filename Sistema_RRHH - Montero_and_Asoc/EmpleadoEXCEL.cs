using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sistema_RRHH___Montero_and_Asoc
{
    class EmpleadoEXCEL: IEstrategy
    {
        public void Generar_Archivo(string id,string nombre, string cedula, string cargo, string department, double salary)
        {
            if (File.Exists("empleado.xlsx"))
            {
                SLDocument iLDocument = new SLDocument();
                SLWorksheetStatistics propiedades = iLDocument.GetWorksheetStatistics();
                int ultimafila = propiedades.EndRowIndex;
                
                for (int x = 2; x <= ultimafila; x++)
                {
                    string m = iLDocument.GetCellValueAsString("A" + x);
                    string n = iLDocument.GetCellValueAsString("B" + x);
                    string a = iLDocument.GetCellValueAsString("C" + x);
                    string c = iLDocument.GetCellValueAsString("D" + x);
                    string d = iLDocument.GetCellValueAsString("E" + x);
                    string t = iLDocument.GetCellValueAsString("F" + x);
                

                    iLDocument.SetCellValue("A" + x, m);
                    iLDocument.SetCellValue("B" + x, n);
                    iLDocument.SetCellValue("C" + x, a);
                    iLDocument.SetCellValue("D" + x, c);
                    iLDocument.SetCellValue("E" + x, d);
                    iLDocument.SetCellValue("F" + x, t);

                }
                iLDocument.SetCellValue("A" + ultimafila, id);
                iLDocument.SetCellValue("B" + ultimafila, nombre);
                iLDocument.SetCellValue("C" + ultimafila, cedula);
                iLDocument.SetCellValue("D" + ultimafila, cargo);
                iLDocument.SetCellValue("E" + ultimafila, department);
                iLDocument.SetCellValue("F" + ultimafila, salary);


                iLDocument.SaveAs("empleado.xlsx");
                Console.WriteLine("\nXLSX con exito!!!\n");
            }
            else
            {
                SLDocument eLDocument = new SLDocument();
                System.Data.DataTable dt = new System.Data.DataTable();

                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Cedula", typeof(string));
                dt.Columns.Add("Cargo", typeof(string));
                dt.Columns.Add("Departamento", typeof(string));
                dt.Columns.Add("Salario", typeof(string));
               

                dt.Rows.Add(id, nombre, cedula, cargo, department, salary);

                eLDocument.ImportDataTable(1, 1, dt, true);

                eLDocument.SaveAs("empleado.xlsx");
                Console.WriteLine("\nXLSX con exito!!!\n");
            }
        }
    }
}
