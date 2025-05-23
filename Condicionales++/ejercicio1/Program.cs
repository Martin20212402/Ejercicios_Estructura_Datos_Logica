// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 1. Hacer un programa que solicite el ingreso de un número y que luego emita un
// cartel por pantalla aclarando si el mismo es múltiplo de 5.

//Declaro una variable para tener espacio en memoria y poder guardar los valores.
int n;
//Pedir al usuario dato/s
Console.WriteLine("Ingrese un número: ");
n = int.Parse(Console.ReadLine());
//Proceso.Mostrar en pantalla. Múltiplo de 5 cuando el residuo de la división es 0
if(n % 5 == 0){
    Console.WriteLine("Es múltiplo de 5.");
}else{
    Console.WriteLine("No es múltiplo de 5.");
}












