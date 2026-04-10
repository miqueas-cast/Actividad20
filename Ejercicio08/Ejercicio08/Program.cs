int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

int numerosPares = 0;
int numerosImpares = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {

        numerosPares++;
    }
    else
    {
        numerosImpares++;
    }
}
Console.WriteLine($"Numeros del arreglo: {string.Join(", ", numeros)}");


Console.WriteLine($"Cantidad de números pares: {numerosPares}");
Console.WriteLine($"Cantidad de números impares: {numerosImpares}");