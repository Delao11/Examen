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

        public override string ToString()
        {
            return $"{Id}|{Nombre}|{Telefono}";
        }
    }

    class Cita
    {
        public int PersonaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
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

        static void RegistrarPersona()
        {
            Console.Write("Id: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Id inválido.");
                return;
            }
            if (personas.Exists(p => p.Id == id))
            {
                Console.WriteLine("Id duplicado.");
                return;
            }

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();
            personas.Add(new Persona(id, nombre, telefono));
            Console.WriteLine("Persona registrada.");
        }

        static void ListarPersonas()
        {
            if (personas.Count == 0) { Console.WriteLine("No hay personas."); return; }
            foreach (var p in personas) Console.WriteLine(p.ToString());
        }

        static void CrearCita() // Implementación CrearCita
        {
            Console.Write("PersonaId: ");
            if (!int.TryParse(Console.ReadLine(), out int id)) { Console.WriteLine("Id inválido."); return; }

            var persona = personas.Find(p => p.Id == id);
            if (persona == null) { Console.WriteLine("No existe persona."); return; }

            Console.Write("Fecha (yyyy-MM-dd HH:mm): ");
            if (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
            {
                Console.WriteLine("Formato de fecha incorrecto.");
                return;
            }

            Console.Write("Descripción: ");
            string desc = Console.ReadLine();
            citas.Add(new Cita { PersonaId = id, Fecha = fecha, Descripcion = desc });
            Console.WriteLine("Cita creada.");
        }

        static void ListarCitasPorPersona() // Implementación ListarCitasPorPersona
        {
            Console.Write("PersonaId: ");
            if (!int.TryParse(Console.ReadLine(), out int id)) { Console.WriteLine("Id inválido."); return; }
            var lista = citas.FindAll(c => c.PersonaId == id);
            if (lista.Count == 0) { Console.WriteLine("No hay citas para ese Id."); return; }
            foreach (var c in lista) Console.WriteLine(c.ToString());
        }

        static void MostrarTodasCitas() // Implementación MostrarTodasCitas
        {
            if (citas.Count == 0) { Console.WriteLine("No hay citas."); return; }
            foreach (var c in citas) Console.WriteLine(c.ToString());
        }
    }
}