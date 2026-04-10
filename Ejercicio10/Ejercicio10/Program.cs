int[] numerosAleatorios = { 5, 3, 8, 1, 4, 6, 5, 4, 6, 99, 12, 34, 2, 2, 3 };
Console.WriteLine($"Numeros del arreglo: {string.Join(", ", numerosAleatorios)}");

int vecesRepetidas = 0;
int numeroBuscado = 0;
bool entradaValida = false;

while (!entradaValida)
{
    Console.WriteLine("Indique el número que desea contar (debe ser un número positivo): ");

    if (!int.TryParse(Console.ReadLine(), out numeroBuscado))
    {
        Console.WriteLine("Por favor ingrese un número válido.");
    }
    else if (numeroBuscado < 0)
    {
        Console.WriteLine("Por favor ingrese un número positivo.");
    }
    else
    {
        entradaValida = true;
    }
}
for (int i = 0; i < numerosAleatorios.Length; i++)
{
    if (numerosAleatorios[i] == numeroBuscado)
    {
        vecesRepetidas++;
    }
}

Console.WriteLine($"El número {numeroBuscado} se repite {vecesRepetidas} veces.");