using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Proyecto_6_Polimorfismo
{
    public class Producto : IComparable<Producto>  //Con esto se crea una comparación entre productos
    {
        public string Codigo { get; set; }
        public decimal Precio { get; set; }

        public int CompareTo(Producto otro)
        {
            // > 0 es mayor
            // == 0 es igual
            // < 0 es menor

            if (this.Precio > otro.Precio) return 1;
            if (this.Precio == otro.Precio) return 0;

            return -1;
        }
    }
}
