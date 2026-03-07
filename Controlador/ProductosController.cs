using System;
using System.Collections.Generic;
using System.Text;
using Modelo;

namespace Controlador
{
    public class ProductosController
    {
        public Task<List<Productos>> listarProductos()
        {
            return Productos.obtenerProductos();
        }
    }
}
