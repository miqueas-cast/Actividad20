// Solicitar n números, guardarlos en un arreglo y ordenarlos de menor a mayor usando ciclos simples
static int ValidacionEntradas(string mensaje, int min, int max)
{
    int numero;
    bool esValido;
    do
    {
        Console.Write(mensaje);
        esValido = int.TryParse(Console.ReadLine(), out numero) && numero >= min && numero <= max;
        if (!esValido)
        {
            Console.Clear();
            Console.WriteLine($"Por favor, ingresa un número.");
        }
    } while (!esValido);
    return numero;
}

int logitud = ValidacionEntradas("¿Cuántos números deseas ingresar? ", 1, int.MaxValue);
int[] numeros = new int[logitud];

for (int i = 0; i < logitud; i++)
{
    numeros[i] = ValidacionEntradas($"Ingresa el número {i + 1}: ", int.MinValue, int.MaxValue);
}

for (int i = 0; i < logitud - 1; i++)
{
    for (int j = 0; j < logitud - 1 - i; j++)
    {
        if (numeros[j] > numeros[j + 1])
        {

            int temporal = numeros[j];
            numeros[j] = numeros[j + 1];
            numeros[j + 1] = temporal;
        }
    }
}


Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
for (int i = 0; i < logitud; i++)
{
    Console.Write(numeros[i] + " ");
}
Console.WriteLine();
