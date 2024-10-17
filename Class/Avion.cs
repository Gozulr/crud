using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Class
{
    public class Avion
    {
        public string NumeroSerie { get; set; }
        public string Modelo { get; set; }
        public int CantidadAsientos { get; set; }
        public string Estado { get; set; }

        private static List<Avion> aviones = new List<Avion>();

        public void CrearAvion()
        {
            aviones.Add(this);
            Console.WriteLine("Avión creado.");
        }

        public static Avion LeerAvion(string numeroSerie)
        {
            return aviones.FirstOrDefault(a => a.NumeroSerie == numeroSerie);
        }

        public void ActualizarAvion()
        {
            var avion = LeerAvion(this.NumeroSerie);
            if (avion != null)
            {
                avion.Modelo = this.Modelo;
                avion.CantidadAsientos = this.CantidadAsientos;
                avion.Estado = this.Estado;
                Console.WriteLine("Avión actualizado.");
            }
            else
            {
                Console.WriteLine("Avión no encontrado.");
            }
        }

        public static void EliminarAvion(string numeroSerie)
        {
            var avion = LeerAvion(numeroSerie);
            if (avion != null)
            {
                aviones.Remove(avion);
                Console.WriteLine("Avión eliminado.");
            }
            else
            {
                Console.WriteLine("Avión no encontrado.");
            }
        }
    }

}
