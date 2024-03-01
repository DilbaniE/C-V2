namespace CreandoApis.Modelo
{
    public class Produc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Precio { get; set; }

        public DateTime FechaAlta { get; set; }


        //Codigo alfanumerico para identificar un producto referencia para almacenes
        public string SKU { get; init; }

    }
}
