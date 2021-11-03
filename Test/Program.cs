using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            const string RUTA = "F:\\Trabajo\\Dimen GTR\\Base Novedades.accdb";
            EmpleadosDAO empleadosDAO = new EmpleadosDAO(RUTA);
            try
            {
                List<Empleado> empleados = empleadosDAO.LeeEmpleadosDeLaBase();
                foreach (Empleado empleado in empleados)
                {
                    Console.WriteLine(empleado.MostrarDatos());
                    Console.WriteLine("========================================");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine(empleadosDAO.RutaConexion);

            
            Console.ReadKey();
        }
    }
}
