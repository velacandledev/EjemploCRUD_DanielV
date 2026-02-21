using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class Editar : Form
    {

        Productos pro;

        public Editar(Productos _pro)
        {
            InitializeComponent();
            pro = _pro;
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            lblId.Text = pro.Id.ToString();
            txtNombre.Text = pro.Nombre;
            txtDescripcion.Text = pro.Descripcion;
            txtPrecio.Text = pro.Precio.ToString();
            txtFecha.Value = pro.Fecha;

        }
    }
}
