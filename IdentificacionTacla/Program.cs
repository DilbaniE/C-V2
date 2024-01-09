namespace IdentificacionTacla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Reconocimiento de teclas
            char tecla;
            string optio;
           

            do
            {
                Console.WriteLine("Digite una tecla");
                tecla = Convert.ToChar(Console.ReadLine());

                switch (tecla)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        Console.WriteLine("la tecla digitada es un numero");
                        break;
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("la tecla digitada es una vocal");
                        break;
                    default:
                        Console.WriteLine("la tecla digitada es una consonante");
                        break;
                }
                Console.WriteLine("la tecla digitada es: {0}", tecla);

                Console.WriteLine("Desea dijitar otra opcion");
                optio = Console.ReadLine();

            } while (optio == "si");            
            Console.WriteLine("Digite una tecla para salir");*/

            int num, i, result;

            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < 12; i++)
            {
                result = num * i;
                Console.WriteLine("{0} * {1} = {2}",num, i, result);
            }
            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadKey();

        }
    }
}