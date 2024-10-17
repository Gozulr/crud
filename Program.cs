using Crud.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        bool salir = false;
        while (!salir)
        {

            Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Crear Persona");
            Console.WriteLine("2. Leer Persona");
            Console.WriteLine("3. Actualizar Persona");
            Console.WriteLine("4. Eliminar Persona");
            Console.WriteLine("5. Crear Avión");
            Console.WriteLine("6. Leer Avión");
            Console.WriteLine("7. Actualizar Avión");
            Console.WriteLine("8. Eliminar Avión");
            Console.WriteLine("9. Crear Pasajero");
            Console.WriteLine("10. Leer Pasajero");
            Console.WriteLine("11. Actualizar Pasajero");
            Console.WriteLine("12. Eliminar Pasajero");
            Console.WriteLine("13. Crear Tripulante");
            Console.WriteLine("14. Leer Tripulante");
            Console.WriteLine("15. Actualizar Tripulante");
            Console.WriteLine("16. Eliminar Tripulante");
            Console.WriteLine("17. Crear Vuelo");
            Console.WriteLine("18. Leer Vuelo");
            Console.WriteLine("19. Actualizar Vuelo");
            Console.WriteLine("20. Eliminar Vuelo");
            Console.WriteLine("21. Agregar json");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 1: CrearPersona(); break;
                case 2: LeerPersona(); break;
                case 3: ActualizarPersona(); break;
                case 4: EliminarPersona(); break;
                case 5: CrearAvion(); break;
                case 6: LeerAvion(); break;
                case 7: ActualizarAvion(); break;
                case 8: EliminarAvion(); break;
                case 9: CrearPasajero(); break;
                case 10: LeerPasajero(); break;
                case 11: ActualizarPasajero(); break;
                case 12: EliminarPasajero(); break;
                case 13: CrearTripulante(); break;
                case 14: LeerTripulante(); break;
                case 15: ActualizarTripulante(); break;
                case 16: EliminarTripulante(); break;
                case 17: CrearVuelo(); break;
                case 18: LeerVuelo(); break;
                case 19: ActualizarVuelo(); break;
                case 20: EliminarVuelo(); break;
                case 21: PersonaJson(); break;
                case 0: salir = true; break;
                default: Console.WriteLine("Opción no válida. Inténtelo de nuevo."); break;
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void CrearPersona()
    {
        Console.Write("Ingrese el número de identificación: ");
        string identificacion = Console.ReadLine();
        Console.Write("Ingrese el nombre: ");
        string nombres = Console.ReadLine();
        Console.Write("Ingrese el apellido: ");
        string apellidos = Console.ReadLine();

        var persona = new Persona
        {
            NumeroIdentificacion = identificacion,
            Nombres = nombres,
            Apellidos = apellidos
        };
        persona.CrearPersona();
    }

    static void LeerPersona()
    {
        Console.Write("Ingrese el número de identificación: ");
        string identificacion = Console.ReadLine();
        var persona = Persona.LeerPersona(identificacion);
        if (persona != null)
        {
            Console.WriteLine($"Nombre: {persona.Nombres}, Apellidos: {persona.Apellidos}");
        }
        else
        {
            Console.WriteLine("Persona no encontrada.");
        }
    }

    static void ActualizarPersona()
    {
        Console.Write("Ingrese el número de identificación de la persona a actualizar: ");
        string identificacion = Console.ReadLine();
        var persona = Persona.LeerPersona(identificacion);
        if (persona != null)
        {
            Console.Write("Ingrese el nuevo nombre: ");
            persona.Nombres = Console.ReadLine();
            Console.Write("Ingrese el nuevo apellido: ");
            persona.Apellidos = Console.ReadLine();
            persona.ActualizarPersona();
        }
        else
        {
            Console.WriteLine("Persona no encontrada.");
        }
    }

    static void EliminarPersona()
    {
        Console.Write("Ingrese el número de identificación de la persona a eliminar: ");
        string identificacion = Console.ReadLine();
        Persona.EliminarPersona(identificacion);
    }

    static void CrearAvion()
    {
        Console.Write("Ingrese el número de serie del avión: ");
        string numeroSerie = Console.ReadLine();
        Console.Write("Ingrese el modelo del avión: ");
        string modelo = Console.ReadLine();
        Console.Write("Ingrese la cantidad de asientos: ");
        int cantidadAsientos = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el estado del avión: ");
        string estado = Console.ReadLine();

        var avion = new Avion
        {
            NumeroSerie = numeroSerie,
            Modelo = modelo,
            CantidadAsientos = cantidadAsientos,
            Estado = estado
        };
        avion.CrearAvion();
    }

    static void LeerAvion()
    {
        Console.Write("Ingrese el número de serie del avión: ");
        string numeroSerie = Console.ReadLine();
        var avion = Avion.LeerAvion(numeroSerie);
        if (avion != null)
        {
            Console.WriteLine($"Modelo: {avion.Modelo}, Asientos: {avion.CantidadAsientos}, Estado: {avion.Estado}");
        }
        else
        {
            Console.WriteLine("Avión no encontrado.");
        }
    }

    static void ActualizarAvion()
    {
        Console.Write("Ingrese el número de serie del avión a actualizar: ");
        string numeroSerie = Console.ReadLine();
        var avion = Avion.LeerAvion(numeroSerie);
        if (avion != null)
        {
            Console.Write("Ingrese el nuevo estado del avión: ");
            string nuevoEstado = Console.ReadLine();
            avion.Estado = nuevoEstado;
            avion.ActualizarAvion();
        }
        else
        {
            Console.WriteLine("Avión no encontrado.");
        }
    }

    static void EliminarAvion()
    {
        Console.Write("Ingrese el número de serie del avión a eliminar: ");
        string numeroSerie = Console.ReadLine();
        Avion.EliminarAvion(numeroSerie);
    }

    static void CrearPasajero()
    {
        Console.Write("Ingrese el número de identificación del pasajero: ");
        int numeroPasajero = int.Parse(Console.ReadLine());
        var pasajero = new Pasajero
        {
            NumeroPasajero = numeroPasajero
        };
        pasajero.CrearPasajero();
    }

    static void LeerPasajero()
    {
        Console.Write("Ingrese el número de identificación del pasajero: ");
        int numeroPasajero = int.Parse(Console.ReadLine());
        var pasajero = Pasajero.LeerPasajero(numeroPasajero);
        if (pasajero != null)
        {
            Console.WriteLine($"Número de Pasajero: {pasajero.NumeroPasajero}");
        }
        else
        {
            Console.WriteLine("Pasajero no encontrado.");
        }
    }

    static void ActualizarPasajero()
    {
        Console.Write("Ingrese el número de identificación del pasajero a actualizar: ");
        int numeroPasajero = int.Parse(Console.ReadLine());
        var pasajero = Pasajero.LeerPasajero(numeroPasajero);
        if (pasajero != null)
        {
            pasajero.ActualizarPasajero();
        }
        else
        {
            Console.WriteLine("Pasajero no encontrado.");
        }
    }

    static void EliminarPasajero()
    {
        Console.Write("Ingrese el número de identificación del pasajero a eliminar: ");
        int numeroPasajero = int.Parse(Console.ReadLine());
        Pasajero.EliminarPasajero(numeroPasajero);
    }

    static void CrearTripulante()
    {
        Console.Write("Ingrese el número de identificación del tripulante: ");
        int numeroTripulante = int.Parse(Console.ReadLine());
        var tripulante = new Tripulante
        {
            NumeroTripulante = numeroTripulante
        };
        tripulante.CrearTripulante();
    }

    static void LeerTripulante()
    {
        Console.Write("Ingrese el número de identificación del tripulante: ");
        int numeroTripulante = int.Parse(Console.ReadLine());
        var tripulante = Tripulante.LeerTripulante(numeroTripulante);
        if (tripulante != null)
        {
            Console.WriteLine($"Número de Tripulante: {tripulante.NumeroTripulante}");
        }
        else
        {
            Console.WriteLine("Tripulante no encontrado.");
        }
    }

    static void ActualizarTripulante()
    {
        Console.Write("Ingrese el número de identificación del tripulante a actualizar: ");
        int numeroTripulante = int.Parse(Console.ReadLine());
        var tripulante = Tripulante.LeerTripulante(numeroTripulante);
        if (tripulante != null)
        {
            tripulante.ActualizarTripulante();
        }
        else
        {
            Console.WriteLine("Tripulante no encontrado.");
        }
    }

    static void EliminarTripulante()
    {
        Console.Write("Ingrese el número de identificación del tripulante a eliminar: ");
        int numeroTripulante = int.Parse(Console.ReadLine());
        Tripulante.EliminarTripulante(numeroTripulante);
    }

    static void CrearVuelo()
    {
        Console.Write("Ingrese el número del vuelo: ");
        string numeroVuelo = Console.ReadLine();
        var vuelo = new Vuelo
        {
            NumeroVuelo = numeroVuelo
        };
        vuelo.CrearVuelo();
        Console.WriteLine("Vuelo creado.");
    }

    static void LeerVuelo()
    {
        Console.Write("Ingrese el número del vuelo: ");
        string numeroVuelo = Console.ReadLine();
        var vuelo = Vuelo.LeerVuelo(numeroVuelo);
        if (vuelo != null)
        {
            Console.WriteLine($"Número de Vuelo: {vuelo.NumeroVuelo}");
        }
        else
        {
            Console.WriteLine("Vuelo no encontrado.");
        }
    }

    static void ActualizarVuelo()
    {
        Console.Write("Ingrese el número del vuelo a actualizar: ");
        string numeroVuelo = Console.ReadLine();
        var vuelo = Vuelo.LeerVuelo(numeroVuelo);
        if (vuelo != null)
        {
            vuelo.ActualizarVuelo();
        }
        else
        {
            Console.WriteLine("Vuelo no encontrado.");
        }
    }

    static void EliminarVuelo()
    {
        Console.Write("Ingrese el número del vuelo a eliminar: ");
        String numeroVuelo = Console.ReadLine();
        Vuelo.EliminarVuelo(numeroVuelo);
    }


    static void PersonaJson()
    {
        string json = "[{ \"NumeroIdentificacion\": 1, \"Nombres\": \"Juan\", \"Apellidos\": \"Casa\" }, " +
            "{ \"NumeroIdentificacion\": 2, \"Nombres\": \"Pedro\", \"Apellidos\": \"G\" }, " +
            "{ \"NumeroIdentificacion\": 3, \"Nombres\": \"A\", \"Apellidos\": \"J\" }, " +
            "{ \"NumeroIdentificacion\": 4, \"Nombres\": \"B\", \"Apellidos\": \"I\" }, " +
            "{ \"NumeroIdentificacion\": 5, \"Nombres\": \"C\", \"Apellidos\": \"A\" }, " +
            "{ \"NumeroIdentificacion\": 6, \"Nombres\": \"D\", \"Apellidos\": \"B\" }, " +
            "{ \"NumeroIdentificacion\": 7, \"Nombres\": \"E\", \"Apellidos\": \"C\" }, " +
            "{ \"NumeroIdentificacion\": 8, \"Nombres\": \"F\", \"Apellidos\": \"D\" }]";
        var Persona = JsonConvert.DeserializeObject<List<Persona>>(json);

        foreach (Persona persona in Persona)
        {
            persona.CrearPersona();
        }

    }
}
