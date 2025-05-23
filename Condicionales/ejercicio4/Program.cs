// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//4. Hacer un programa para ingresar un número y luego se emita un cartel por
//pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es
//menor a cero o “Cero” si el número es igual a cero.

int n1;

Console.WriteLine("Ingrese un número");
n1 = int.Parse(Console.ReadLine());

if(n1 > 0){
    Console.WriteLine("El número ingresado es positivo.");
}else if(n1 < 0){
    Console.WriteLine("El número ingresado es negativo.");
}else{
    Console.WriteLine("El número ingresado es cero.");
}

