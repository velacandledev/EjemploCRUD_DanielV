using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Newtonsoft.Json;

namespace Modelo
{
    public class Productos

    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public double Precio{ get; set; }
        public DateTime Fecha { get; set; }

        public static async Task<List<Productos>> obtenerProductos()
        {
            RestClient cliente = new RestClient();
            RestRequest peticion = new RestRequest("https://67db76a51fd9e43fe4749f9c.mockapi.io/api/v1/Productos", Method.Get);
            var res = await cliente.ExecuteGetAsync(peticion);

            List<Productos> lista = (List<Productos>)JsonConvert.DeserializeObject(res.Content, typeof(List<Productos>));

            return lista;

            // dgvProductos.DataSource = lista;
            // listaProductos = lista;
        }
    }
}
