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
    public partial class FrmTienda : Form
    {
        bool searchOpen = false;
        int maxWidth = 200;  // ancho final del buscador
        public FrmTienda()
        {
            InitializeComponent();
        }
        public void CargarUC(UserControl uc)
        {
            pnlContenido.Controls.Clear();       // Limpia lo que había
            uc.Dock = DockStyle.Fill;              // Ocupa todo el panel
            pnlContenido.Controls.Add(uc);       // Agrega el nuevo control
        }

        private void FrmTienda_Load(object sender, EventArgs e)
        {
            CargarUC(new PantallaPrincipal());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (searchOpen)
            {
                txtBuscar.Visible = true; // 🔹 aparecer cuando se abre

                if (txtBuscar.Width < maxWidth)
                    txtBuscar.Width += 20;
                else
                {
                    timer1.Stop();
                    txtBuscar.Focus();
                }
            }
            else
            {
                if (txtBuscar.Width > 0)
                    txtBuscar.Width -= 20;
                else
                {
                    txtBuscar.Visible = false; // 🔹 esconder cuando llegue a 0
                    timer1.Stop();
                }
            }
        }

        private void pcLupa_Click(object sender, EventArgs e)
        {
            searchOpen = !searchOpen;
            timer1.Start();
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            CargarUC(new PantallaPrincipal());
        }

        private void lblCategorias_Click(object sender, EventArgs e)
        {
            pnlCategorias.Visible = !pnlCategorias.Visible;
        }

        private void lblPielSeca_Click(object sender, EventArgs e)
        {
            CargarUC(new PielSeca());
        }

        private void lblPielGrasa_Click(object sender, EventArgs e)
        {
            CargarUC(new PielGrasa());
        }

        private void lblPielMixta_Click(object sender, EventArgs e)
        {
            CargarUC(new PielMixta());
        }

        private void pcCarrito_Click(object sender, EventArgs e)
        {
            CargarUC(new UcCarrito());

        }
    }
}
