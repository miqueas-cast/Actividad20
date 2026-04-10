
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
            Console.WriteLine($"Entrada inválida. Por favor, ingresa un número.");
        }
        else if (numero < 0)
        {
            Console.Clear();
            Console.WriteLine($"Entrada inválida. Por favor, ingresa un número positivo.");
            esValido = false;
        }
    } while (!esValido);
    return numero;
}   
int cantidadNumeros = ValidacionEntradas("¿Cuántos números deseas ingresar? ", 1, int.MaxValue);

int[] numeros = new int[cantidadNumeros];

for (int i = 0; i < cantidadNumeros; i++)
{
    numeros[i] = ValidacionEntradas($"Ingresa el número {i + 1}: ", 0, int.MaxValue);
}


Console.WriteLine("Números en orden inverso:");
for (int i = cantidadNumeros - 1; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}