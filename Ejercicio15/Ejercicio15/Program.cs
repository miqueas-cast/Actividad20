int[] arreglo = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

int[] pares = new int[arreglo.Length];
int [] impares = new int[arreglo.Length];

for (int i = 0; i < arreglo.Length; i++)
{
    if (arreglo[i] % 2 == 0)
    {
        pares[i] = arreglo[i];
    }
    else
    {
        impares[i] = arreglo[i];
    }
}

Console.WriteLine($"Arreglo inicial: {string.Join(", ", arreglo)}");

Console.WriteLine($"Pares: {string.Join(", ", pares)}");
Console.WriteLine($"Impares: {string.Join(", ", impares)}");