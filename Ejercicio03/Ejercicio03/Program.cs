
static int ValidacionEntradas(string mensajes, int min, int max)
{
    int numero;
    bool esValido;
    do
    {
        Console.Write(mensajes);
        esValido = int.TryParse(Console.ReadLine(), out numero) && numero >= min && numero <= max;
        if (!esValido)
        {
            Console.Clear();
            Console.WriteLine($"Entrada no válida. Por favor, ingrese un número.");
        }
        else if (numero < 0)
        {
            Console.Clear();
            Console.WriteLine("Ingrese un número positivo.");
        }
    } while (!esValido);
    return numero;
}

int logitud = ValidacionEntradas("Ingrese la cantidad de números enteros que desea sumar: ", 1, int.MaxValue);

int suma = 0;

int[] numeros = new int[logitud];
for (int i = 0; i < logitud; i++)
{
    numeros[i] = ValidacionEntradas($"Ingrese el número entero {i + 1}: ", 0, int.MaxValue);
    suma += numeros[i];
}

Console.WriteLine($"La suma total de los números ingresados es: {suma}");