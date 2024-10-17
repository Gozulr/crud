using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Crud.Class
{
    public class Persona
    {
        public string NumeroIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        private static List<Persona> personas = new List<Persona>();
        

        public void CrearPersona()
        {
            personas.Add(this);
            Console.WriteLine("Persona creada.");
        }

        public static Persona LeerPersona(string numeroIdentificacion)
        {
            return personas.FirstOrDefault(p => p.NumeroIdentificacion == numeroIdentificacion);
        }

        public void ActualizarPersona()
        {
            var persona = LeerPersona(NumeroIdentificacion);
            if (persona != null)
            {
                persona.Nombres = Nombres;
                persona.Apellidos = Apellidos;
                Console.WriteLine("Persona actualizada.");
            }
            else
            {
                Console.WriteLine("Persona no encontrada.");
            }
        }

        public static void EliminarPersona(string numeroIdentificacion)
        {
            var persona = LeerPersona(numeroIdentificacion);
            if (persona != null)
            {
                personas.Remove(persona);
                Console.WriteLine("Persona eliminada.");
            }
            else
            {
                Console.WriteLine("Persona no encontrada.");
            }
        }
    }
}
