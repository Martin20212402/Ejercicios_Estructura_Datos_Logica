// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 //7. Hacer un programa que solicite una lista de números que corta cuando se
 //ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
 //en la que fue ingresado.

 int n;
 int max = 0;
 int pos = 1;
 

 Console.WriteLine("Ingrese un nro.");
 n = int.Parse(Console.ReadLine());

 max = n;

 int posmax = pos;

 while ( n != 0 )
 {
   

    if(n > max){
        max = n;
        posmax = pos;
    }

    pos++;

    Console.WriteLine("Ingrese un nro.");
    n = int.Parse(Console.ReadLine()); 
 }

 Console.WriteLine("El número máximo ingresado es: " + max);
 Console.WriteLine("El número máximo ingresado en la posición: " + posmax);
