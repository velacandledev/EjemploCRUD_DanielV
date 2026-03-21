using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class Nuevo : Form
    {
        ProductosController controlador = new ProductosController();

        public Nuevo()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Productos pro = new Productos();

            pro.Nombre = txtNombre.Text;
            pro.Descripcion = txtDescripcion.Text;
            pro.Precio = Convert.ToDouble(txtPrecio.Text);
            pro.Fecha = txtFecha.Value;

            string mensaje = await controlador.nuevoProducto(pro);

            if(mensaje == "Producto creado") {
                MessageBox.Show(mensaje);
                this.DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show(mensaje);
            }
        }
    }
}
