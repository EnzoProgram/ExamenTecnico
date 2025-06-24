using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Versión simple:");
        Console.WriteLine(simpleVersion(new int[] { 1, 4, 3, 9 }, 8)); // false
        Console.WriteLine(simpleVersion(new int[] { 1, 4, 2, 4 }, 8)); // true

        Console.WriteLine("\nVersión optimizada:");
        Console.WriteLine(optimizedVersion(new int[] { 2, 5, 3, 9 }, 8)); // True
        Console.WriteLine(optimizedVersion(new int[] { 1, 2, 2, 4 }, 8)); // False
    }

    // Función Versión simple
    static bool simpleVersion(int[] numeros, int numeroSumado)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            for (int j = i + 1; j < numeros.Length; j++)
            {
                // Si la suma de dos números da el resultado buscado, devolvemos true.
                if (numeros[i] + numeros[j] == numeroSumado)
                    return true;
            }
        }
        // Si recorremos todo y no encontramos combinación, devolvemos false.
        return false;
    }

    // Función Versión optimizada
    static bool optimizedVersion(int[] numeros, int numeroSumado)
    {
        // Para guardar los números que se recorren en el array.
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in numeros)
        {
            int complement = numeroSumado - num;
            if (seen.Contains(complement))
                return true;

            // Agregamos el número actual al conjunto
            seen.Add(num);
        }
        // Si recorremos todo y no encontramos combinación, devolvemos false.
        return false;
    }
}
