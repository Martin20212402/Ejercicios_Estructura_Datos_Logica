// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 7. Hacer un programa que solicite 10 números y luego mostrar por pantalla el
// máximo de ellos y la posición en la que fue ingresado.
//por motivos prácticos ciclo de 5 vueltas.

int n;
int pos = 0;
int max = 0;

for(int x = 0; x < 5; x++){

    Console.WriteLine("Ingrese un número: ");
    n = int.Parse(Console.ReadLine());

    if (x == 0)
    {
        max = n;
        pos = 1;   //o pos = x + 1;
    }
    else
    {
        if (n > max)
        {
            max = n;
            pos = x + 1;
        }
    }
}
Console.WriteLine("El número máximo ingresado es: " + max + " y está en la posición: " + pos);
