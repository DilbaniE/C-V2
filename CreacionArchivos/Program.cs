using System.IO;//CREAR VARIABLES DE TIPO OBJETO QUE NOS SIRVEN COMO ARCHIVOS
namespace CreacionArchivos

{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            /*
            //Creando un archivo txt, escribiendo texto y guardando
            Console.WriteLine("Escribe el mensaje a guardar");
            TextWriter archivo1; //variable
            archivo1 = new StreamWriter("informacion.txt");  //crear archivo de text plano
            string mensaje = Console.ReadLine(); // variable
            archivo1.WriteLine(mensaje);
            archivo1.Close(); //cierre automatico
            Console.Clear(); //lipiar pantalla
            Console.WriteLine("fue guardado");*/


            /*
            //leer archivo en pantalla txt
            TextReader LeerArchivo;
            LeerArchivo = new StreamReader("informacion.txt");
            Console.WriteLine(LeerArchivo.ReadToEnd());
            LeerArchivo.Close();*/


            //Agregar mas texto sin que se elimine el anterior 
            Console.WriteLine("escribe el mensaje");
            StreamWriter archivo1 = File.AppendText("informacion.txt");
            string mensaje = Console.ReadLine();
            archivo1.WriteLine(mensaje);
            archivo1.Close();
            Console.WriteLine("mensaje guardado");




            Console.ReadKey();
        }
    }
}