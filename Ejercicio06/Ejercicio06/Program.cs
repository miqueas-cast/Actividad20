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
            Console.WriteLine($"Por favor, ingrese un número válido.");
        }
        else if (numero< 0) { 
            Console.Clear();
            Console.WriteLine("El número no puede ser negativo. Intente nuevamente.");
            esValido = false;
        }
    } while (!esValido);
    return numero;
}

int cantidadNumeros = ValidacionEntradas("¿Cuántos números desea ingresar?: ", 1, int.MaxValue);
int menor = int.MaxValue;

int[] numeros = new int[cantidadNumeros];

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = ValidacionEntradas($"Ingrese el número {i + 1}: ", int.MinValue, int.MaxValue);
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}


Console.WriteLine($"El número menor ingresado es: {menor}");