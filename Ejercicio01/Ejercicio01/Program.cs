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
    } while (!esValido);
    return numero;
}

Console.Write("¿Cuántos números desea ingresar?\n> ");
int cantidadNumeros = ValidacionEntradas("Ingrese la cantidad de números a ingresar: ", 1, int.MaxValue);


int [] numeros = new int[cantidadNumeros];
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("");
    numeros[i] = ValidacionEntradas($"Ingrese el número {i + 1}: ", 1, int.MaxValue);
}

Console.WriteLine("Los números ingresados son:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}