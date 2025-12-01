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
    public partial class PantallaPrincipal : UserControl
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciarS_Click(object sender, EventArgs e)
        {
            FrmTienda principal = (FrmTienda)this.FindForm();

            principal.CargarUC(new IniciarSesion());
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmTienda principal = (FrmTienda)this.FindForm();

            principal.CargarUC(new Registro());
        }
    }
}
