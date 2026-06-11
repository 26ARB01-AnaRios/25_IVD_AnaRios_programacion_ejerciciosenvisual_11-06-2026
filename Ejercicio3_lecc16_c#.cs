internal class Program
{
    private static void Main(string[] args)
    {
        int[] numerosEnteros = new int[15];

        bool existeRepetido = false;

        // Leer los 15 números
        for (int indice = 0; indice < numerosEnteros.Length; indice++)
        {
            Console.Write($"Ingrese el número {indice + 1}: ");
            numerosEnteros[indice] = int.Parse(Console.ReadLine());
        }

        // Buscar números repetidos
        for (int indice = 0; indice < numerosEnteros.Length - 1; indice++)
        {
            for (int comparador = indice + 1; comparador < numerosEnteros.Length; comparador++)
            {
                if (numerosEnteros[indice] == numerosEnteros[comparador])
                {
                    existeRepetido = true;
                }
            }
        }

        // Mostrar resultado
        if (existeRepetido)
        {
            Console.WriteLine("\nSí existe al menos un número repetido.");
        }
        else
        {
            Console.WriteLine("\nNo existe ningún número repetido.");
        }
    }
}