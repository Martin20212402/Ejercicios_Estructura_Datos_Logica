// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//5. Hacer un programa para ingresar un número y mostrar por pantalla un cartel
//aclaratorio si el mismo es PAR o IMPAR.

int n1;

Console.WriteLine("Ingrese un número: ");
n1 = int.Parse(Console.ReadLine());

if(n1 % 2 == 0){
    Console.WriteLine("Es Par");
}else{
    Console.WriteLine("Es Impar");
}
