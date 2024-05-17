using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.ServicioDominio
{
    public class ClientesServicios
    {
        public List<Clientes> AgregarClientes()
        {
            var clientes = new List<Clientes>();

            clientes.Add(new Clientes
            {
                Id = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                FechaNacimiento = DateTime.Now
            });

            clientes.Add(new Clientes
            {
                Id = 2,
                Nombre = "Rosio",
                Apellido = "Durca",
                FechaNacimiento = DateTime.Now
            });

            clientes.Add(new Clientes
            {
                Id = 3,
                Nombre = "Carlos",
                Apellido = "Kano",
                FechaNacimiento = DateTime.Now
            });

            clientes.Add(new Clientes
            {
                Id = 4,
                Nombre = "Flor",
                Apellido = "Canela",
                FechaNacimiento = DateTime.Now
            });

            clientes.Add(new Clientes
            {
                Id = 5,
                Nombre = "Julio",
                Apellido = "Bolivar",
                FechaNacimiento = DateTime.Now
            });


            return clientes;
        }
       
    }
}
