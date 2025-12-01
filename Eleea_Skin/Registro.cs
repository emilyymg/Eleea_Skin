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
    public partial class Registro : UserControl
    {
        public Registro()
        {
            InitializeComponent();
            txtNombre.Text = "Escribe tu nombre...";
            txtNombre.ForeColor = Color.Gray;

            txtApellido.Text = "Escribe tu apellido...";
            txtApellido.ForeColor = Color.Gray;

            txtTelefono.Text = "Escribe tu teléfono...";
            txtTelefono.ForeColor = Color.Gray;

            txtCorreo.Text = "Escribe tu correo...";
            txtCorreo.ForeColor = Color.Gray;

            txtContra.Text = "Escribe tu contraseña...";
            txtContra.ForeColor = Color.Gray;
        }
        SqlConnection conexion = new SqlConnection("Data Source =.; Initial Catalog = EleaaSkin; Integrated Security = True");
        void LimpiarCajas()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtContra.Clear();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            conexion.Open();

            // Instrucción SQL para insertar datos
            SqlCommand altas = new SqlCommand(
                "INSERT INTO Usuarios (Nombre, Apellido, Telefono, Correo, Contrasena) " +
                "VALUES (@Nombre, @Apellido, @Telefono, @Correo, @Contrasena)",
                conexion
            );

            altas.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            altas.Parameters.AddWithValue("@Apellido", txtApellido.Text);
            altas.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            altas.Parameters.AddWithValue("@Correo", txtCorreo.Text);
            altas.Parameters.AddWithValue("@Contrasena", txtContra.Text);

            altas.ExecuteNonQuery();

            MessageBox.Show("Usuario registrado con éxito");
            Registro frm = new Registro();
            frm.Show();
            this.Hide();

            LimpiarCajas();

            conexion.Close();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Escribe tu nombre...")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Escribe tu nombre...";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Escribe tu apellido...")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.Text = "Escribe tu apellido...";
                txtApellido.ForeColor = Color.Gray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Escribe tu teléfono...")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                txtTelefono.Text = "Escribe tu teléfono...";
                txtTelefono.ForeColor = Color.Gray;
            }
        }

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
                txtContra.PasswordChar = '•'; // Para ocultar texto
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContra.Text))
            {
                txtContra.PasswordChar = '\0'; // Mostrar texto normal
                txtContra.Text = "Escribe tu contraseña...";
                txtContra.ForeColor = Color.Gray;
            }
        }
    }
}
