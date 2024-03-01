namespace Explication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarroElectrico carroElectrico = new CarroElectrico("Mazda", 2021, "Rojo", "AZB126", "Toyota Brazil", 100, 20000000f);
            Limosina limosina = new Limosina("Ford", 2000, "Blanca", "TDF987", "Nissa Florida", "El techo se puede abrir");
            Moto moto = new Moto("Acate", 2034, "Red", "zsk234", "Acate Medellin");

            carroElectrico.Arrancar();

            carroElectrico.Gasolina();
            carroElectrico.Gasolina(40);
            carroElectrico.Gasolina(70);
            carroElectrico.Descripcion();


            string techoLimo = limosina.TechoLimo();
            Console.WriteLine($"La limo tiene techo solar, {techoLimo}");
            limosina.Arrancar();
            limosina.CantidadPersonas(13);

            moto.Arrancar();
            moto.Detener();

        }
    }
}