using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explication
{
    internal class Moto : AutoPadre
    {
        public Moto(string marca, int anho, string color, string placa, string concesionario) : base(marca, anho, color, placa, concesionario)
        {

        }

        public override void Arrancar()
        {
            Console.WriteLine($"La moto se detuvo {Marca}");
        }

        public override void Detener()
        {
            Console.WriteLine($"la moto de marca {Marca}");
        }

        public override void Gasolina()
        {
            Console.WriteLine("La moto tiene gasolina");
        }
    }
}
