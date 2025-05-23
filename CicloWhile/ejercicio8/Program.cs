// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//8. Hacer un programa que solicite una lista de números que corta cuando se
//ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.



int n;
int menor1 = 1;
int menor2 = 1;

Console.WriteLine("Ingrese un nro.");
n = int.Parse(Console.ReadLine());

while( n != 0){

    if (n < menor1)
    {
        menor1 = n;
        
    }



    Console.WriteLine("Ingrese un nro.");
    n = int.Parse(Console.ReadLine());

}