namespace Enumeraciones
{
    internal class Program
    {

        //Declaracion de enumeracion 
        enum semana { lunes,martes,miercoles,jueves,viernes,sbado}
        enum colores { rojo = 1, azul, amarillo}

        static void Main(string[] args)
        {
            int  numerico = 0;
            // Variable de tipo SEMANA
            semana dia;
            // asingnacion de valor DIA
            dia = semana.lunes;
           // pasamos de numeracion a ENTERO
           numerico = (int)dia;
            //mostrar informacion
            Console.WriteLine("El dia es {0} con valor {1}", dia, numerico);


            //creando una variable de tipo color 
            colores color = colores.rojo;
            //pasamos de numeracion a entero
            numerico = (int)color;
            //mostrar informacion
            Console.WriteLine("el color es {0} con valor {1}",color, numerico);
        }
    }
}