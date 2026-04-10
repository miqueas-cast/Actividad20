int[] arregloUno = { 1, 2, 3, 4, 5 };

int[] arregloDos = new int[arregloUno.Length];

for  (int i = 0; i < arregloUno.Length; i++)
{
    arregloDos[i] = arregloUno[i];
}


Console.WriteLine($"Números del arreglo: {string.Join(", ", arregloUno)}");
Console.WriteLine($"Números del arreglo: {string.Join(", ", arregloDos)}");
