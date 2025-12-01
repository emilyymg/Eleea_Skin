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
    public partial class UcCarrito : UserControl
    {
        public UcCarrito()
        {
            InitializeComponent();
        }

        private void UcCarrito_Load(object sender, EventArgs e)
        {
            CargarCarrito();
        }
        public void CargarCarrito()
        {
            flpCarrito.Controls.Clear();

            foreach (var item in Carrito.Items)
            {
                UcCarritoItem tarjeta = new UcCarritoItem(item);
                flpCarrito.Controls.Add(tarjeta);
            }

            lblTotal.Text = "$" + Carrito.Total().ToString("0.00");
        }

        
    }
}
