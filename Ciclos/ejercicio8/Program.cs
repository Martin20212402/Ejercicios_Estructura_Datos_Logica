// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//// 8. Hacer un programa que solicite 20 números y luego mostrar por pantalla el
// menor de ellos y la posición en la que fue encontrado.
//por motivos prácticos un ciclo de 5 vueltas.

int n;
int min = 0;
int pos = 0;

for(int x = 0; x < 5; x++){
    Console.WriteLine("Ingrese un número: ");
    n = int.Parse(Console.ReadLine());

    if (x == 0)
    {
        min = n;
        pos = x + 1;
    }
    else
    {
        if (n < min)
        {
            min = n;
            pos = x + 1;
        }
    }
}
