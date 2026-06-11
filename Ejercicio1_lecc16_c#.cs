internal class Program
{
    private static void Main(string[] args)
    {
        // Arreglo para almacenar las edades de 7 personas
        int[] edadesPersonas = new int[7];

        int cantidadMayoresEdad = 0;

        // Leer las edades
        for (int indice = 0; indice < edadesPersonas.Length; indice++)
        {
            Console.Write($"Ingrese la edad de la persona {indice + 1}: ");
            edadesPersonas[indice] = int.Parse(Console.ReadLine());

            if (edadesPersonas[indice] >= 18)
            {
                cantidadMayoresEdad++;
            }
        }

        Console.WriteLine($"\nCantidad de personas mayores de edad: {cantidadMayoresEdad}");
    }
}