using CreandoApis.Modelo;

namespace CreandoApis.Repositorio
{
    public class ProducMemory: InProductosEnMemory
    {
        private readonly List<Produc> productos = new()
        {
            new Produc { Id = 1, Name = "Madera", Description = "Cuatro tablas de 2 metros madera", Precio = 103500, FechaAlta = DateTime.Now, SKU = "TB01" },
            new Produc { Id = 2, Name = "Cerruche", Description = "cerruche de  1 metro de largo", Precio = 53500, FechaAlta = DateTime.Now, SKU = "CRR02"  },
            new Produc { Id = 3, Name = "Clavos", Description = "Clavos de 2 pulgadas", Precio = 23500, FechaAlta = DateTime.Now, SKU = "CVS03"  },
            new Produc { Id = 4, Name = "Martillo", Description = "Martillo de 15 Cm de acero inoxidable", Precio = 33500, FechaAlta = DateTime.Now, SKU = "MTO04"  }

        };

        public IEnumerable<Produc> DameProductos() {
            return productos;
        }   

        public Produc DameProducto(string SKU)
        {
            return productos.Where(p => p.SKU == SKU).SingleOrDefault();
        }
    }
}
