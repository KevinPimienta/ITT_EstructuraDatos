using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED3_1
{
    public class Operaciones
    {
        public void Principal()
        {
            Console.WriteLine("Ingrese la cantidad de Carros");
            int cantidad = int.Parse(Console.ReadLine());
            Auto carro;
            List<Auto> carros = new List<Auto>();
            for (int i = 0; i < cantidad; i++)
            {
                 carro = new Auto();
                carro.Id = i+1;
                Console.WriteLine("Asigne una marca");
                carro.Marca = Console.ReadLine();
                Console.WriteLine("Asigne una modelo");
                carro.Modelo = Console.ReadLine();
                Console.WriteLine("Asigne una Año");
                carro.Anio = int.Parse(Console.ReadLine());
                Console.WriteLine("Asigne una Color");
                carro.Color = Console.ReadLine();
                Console.WriteLine("Asigne una Placa");
                carro.Placa = Console.ReadLine();
                carros.Add(carro);
            }
            Console.ReadKey();
            foreach (var item in carros)
            {
                Console.WriteLine(item.Marca +" "+item.Modelo +""+item.Placa);
            }

            Console.ReadKey();

            var carroAzules = (from c in carros
                               where c.Color == "azul"
                               select c).ToList();

            foreach (var item in carroAzules)
            {
                Console.WriteLine(item.Modelo+" "+item.Placa+" "+item.Color);
            }

        }
    }
}
