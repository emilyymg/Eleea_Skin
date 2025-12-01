using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleea_Skin
{
    internal class Carrito
    {
        public static List<ItemCarrito> Items = new List<ItemCarrito>();

        public static void AgregarProducto(Productos p)
        {
            // Verificar si ya existe en el carrito
            var existente = Items.FirstOrDefault(i => i.Producto.Id == p.Id);

            if (existente == null)
            {
                Items.Add(new ItemCarrito
                {
                    Producto = p,
                    Cantidad = 1
                });
            }
            else
            {
                existente.Cantidad++;
            }
        }

        public static void EliminarProducto(int idProducto)
        {
            var item = Items.FirstOrDefault(i => i.Producto.Id == idProducto);
            if (item != null)
                Items.Remove(item);
        }

        public static decimal Total()
        {
            return Items.Sum(i => i.Subtotal);
        }
    }
}
