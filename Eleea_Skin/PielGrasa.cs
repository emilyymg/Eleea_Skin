using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleea_Skin
{
    public partial class PielGrasa : UserControl
    {
        public PielGrasa()
        {
            InitializeComponent();
        }

        private void PielGrasa_Load(object sender, EventArgs e)
        {
            // Lógica de Scroll (sin cambios, es correcta)
            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(0, 1500);
            panel1.AutoSize = false;
        }
        private void AgregarProductoAlCarrito(string nombreProducto, string tipoPiel)
        {
            // 1. OBTENER EL ID del producto del catálogo (tabla Producto)
            int productoID = SqlHelper.ObtenerProductoID(nombreProducto, tipoPiel);

            if (productoID > 0)
            {
                // 2. INSERTAR en la tabla Carrito de la BD
                SqlHelper.InsertarEnCarrito(productoID, 1); // Agrega 1 unidad.

                // 3. Mostrar el mensaje de confirmación
                MessageBox.Show(
                    $"¡Se ha agregado {nombreProducto} a tu carrito (BD)!",
                    "Producto Agregado con Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    $"Error: El producto '{nombreProducto}' no se encontró en el catálogo de la BD o la conexión falló.",
                    "Error de Producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }


        private void btncar1_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("La Roche-Posay Effaclar", "GRASA");

        }

        private void btncar2_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("INF. Crema Facial", "GRASA");

        }

        private void btncar3_Click(object sender, EventArgs e)
        {

            AgregarProductoAlCarrito("CeraVe Limpiador Hidratante", "GRASA");

        }

        private void btncar4_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Avène Cleanance Gel", "GRASA");
        }

        private void btncar5_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("CeraVe Limpiador Espumoso", "GRASA");

        }

        private void btncar6_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("CeraVe Crema Hidratante Pote", "GRASA");

        }

        private void btncar7_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("La Roche-Posay Hydraphase", "GRASA");
        }

        private void btncar8_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Acniben Cleanser", "GRASA");
        }
    }
}
