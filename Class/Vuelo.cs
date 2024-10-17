using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Class
{
    public class Vuelo
    {
        public string NumeroVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
        public List<Pasajero> Pasajeros { get; set; } = new List<Pasajero>();
        public List<Tripulante> Tripulantes { get; set; } = new List<Tripulante>();
        public Avion Avion { get; set; }
        public string EstadoVuelo { get; set; }

        private static List<Vuelo> vuelos = new List<Vuelo>();

        public void CrearVuelo()
        {
            vuelos.Add(this);
            Console.WriteLine("Vuelo creado.");
        }

        public static Vuelo LeerVuelo(string numeroVuelo)
        {
            return vuelos.FirstOrDefault(v => v.NumeroVuelo == numeroVuelo);
        }

        public void ActualizarVuelo()
        {
            var vuelo = LeerVuelo(this.NumeroVuelo);
            if (vuelo != null)
            {
                vuelo.Origen = this.Origen;
                vuelo.Destino = this.Destino;
                vuelo.FechaHoraSalida = this.FechaHoraSalida;
                vuelo.FechaHoraLlegada = this.FechaHoraLlegada;
                vuelo.Pasajeros = this.Pasajeros;
                vuelo.Tripulantes = this.Tripulantes;
                vuelo.Avion = this.Avion;
                vuelo.EstadoVuelo = this.EstadoVuelo;
                Console.WriteLine("Vuelo actualizado.");
            }
            else
            {
                Console.WriteLine("Vuelo no encontrado.");
            }
        }

        public static void EliminarVuelo(string numeroVuelo)
        {
            var vuelo = LeerVuelo(numeroVuelo);
            if (vuelo != null)
            {
                vuelos.Remove(vuelo);
                Console.WriteLine("Vuelo eliminado.");
            }
            else
            {
                Console.WriteLine("Vuelo no encontrado.");
            }
        }
    }
}
