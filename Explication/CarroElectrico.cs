using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explication
{
    public class CarroElectrico : AutoPadre
    {
        private int bateriaCarro;
        private float valorCarro;

        public CarroElectrico(string marca, int anho, string color, string placa, string concesionario, int bateriaCarro, float valorCarro ) : base(marca, anho, color,placa,concesionario)
        {
            this.bateriaCarro = bateriaCarro;
            this.valorCarro = valorCarro;
        }

        public int BateriaCarro
        {
            get { return bateriaCarro; }
            set { bateriaCarro = value;}
        }

        public float ValorCarro
        {
            get { return valorCarro;}
            set { valorCarro = value;}
        }

        // usando el metodo abstracto 
        public override void Arrancar()
        {
            Console.WriteLine($"el carro electrico arranco de la marca {Marca}");
        }

        public override void Detener()
        {
            Console.WriteLine($"el auto se detuvo {Marca}");
        }

        //metodo de sobrecarga 
        public override void Gasolina()
        {
            Console.WriteLine("el carro no usa gasolina");
        }

        public void Gasolina(int carga)
        {
            if (carga == 100)
            {
                Console.WriteLine("La batería está completamente cargada al " + carga + "%");
            }
            else if (carga >= 60)
            {
                Console.WriteLine("La batería está al " + carga + "%. Todavía tiene carga suficiente.");
            }
            else if (carga >= 40)
            {
                Console.WriteLine("La batería está al " + carga + "%. Se encuentra en la mitad de la carga.");
            }
            else
            {
                Console.WriteLine("La batería está al " + carga + "%. Se apagará en 1 hora.");
            }
        }

        // metodo propio 
        public void Descripcion()
        {
            Console.WriteLine($"este carro tiene las siguiente cripcion: {Marca}, { Anho}, {Color}, {Placa}, {Concesionario}, {BateriaCarro} +'%' +, {ValorCarro} ");
        }

    }
}
