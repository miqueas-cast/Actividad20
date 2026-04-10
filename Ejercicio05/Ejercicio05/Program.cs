
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
            Console.WriteLine($"Entrada no válida. Por favor, ingrese un número entre {min} y {max}.");
        }
    } while (!esValido);
    return numero;
}
int cantidadNumeros = ValidacionEntradas("¿Cuántos números desea ingresar? ", 1, int.MaxValue);

int mayor = 0;
int[] numeros = new int[cantidadNumeros];
for ( int i = 0; i < cantidadNumeros; i++)
{
    numeros[i] = ValidacionEntradas($"Ingrese el número {i + 1}: ", int.MinValue, int.MaxValue);
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
}

Console.WriteLine($"El número mayor es: {mayor}");

