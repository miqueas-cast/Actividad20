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
            Console.WriteLine($"Entrada inválida. Por favor, ingresa un número");
        }
        else if (numero < 0)
        {
            Console.Clear();
            Console.WriteLine("Por favor ingrese un número positovo");
        }
    } while (!esValido);
    return numero;
}

int longitudArreglo = ValidacionEntradas("Ingrese la longitud del arreglo ", 1, 100);

int[] arreglo = new int[longitudArreglo];
for (int i = 0; i < longitudArreglo; i++)
{
    arreglo[i] = ValidacionEntradas($"Ingrese el elemento {i + 1}: ", int.MinValue, int.MaxValue);
}

int numeroDeseado = ValidacionEntradas("Ingrese el número que desea buscar: ", int.MinValue, int.MaxValue);

for  (int i = 0;i < arreglo.Length; i++)
{
    if (arreglo[i] == numeroDeseado)
    {
        Console.WriteLine($"El número {numeroDeseado} se encuentra en la posición {i}");
        return;
    }
}