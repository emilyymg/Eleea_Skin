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
    public partial class PielSeca : UserControl
    {
        public PielSeca()
        {
            InitializeComponent();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btncar1_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("POND'S Clarant B3 Crema", "SECA");
        }

        private void btncar2_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("CeraVe Limpiador Hidratante Piel Seca", "SECA");
        }

        private void btncar3_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Eucerin PH5 Skin-Protection", "SECA");
        }

        private void btncar4_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("CeraVe Healing Ointment", "SECA");
        }

        private void btncar5_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Bio-Oil Gel para Piel Seca", "SECA");

        }

        private void btncar6_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Eucerin Loción Piel Seca", "SECA");
        }

        private void btncar7_Click(object sender, EventArgs e)
        {

            AgregarProductoAlCarrito("Bioderma Atoderm Gel", "SECA");
        }

        private void btncar8_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Dermatologist Solutions Piel Seca", "SECA");


        }
    }
}
