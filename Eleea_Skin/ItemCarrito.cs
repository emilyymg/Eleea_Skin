using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleea_Skin
{
        public class ItemCarrito
        {
            public Productos Producto { get; set; }
            public int Cantidad { get; set; }

            public decimal Subtotal
            {
                get { return Cantidad * Producto.Precio; }
            }
        }
}
