using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4._2.Entities
{
    internal class Tienda
    {
        public List<Producto> Productos = new();
        public List<Producto> ProductosOrdenados = new();
        public void AgregarProducto()
        {
            Productos.Add(new Producto());
        }
        public void EliminarProducto(int clave)
        {
            Producto productoEncontrado = Productos.Find(x => x.Clave == clave)!;
            if (productoEncontrado == null) { }
            //No hace nada
            else
            {
                Productos.Remove(productoEncontrado);
            }
        }
        public void Ordenar()
        {
            ProductosOrdenados = Productos.OrderBy(x => x.Clave).ToList();
        }
        public int CalcularCostoTotal()
        {
            int Total = 0;
            foreach (Producto producto in Productos)
            {
                Total += producto.Precio;
            }
            return Total;
        }
    }
}
