static int ValidacionEntradas(string mensaje, int min, int max)
{
    int numero;
    bool esValido;
    do
    {
        Console.Write(mensaje);
        string entrada = Console.ReadLine();
        esValido = int.TryParse(entrada, out numero) && numero >= min && numero <= max;
        if (!esValido)
        {
            Console.Clear();
            Console.WriteLine($"Entrada no válida. Por favor, ingrese un número.");
        }
    } while (!esValido);
    return numero;
}

int cantidadPositivos = 0;

int longitud = ValidacionEntradas("Ingrese la longitud del arreglo (entre 1 y 100): ", 1, 100);

int[] numeros = new int[longitud];

for (int i = 0; i < longitud; i++)
{
    numeros[i] = ValidacionEntradas($"Ingrese el número {i + 1}: ", int.MinValue, int.MaxValue);
}

for  (int i = 0;i < longitud; i++)
{
    if (numeros[i] > 0)
    {
        cantidadPositivos++;
    }
}
Console.WriteLine($"Cantidad de numeros positivos: {cantidadPositivos}");