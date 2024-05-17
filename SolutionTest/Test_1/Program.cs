using CapaDatos;
using CapaNegocio.ServicioDominio;

namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Stellar Home!");
            

            var clientes = new List<Clientes>();
            var serviceClientes = new ClientesServicios();
            clientes = serviceClientes.AgregarClientes();

            var productos = new List<Productos>();
            var serviceProductos = new ProductosServicios();
            productos = serviceProductos.AgregarProductos();

            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.Id);
                Console.WriteLine(cliente.Nombre);
                Console.WriteLine(cliente.Apellido);
                Console.WriteLine(cliente.FechaNacimiento);
                Console.WriteLine("-----------------------");
               
            }

            foreach (var producto in productos)
            {
                Console.WriteLine(producto.Id);
                Console.WriteLine(producto.Nombre);
                Console.WriteLine(producto.Medida);
                Console.WriteLine(producto.Costo);
                Console.WriteLine("-----------------------");
            }
        }
    }
}