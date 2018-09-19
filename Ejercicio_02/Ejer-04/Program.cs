using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int clase = 0;
            
            Console.WriteLine("### Bienvenido al sistema de Ingreso de calificaciones ###");
            Console.WriteLine("Digita el numero de clases que se tendran que calificar");
            
            clase = Convert.ToInt32(Console.ReadLine());

            Clase[] arregloClases = new Clase[clase];
            object[,] alumnos = new object[clase+1,200];
            for (int i = 0; i < arregloClases.Length; i++)
            {
                Clase nuevaClase = new Clase();
                nuevaClase.ClaseId = i + 1;
                Console.WriteLine("Ingrese el Nombre de la clase");
                nuevaClase.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de alumno");
                nuevaClase.CantidadAlumno = Convert.ToInt32(Console.ReadLine());
                arregloClases[i] = nuevaClase;
                
            }

            Console.WriteLine("Ha ingresado Los datos de su clase");
            Console.Write("\n");
            Console.WriteLine("Información Sobre las Clases");
            Console.WriteLine("Código \t Nombre Clase  \t  No Alumnos \n");

            for (int i = 0; i < arregloClases.Length; i++)
            {
                Console.WriteLine("{0} \t {1} \t {2} \n",arregloClases[i].ClaseId,arregloClases[i].Nombre,
                    arregloClases[i].CantidadAlumno);
            }
            

            
            Console.ReadKey();
        }
    }
}
