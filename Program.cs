using System;

namespace Proyecto_6_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //UPCASTING

            IFigura f1 = new Circulo { Radio = 5 };
            IFigura f2 = new Rectangulo { Base = 4, Altura = 3};
            IFigura f3 = new Triangulo { Base = 10, Altura = 8 };

            IFigura[] figuras = new IFigura[] { f1, f2, f3 };

            foreach (var figura in figuras)
            {
                Console.WriteLine(figura.CalcularArea());
            }

            //DOWNCASTING

            Circulo c = f1 as Circulo;
            Console.WriteLine("Datos del circulo");
            c.DatosCirculo();

            //COMPARACIÓN Y ORDENACIÓN DE OBJETOS

            Producto p1 = new Producto { Codigo = "A1", Precio = 123 };
            Producto p2 = new Producto { Codigo = "A2", Precio = 34 };
            Producto p3 = new Producto { Codigo = "A3", Precio = 99.9m };

            Producto[] productos = new Producto[] { p1, p2, p3 };
            Array.Sort(productos);
            foreach (var prod in productos)
            {
                Console.WriteLine("Código: {0}. Precio: {1}", prod.Codigo, prod.Precio);
            }
        }
    }
}
