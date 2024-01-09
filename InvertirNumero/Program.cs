using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertirNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Invirtiendo un numero de dos cifras 
            int num, div, residuo, numAuxiliar;
            string linea;
            Console.WriteLine("ingrese un numero de dos cifras");
            linea = Console.ReadLine();
            num = Convert.ToInt32(linea);
            div = num / 10;
            residuo = num % 10;
            numAuxiliar = (residuo * 10) + div;
            Console.WriteLine("El numero invertido es: {0}", numAuxiliar);*/



            /*
            //invertir numero de tres cifras
            int num, div, div2, residuo, numAuxiliar;
            string linea;
            Console.WriteLine("ingrese un numero de tres cifras");
            linea = Console.ReadLine();
            num = Convert.ToInt32(linea);
            div = num / 100;
            num = num % 100;
            div2 = num / 10;
            residuo = num % 10;
            numAuxiliar = (residuo * 100) + (div2 * 10) + div;
            Console.WriteLine("El numero invertido es: {0}", numAuxiliar); */

            Console.ReadKey();

        }
    }
}
