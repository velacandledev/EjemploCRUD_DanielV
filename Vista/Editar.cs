using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestSharp;

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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.Id = int.Parse(lblId.Text);
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio = Convert.ToDouble(txtPrecio.Text);
            producto.Fecha = txtFecha.Value;

            RestClient cliente = new RestClient();
            RestRequest peticion = new RestRequest("https://67db76a51fd9e43fe4749f9c.mockapi.io/api/v1/Productos/"+producto.Id,Method.Put);
            peticion.AddBody(producto);
            var res = await cliente.ExecutePutAsync(peticion);

            MessageBox.Show("Se actualizó el registro");
        }
    }
}
