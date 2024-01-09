using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHerencia
{
    internal class Triangulo
    {
        public void Area(int Base, int Altura)
        {
            Console.WriteLine("El area del triangulo es: " + (Base * Altura)/2);
        }
    }
}
