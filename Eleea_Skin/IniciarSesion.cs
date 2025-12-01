using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleea_Skin
{
    public partial class IniciarSesion : UserControl
    {
        public IniciarSesion()
        {
            InitializeComponent();
            txtCorreo.Text = "Escribe tu correo...";
            txtCorreo.ForeColor = Color.Gray;
            txtContra.Text = "Escribe tu contraseña...";
            txtContra.ForeColor = Color.Gray;
        }
        //Realizar la conexion a la base de datos
        SqlConnection conexion = new SqlConnection("Data Source =.; Initial Catalog = EleaaSkin; Integrated Security = True");

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Escribe tu correo...")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                txtCorreo.Text = "Escribe tu correo...";
                txtCorreo.ForeColor = Color.Gray;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Escribe tu contraseña...")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContra.Text))
            {
                txtContra.Text = "Escribe tu contraseña...";
                txtContra.ForeColor = Color.Gray;
            }
        }

        private void btnIniciarS_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Correo = @Correo AND Contrasena = @Contrasena";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                comando.Parameters.AddWithValue("@Contrasena", txtContra.Text);

                int count = (int)comando.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Bienvenido!");
                    IniciarSesion frm = new IniciarSesion();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
