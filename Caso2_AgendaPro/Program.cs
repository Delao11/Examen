using System;
using System.Collections.Generic;
using System.Globalization;

namespace Caso2_AgendaPro
{
    class Persona
    {
        public int Id { get; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Persona(int id, string nombre, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
        }

        public override string ToString() // Implementación ToString Persona
        {
            return $"{Id}|{Nombre}|{Telefono}";
        }
    }

    class Cita
    {
        public int PersonaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public override string ToString() // Implementación ToString Cita
        {
            return $"{PersonaId}|{Fecha:yyyy-MM-dd HH:mm}|{Descripcion}";
        }
    }

    class Program
    {
        static List<Persona> personas = new List<Persona>();
        static List<Cita> citas = new List<Cita>();

        static void Main()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n--- AgendaPro ---");
                Console.WriteLine("1) Registrar persona");
                Console.WriteLine("2) Listar personas");
                Console.WriteLine("3) Crear cita");
                Console.WriteLine("4) Listar citas por persona");
                Console.WriteLine("5) Mostrar todas las citas");
                Console.WriteLine("6) Salir");
                Console.Write("Opción: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1": RegistrarPersona(); break;
                    case "2": ListarPersonas(); break;
                    case "3": CrearCita(); break;
                    case "4": ListarCitasPorPersona(); break;
                    case "5": MostrarTodasCitas(); break;
                    case "6": salir = true; break;
                    default: Console.WriteLine("Opción inválida."); break;
                }
            }
        }

        // Métodos vacíos (stubs)
        static void RegistrarPersona() { Console.WriteLine("Falta implementar RegistrarPersona."); }
        static void ListarPersonas() { Console.WriteLine("Falta implementar ListarPersonas."); }
        static void CrearCita() { Console.WriteLine("Falta implementar CrearCita."); }
        static void ListarCitasPorPersona() { Console.WriteLine("Falta implementar ListarCitasPorPersona."); }
        static void MostrarTodasCitas() { Console.WriteLine("Falta implementar MostrarTodasCitas."); }
    }
}