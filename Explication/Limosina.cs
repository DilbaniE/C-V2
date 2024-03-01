using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explication
{
    internal class Limosina : AutoPadre
    {
       

        private string techoLimo;
        public Limosina(string marca, int anho, string color, string placa, string concesionario, string techoLimo) : base(marca, anho, color, placa, concesionario)
        {
           this.techoLimo = techoLimo;
        }

        public override void Arrancar()
        {
            Console.WriteLine($" la limosina de {Color} arranco con placa {Placa}");
        }

        public override void Detener()
        {
            Console.WriteLine($"la limosina se esta deteniendo su placa es  {Placa}");
        }

        public override void Gasolina()
        {
            Console.WriteLine("la limosina tiene gasolina");
        }

        public void CantidadPersonas(int personas)
        {
            if(personas > 15)
            {
                Console.WriteLine("esta muy llena, maximo 15 personas");
            }
            else
            {
                Console.WriteLine("pueden entrar");
            }
            
        }

        //metoo con retorno
        public string TechoLimo()
        {
            return techoLimo;
        }

        

    }
}
