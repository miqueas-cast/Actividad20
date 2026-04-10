
static int ValidacionEntrad(string mensaje, int min, int max)
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
            Console.WriteLine($"Por favor, ingresa un número válido entre");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número no puede ser negativo. Inténtalo de nuevo.");
            esValido = false;
        }
    } while (!esValido);
    return numero;
}
int cantidadNumeros = ValidacionEntrad("¿Cuántos números deseas ingresar? ", 1, int.MaxValue);

int[] numeros = new int[cantidadNumeros];

int suma = 0;

for (int i = 0; i < cantidadNumeros; i++)
{
    numeros[i] = ValidacionEntrad($"Ingresa el número {i + 1}: ", int.MinValue, int.MaxValue);
    suma += numeros[i];
}

Console.WriteLine($"El promedio de los números es: {suma / cantidadNumeros}");