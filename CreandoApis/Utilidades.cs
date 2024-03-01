using CreandoApis.DTO;
using CreandoApis.Modelo;

namespace CreandoApis
{
    public static class Utilidades
    {
        public static ProducDTO ConvertirDTO(this Produc p)
        {
            return new ProducDTO
            {
                Name = p.Name,
                Description = p.Description,
                Precio = p.Precio,
                SKU = int.Parse(p.SKU),
            };
        }
    }
}
