// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 7. Hacer un programa para ingresar 4 números. Luego analizar e informar por
// pantalla si los mismos se encuentran ordenados de forma decreciente.


int n1;
int n2;
int n3;
int n4;

Console.WriteLine("Ingrese el primer número: ");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número: ");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número: ");
n3 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el cuarto número: ");
n4 = int.Parse(Console.ReadLine());

if(n1 > n2 && n2 > n3 && n3 > n4){
    Console.WriteLine("Estan ordenados de manera decreciente.");
}else{
    Console.WriteLine("No están ordenados de manera decreciente.");
}