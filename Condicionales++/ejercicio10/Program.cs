// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 10. Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si
// son todos iguales entre sí, caso contrario, no emitir nada.

int n1;
int n2;
int n3;
int n4;

Console.WriteLine("Ingrese un nro");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un nro");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un nro");
n3 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un nro");
n4 = int.Parse(Console.ReadLine());

if(n1 == n2 && n2 == n3 && n3 == n4){
    Console.WriteLine("Los nros ingresados son todos iguales.");
}