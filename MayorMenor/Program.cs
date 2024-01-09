using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mayor, menor, num1, num2, num3;
            Console.WriteLine("Ingrese los numeros");
            Console.WriteLine("Numero uno");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero dos");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero tres");
            num3 = Convert.ToInt32(Console.ReadLine());

            mayor = num1;
            menor = num1;

            if(num2 > mayor)
            {
                mayor = num2;
            }
            if(num3 > mayor)
            {
                mayor = num3;
            }
            if(num2 < menor)
            {
                menor = num2;
            }
            if(num3 < menor)
            {
                menor = num3;
            }
            Console.WriteLine("El numero mayor es: {0}", mayor);
            Console.WriteLine("El numero menor es: {0}", menor);
            Console.WriteLine("tecla x salir");
            Console.ReadKey();
        }
    }
}
