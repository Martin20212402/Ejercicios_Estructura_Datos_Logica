// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//2. Hacer un programa para ingresar dos números distintos y luego se muestre por
//pantalla el menor de ellos.

//Declarar variable para poder guardar valores
int n1;
int n2;

//Pedir números al usuario dato
Console.WriteLine("Ingrese un número");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un número");
n2 = int.Parse(Console.ReadLine());


//Proceso. Mostrar por pantalla
if(n1 < n2){
    Console.WriteLine("El número ingresado menor es: " + n1);
}else{
    Console.WriteLine("El número ingreado menor es: " + n2);
}
