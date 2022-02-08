using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        Contexto _contexto;
        public List<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();
        }

        public List<Producto> ObtenerProductos()
        {
            ListadeProductos = _contexto.Productos.ToList();

            return ListadeProductos;

            //var producto1 = new Producto();
            //producto1.Id = 1;
            //producto1.Descripcion = "Pizza 6 Quesos";
            //producto1.Precio = 200;

            //var producto2 = new Producto();
            //producto2.Id = 2;
            //producto2.Descripcion = "Pizza 4 Estaciones";
            //producto2.Precio = 250;

            //var producto3 = new Producto();
            //producto3.Id = 3;
            //producto3.Descripcion = "Pizza Jamón y Queso";
            //producto3.Precio = 180;

            //var listadeProductos = new List<Producto>();
            //listadeProductos.Add(producto1);
            //listadeProductos.Add(producto2);
            //listadeProductos.Add(producto3);

            //return listadeProductos;

        }
    }
}
