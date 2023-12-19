namespace arrays_y_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad, n;
            float suma = 0.0f;
            float promedio = 0.0f;

            float min = 10.0f;
            float max = 0.0f;

            Console.WriteLine("Ingrese calificacion");
            cantidad = Convert.ToInt32(Console.ReadLine());

            float[] calif = new float[cantidad];

            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Ingrese calificacion");
                calif[n] = Convert.ToInt32(Console.ReadLine());

            }
         
            for( )

        }

    }
}