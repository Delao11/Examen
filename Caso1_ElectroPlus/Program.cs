using System;
using System.Collections.Generic;
using System.Globalization;

namespace Caso1_ElectroPlus
{
    class Product
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public override string ToString() // Implementación ToString
        {
            return $"{Codigo}|{Nombre}|{Precio.ToString("F2", CultureInfo.InvariantCulture)}|{Cantidad}";
        }
    }

    class Program
    {
        static List<Product> productos = new List<Product>();

        static void Main()
        {
            // ... (Menú principal igual)
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n--- ElectroPlus - Inventario ---");
                Console.WriteLine("1) Agregar producto");
                Console.WriteLine("2) Listar productos");
                Console.WriteLine("3) Buscar por código");
                Console.WriteLine("4) Mostrar productos agotados");
                Console.WriteLine("5) Salir");
                Console.Write("Seleccione opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": AgregarProducto(); break;
                    case "2": ListarProductos(); break;
                    case "3": BuscarPorCodigo(); break;
                    case "4": MostrarAgotados(); break;
                    case "5": salir = true; break;
                    default: Console.WriteLine("Opción inválida."); break;
                }
            }
        }

        static void AgregarProducto() // Implementación AgregarProducto
        {
            Console.Write("Código: ");
            string codigo = Console.ReadLine();
            if (productos.Exists(p => p.Codigo == codigo))
            {
                Console.WriteLine("Ese código ya existe.");
                return;
            }

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Precio: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal precio))
            {
                Console.WriteLine("Precio inválido.");
                return;
            }

            Console.Write("Cantidad: ");
            if (!int.TryParse(Console.ReadLine(), out int cantidad))
            {
                Console.WriteLine("Cantidad inválida.");
                return;
            }

            productos.Add(new Product { Codigo = codigo, Nombre = nombre, Precio = precio, Cantidad = cantidad });
            Console.WriteLine("Producto agregado correctamente.");
        }

        static void ListarProductos() // Implementación ListarProductos
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos registrados.");
                return;
            }
            foreach (var p in productos)
                Console.WriteLine(p.ToString());
        }

        // Métodos stub restantes
        static void BuscarPorCodigo() { Console.WriteLine("Falta implementar BuscarPorCodigo."); }
        static void MostrarAgotados() { Console.WriteLine("Falta implementar MostrarAgotados."); }
    }
}