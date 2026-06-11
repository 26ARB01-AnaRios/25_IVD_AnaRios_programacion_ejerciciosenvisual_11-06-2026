internal class Program
{
    private static void Main(string[] args)
    {
        // Arreglo de 8 enteros
        int[] numerosEnteros = new int[8];

        int numeroMayor = 0;
        int posicionMayor = 0;

        for (int indice = 0; indice < numerosEnteros.Length; indice++)
        {
            Console.Write($"Ingrese el número {indice + 1}: ");
            numerosEnteros[indice] = int.Parse(Console.ReadLine());

            if (indice == 0)
            {
                numeroMayor = numerosEnteros[indice];
                posicionMayor = indice;
            }
            else
            {
                if (numerosEnteros[indice] > numeroMayor)
                {
                    numeroMayor = numerosEnteros[indice];
                    posicionMayor = indice;
                }
            }
        }

        Console.WriteLine($"\nEl número mayor es: {numeroMayor}");
        Console.WriteLine($"Se encuentra en la posición: {posicionMayor + 1}");
    }
}