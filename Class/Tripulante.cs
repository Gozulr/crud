using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Class
{
    public class Tripulante : Persona
    {
        public int NumeroTripulante { get; set; }
        public string VueloAsignado { get; set; }
        public string Cargo { get; set; }

        private static List<Tripulante> tripulantes = new List<Tripulante>();

        public void CrearTripulante()
        {
            tripulantes.Add(this);
            Console.WriteLine("Tripulante creado.");
        }

        public static Tripulante LeerTripulante(int numeroTripulante)
        {
            return tripulantes.FirstOrDefault(t => t.NumeroTripulante == numeroTripulante);
        }

        public void ActualizarTripulante()
        {
            var tripulante = LeerTripulante(this.NumeroTripulante);
            if (tripulante != null)
            {
                tripulante.Nombres = this.Nombres;
                tripulante.Apellidos = this.Apellidos;
                tripulante.VueloAsignado = this.VueloAsignado;
                tripulante.Cargo = this.Cargo;
                Console.WriteLine("Tripulante actualizado.");
            }
            else
            {
                Console.WriteLine("Tripulante no encontrado.");
            }
        }

        public static void EliminarTripulante(int numeroTripulante)
        {
            var tripulante = LeerTripulante(numeroTripulante);
            if (tripulante != null)
            {
                tripulantes.Remove(tripulante);
                Console.WriteLine("Tripulante eliminado.");
            }
            else
            {
                Console.WriteLine("Tripulante no encontrado.");
            }
        }
    }
}
