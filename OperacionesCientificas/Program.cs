using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCientificas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* float num;
             float option;
             Console.WriteLine("Ingrese nun numero");
             num = Convert.ToSingle(Console.ReadLine());
             result = Math.Abs(num);
             Console.WriteLine("Valor absoluto: {0}", result);
             Console.WriteLine("Potencia " + Math.Pow(num,3));
             Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num));
             Console.WriteLine("Seno " + Math.Sin(num * Math.PI / 180));
             Console.WriteLine("Coseno " + Math.Cos(num * Math.PI / 180));
             Console.WriteLine("Numero maximo " + Math.Max(num, 50));
             Console.WriteLine("Numero min " + Math.Min(num, 50));
             Console.WriteLine("Parte entera " + Math.Truncate(num));
             Console.WriteLine("Redondeando " + Math.Round(num));
             Console.WriteLine("Pulse una tecla para salir");*/


            float num;
            float result;
            string respta;
            int option;
            Console.WriteLine("Ingrese un numero");
            num = Convert.ToSingle(Console.ReadLine());

            do
            {
                Console.WriteLine("1.Valor absoluto");
                Console.WriteLine("2.Potencia");
                Console.WriteLine("3. Raiz cuadrada");
                Console.WriteLine("4. seno");
                Console.WriteLine("5. Coseno");
                Console.WriteLine("6. Numero maximo");
                Console.WriteLine("7. Numero minimo");
                Console.WriteLine("8. Parte entera");
                Console.WriteLine("9. Redondeo");

                Console.WriteLine("Escoge una option");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        result = Math.Abs(num);
                        Console.WriteLine("Valor absoluto {0}", result);
                        break;

                    case 2:
                        Console.WriteLine("Potencia " + Math.Pow(num, 3));

                        break;
                    case 3:
                        Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num));

                        break;

                    case 4:
                        Console.WriteLine("Seno " + Math.Sin(num * Math.PI / 180));
                        break;
                    case 5:
                        Console.WriteLine("Coseno " + Math.Cos(num * Math.PI / 180));
                        break;
                    case 6:
                        Console.WriteLine("Numero maximo " + Math.Max(num, 100));
                        break;
                    case 7:
                        Console.WriteLine("Numero min " + Math.Min(num, 100));
                        break;
                    case 8:
                        Console.WriteLine("Parte entera " + Math.Truncate(num));
                        break;
                    case 9:
                        Console.WriteLine("Redondeando " + Math.Round(num));
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
                Console.WriteLine("Desea hacer otra operacion");
                respta = Console.ReadLine();
            } while (respta == "si");
            

            Console.WriteLine("pulse una tecla para salir");

            Console.ReadKey();
        }

        }
    }

