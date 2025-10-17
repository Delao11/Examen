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
    }

    class Program
    {
        static List<Product> productos = new List<Product>();

        static void Main()
        {
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

     
        static void AgregarProducto() { Console.WriteLine("Falta implementar AgregarProducto."); }
        static void ListarProductos() { Console.WriteLine("Falta implementar ListarProductos."); }
        static void BuscarPorCodigo() { Console.WriteLine("Falta implementar BuscarPorCodigo."); }
        static void MostrarAgotados() { Console.WriteLine("Falta implementar MostrarAgotados."); }
    }
}