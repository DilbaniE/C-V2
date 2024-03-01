using CreandoApis.Modelo;

namespace CreandoApis.Repositorio
{
    public interface InProductosEnMemory
    {
        IEnumerable<Produc> DameProductos();

        Produc DameProducto(string SKU);
    }
}
