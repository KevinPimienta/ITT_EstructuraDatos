using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Operaciones
    {
        internal void Principal()
        {
            List<Persona> personas=IniciarLIstas();

            var persona = (from p in personas
                           select p).LastOrDefault();


            Console.ReadLine();
        }

        private List<Persona> IniciarLIstas()
        {
            List<Persona> personas = new List<Persona>();
            Persona persona = new Persona();

            persona.Id = 1;
            persona.Nombre = "Jesus de los polllos";
            persona.Edad = 27;
            persona.Direccion = "Av de los cabos #69";
            persona.Ciudad = "Tagamandapio,Michoacan";

            personas.Add(persona);
            Persona persona2 = new Persona();
            persona2.Id = 2;
            persona2.Nombre = "Jesus de los polllos";
            persona2.Edad = 27;
            persona2.Direccion = "Av de los cabos #69";
            persona2.Ciudad = "Tagamandapio,Michoacan";

            personas.Add(persona2);

            return personas;
        }
    }
}
