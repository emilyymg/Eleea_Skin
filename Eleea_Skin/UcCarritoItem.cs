using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleea_Skin
{
    
    public partial class UcCarritoItem : UserControl
    {
        private CarritoItem _item; // producto + cantidad

        public UcCarritoItem(ItemCarrito item)
        {
            InitializeComponent();
        }

        public UcCarritoItem(CarritoItem item) : this() // llama al constructor sin parámetros primero
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _item = item;
            CargarDatos();

            // Asegúrate de que el botón tenga el evento asignado (si no lo hiciste desde el diseñador)
            pbEliminar.Click -= pbEliminar_Click; // evitar duplicados
            pbEliminar.Click += pbEliminar_Click;
        }

        private void CargarDatos()
        {
            if (_item == null) return; // protección

            // Imagen
            if (_item.Producto?.Imagen != null)
            {
                using (MemoryStream ms = new MemoryStream(_item.Producto.Imagen))
                {
                    pbImagen.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbImagen.Image = null;
            }

            // Textos
            lblNombre.Text = _item.Producto?.Nombre ?? "Sin nombre";
            lblPrecio.Text = "Precio: $" + (_item.Producto?.Precio ?? 0m).ToString("0.00");
            lblCantidad.Text = "Cantidad: " + _item.Cantidad;
            lblSubTotal.Text = "Subtotal: $" + ((_item.Producto?.Precio ?? 0m) * _item.Cantidad).ToString("0.00");

            // Guardamos el ID en Tag para eliminarlo con facilidad
            pbEliminar.Tag = _item.Producto?.Id ?? 0;
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)pbEliminar.Tag;

            // quitar del carrito global
            Carrito.EliminarProducto(id);

            // refrescar el carrito
            // buscar UcCarrito (el contenedor)
            var parent = this.Parent;
            while (parent != null && !(parent is UcCarrito))
                parent = parent.Parent;

            if (parent is UcCarrito carrito)
                carrito.CargarCarrito(); // recargar vista
        }
    }
    public class CarritoItem
    {
        public Productos Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
