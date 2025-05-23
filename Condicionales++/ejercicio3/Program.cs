// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 3. Hacer un programa para ingresar dos números. 
//Si el segundo es distinto de cero, calcular la división del primero por el segundo 
//y mostrar el resultado por pantalla
//; caso contrario, emitir un cartel aclarando que no se puede dividir por cero.

float n1;
float n2;
float resultado = 0;

Console.WriteLine("Ingrese un número: ");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese otro número: ");
n2 = float.Parse(Console.ReadLine());

if(n2 != 0){
    resultado = n1 / n2;
}else{
    Console.WriteLine("No se puede dividir por cero.");
}
Console.WriteLine("El resultado de la división es de: " + resultado);