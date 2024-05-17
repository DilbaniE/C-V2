using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.ServicioDominio
{
    public class ProductosServicios
    {
        public List<Productos> AgregarProductos()
        {
            var producto = new List<Productos>();

            producto.Add(new Productos
            {
                Id = 1,
                Nombre = "Letrero led",
                Medida = "40 X 60",
                Costo = 12000
            });

            producto.Add(new Productos
            {
                Id = 2,
                Nombre = "Luz led",
                Medida = "40 X 60",
                Costo = 10000
            });

            producto.Add(new Productos
            {
                Id = 3,
                Nombre = "led Acrilico",
                Medida = "40 X 60",
                Costo = 120000
            });

            producto.Add(new Productos
            {
                Id = 4,
                Nombre = "Conector luz",
                Medida = "40 X 60",
                Costo = 18000
            });

            producto.Add(new Productos
            {
                Id = 5,
                Nombre = "led Agurumi",
                Medida = "40 X 60",
                Costo = 122000
            });

            return producto;
        }


    }
}
