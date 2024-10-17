using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Class
{
    public class Pasajero : Persona
    {
        public int NumeroPasajero { get; set; }
        public List<Vuelo> Vuelos { get; set; } = new List<Vuelo>();

        private static List<Pasajero> pasajeros = new List<Pasajero>();

        public void CrearPasajero()
        {
            pasajeros.Add(this);
        }

        public static Pasajero LeerPasajero(int numeroPasajero)
        {
            return pasajeros.FirstOrDefault(p => p.NumeroPasajero == numeroPasajero);
        }

        public void ActualizarPasajero()
        {
            var pasajero = LeerPasajero(this.NumeroPasajero);
            if (pasajero != null)
            {
                pasajero.Nombres = this.Nombres;
                pasajero.Apellidos = this.Apellidos;
                pasajero.Vuelos = this.Vuelos;
                Console.WriteLine("Pasajero actualizado.");
            }
            else
            {
                Console.WriteLine("Pasajero no encontrado.");
            }
        }

        public static void EliminarPasajero(int numeroPasajero)
        {
            var pasajero = LeerPasajero(numeroPasajero);
            if (pasajero != null)
            {
                pasajeros.Remove(pasajero);
                Console.WriteLine("Pasajero eliminado.");
            }
            else
            {
                Console.WriteLine("Pasajero no encontrado.");
            }
        }
    }
}
