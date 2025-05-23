// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
//si la suma de los dos primeros es mayor al producto del segundo con el tercero.

int a, b, c;
int suma;
int producto;

Console.WriteLine("Ingrese un nro.");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un nro.");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un nro.");
c = int.Parse(Console.ReadLine());

suma = a + b;
producto = b * c;

if(suma > producto){
    Console.WriteLine("La suma es mayor que el producto.");
}
Console.WriteLine("Fin del programa.");

