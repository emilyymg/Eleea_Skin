namespace Eleea_Skin
{
    partial class FrmTienda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pnlCategorias = new System.Windows.Forms.Panel();
            this.lblPielMixta = new System.Windows.Forms.Label();
            this.lblPielGrasa = new System.Windows.Forms.Label();
            this.lblPielSeca = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblTienda = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcPerfil = new System.Windows.Forms.PictureBox();
            this.pcLupa = new System.Windows.Forms.PictureBox();
            this.pcCarrito = new System.Windows.Forms.PictureBox();
            this.pnlContenedor.SuspendLayout();
            this.pnlCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.txtBuscar);
            this.pnlContenedor.Controls.Add(this.pnlCategorias);
            this.pnlContenedor.Controls.Add(this.pcPerfil);
            this.pnlContenedor.Controls.Add(this.pcLupa);
            this.pnlContenedor.Controls.Add(this.pcCarrito);
            this.pnlContenedor.Controls.Add(this.lblCategorias);
            this.pnlContenedor.Controls.Add(this.lblTienda);
            this.pnlContenedor.Controls.Add(this.lblInicio);
            this.pnlContenedor.Controls.Add(this.label1);
            this.pnlContenedor.Location = new System.Drawing.Point(3, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1535, 142);
            this.pnlContenedor.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(1227, 83);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(275, 34);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.Visible = false;
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.Controls.Add(this.lblPielMixta);
            this.pnlCategorias.Controls.Add(this.lblPielGrasa);
            this.pnlCategorias.Controls.Add(this.lblPielSeca);
            this.pnlCategorias.Location = new System.Drawing.Point(411, 29);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(127, 88);
            this.pnlCategorias.TabIndex = 15;
            this.pnlCategorias.Visible = false;
            // 
            // lblPielMixta
            // 
            this.lblPielMixta.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPielMixta.Location = new System.Drawing.Point(3, 60);
            this.lblPielMixta.Name = "lblPielMixta";
            this.lblPielMixta.Size = new System.Drawing.Size(121, 28);
            this.lblPielMixta.TabIndex = 13;
            this.lblPielMixta.Text = "PIEL MIXTA";
            this.lblPielMixta.Click += new System.EventHandler(this.lblPielMixta_Click);
            // 
            // lblPielGrasa
            // 
            this.lblPielGrasa.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPielGrasa.Location = new System.Drawing.Point(3, 33);
            this.lblPielGrasa.Name = "lblPielGrasa";
            this.lblPielGrasa.Size = new System.Drawing.Size(121, 27);
            this.lblPielGrasa.TabIndex = 12;
            this.lblPielGrasa.Text = "PIEL GRASA";
            this.lblPielGrasa.Click += new System.EventHandler(this.lblPielGrasa_Click);
            // 
            // lblPielSeca
            // 
            this.lblPielSeca.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPielSeca.Location = new System.Drawing.Point(3, 5);
            this.lblPielSeca.Name = "lblPielSeca";
            this.lblPielSeca.Size = new System.Drawing.Size(104, 28);
            this.lblPielSeca.TabIndex = 11;
            this.lblPielSeca.Text = "PIEL SECA";
            this.lblPielSeca.Click += new System.EventHandler(this.lblPielSeca_Click);
            // 
            // lblCategorias
            // 
            this.lblCategorias.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(304, 52);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(115, 28);
            this.lblCategorias.TabIndex = 11;
            this.lblCategorias.Text = "CATEGORIAS";
            this.lblCategorias.Click += new System.EventHandler(this.lblCategorias_Click);
            // 
            // lblTienda
            // 
            this.lblTienda.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienda.Location = new System.Drawing.Point(182, 52);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(80, 28);
            this.lblTienda.TabIndex = 10;
            this.lblTienda.Text = "TIENDA";
            // 
            // lblInicio
            // 
            this.lblInicio.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(78, 52);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(80, 28);
            this.lblInicio.TabIndex = 8;
            this.lblInicio.Text = "INICIO";
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Classy Vogue", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "ELEEA SKIN";
            // 
            // pnlContenido
            // 
            this.pnlContenido.Location = new System.Drawing.Point(3, 139);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1535, 756);
            this.pnlContenido.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcPerfil
            // 
            this.pcPerfil.Image = global::Eleea_Skin.Properties.Resources.usuario;
            this.pcPerfil.Location = new System.Drawing.Point(1405, 43);
            this.pcPerfil.Name = "pcPerfil";
            this.pcPerfil.Size = new System.Drawing.Size(39, 39);
            this.pcPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPerfil.TabIndex = 14;
            this.pcPerfil.TabStop = false;
            // 
            // pcLupa
            // 
            this.pcLupa.Image = global::Eleea_Skin.Properties.Resources.lupa;
            this.pcLupa.Location = new System.Drawing.Point(1257, 41);
            this.pcLupa.Name = "pcLupa";
            this.pcLupa.Size = new System.Drawing.Size(39, 39);
            this.pcLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLupa.TabIndex = 13;
            this.pcLupa.TabStop = false;
            this.pcLupa.Click += new System.EventHandler(this.pcLupa_Click);
            // 
            // pcCarrito
            // 
            this.pcCarrito.Image = global::Eleea_Skin.Properties.Resources.carrito_de_compras;
            this.pcCarrito.Location = new System.Drawing.Point(1326, 43);
            this.pcCarrito.Name = "pcCarrito";
            this.pcCarrito.Size = new System.Drawing.Size(39, 39);
            this.pcCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCarrito.TabIndex = 12;
            this.pcCarrito.TabStop = false;
            this.pcCarrito.Click += new System.EventHandler(this.pcCarrito_Click);
            // 
            // FrmTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 897);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlContenedor);
            this.Name = "FrmTienda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmTienda_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCarrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel pnlCategorias;
        private System.Windows.Forms.Label lblPielMixta;
        private System.Windows.Forms.Label lblPielGrasa;
        private System.Windows.Forms.Label lblPielSeca;
        private System.Windows.Forms.PictureBox pcPerfil;
        private System.Windows.Forms.PictureBox pcLupa;
        private System.Windows.Forms.PictureBox pcCarrito;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

