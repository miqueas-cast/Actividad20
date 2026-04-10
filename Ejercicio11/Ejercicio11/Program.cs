int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

Console.WriteLine($"Valores iniciales del arreglo: {string.Join(", ", numeros)}");

static int ValidacionEntrada(string mensaje, int min, int max)
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
            Console.WriteLine($"Entrada inválida. Por favor, ingrese un número.");
        }
        else if (numero < 0)
        {            
            Console.Clear();
            Console.WriteLine("El número no puede ser negativo. Por favor, ingrese un número positivo.");
            esValido = false;
        }
    } while (!esValido);
    return numero;
}

int posicion = ValidacionEntrada("Ingrese la posición del número que desea reemplazar: ", 0, numeros.Length -1);

int nuevoValor = ValidacionEntrada("Ingrese el nuevo valor para la posición seleccionada: ", int.MinValue, int.MaxValue);
numeros[posicion] = nuevoValor;

Console.WriteLine($"Arreglo acutualizado: {string.Join(", ", numeros)}");