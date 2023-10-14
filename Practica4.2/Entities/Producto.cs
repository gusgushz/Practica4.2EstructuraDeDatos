using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4._2.Entities
{
    internal class Producto
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        Random ran = new();
        public Producto()
        {
            Clave = ran.Next(1, 100);
            Nombre = "Producto " + Clave.ToString();
            Precio = ran.Next(15, 100);
        }
    }
}
/*
Práctica 4. Eliminar y ordenar productos Crea una aplicación que permita agregar productos a una lista, 
los productos deben de tener un precio, la aplicación debe de eliminar los productos de acuerdo a una clave 
de producto solicitada al usuario, además de eso la aplicación debe de mostrar los elementos ordenados por 
nombres y mostrar el costo total de compra (crea una lista para almacenar los datos)
 */
