// See https://aka.ms/new-console-template for more information

using System;

namespace Descuento_asignado_de_las_personas
{
    class Producto
    {
        static void Main(string[] args)
        {
            // en esta parte se debe colocar los datos de la categoria
            Console.WriteLine("*** CATEGORIA ***");
            Console.WriteLine("ingrese la categoria");
            int categoria = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*** PRODUCTO ***");
            Console.WriteLine("ingrese el producto");
            int producto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*** PRECIO ***");
            Console.WriteLine("Ingrese el precio del producto");
            int precio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*** TAMAÑO DEL PRODUCTO ***");
            Console.WriteLine("Ingrese el tamaño del producto");
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Medio");
            Console.WriteLine("3. Grande");
            string tamaño = Console.ReadLine();

            Console.WriteLine("*** PRECIO DEL TAMAÑO");
            Console.WriteLine("Ingrese el precio segun tamaño");
            Console.WriteLine("1. Tamaño Normal");
            Console.WriteLine("2. 25% mas de normal");
            Console.WriteLine("3. 30% mas del medio");
            string preciodeltamaño = Console.ReadLine();

            string total;
            total = precio + tamaño + preciodeltamaño;
            Console.WriteLine($"Total del producto: , {total}");
        }
    }
}
