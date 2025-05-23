// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 10. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla
// cuáles son mayores a 100.

    int n1;
    int n2;
    int n3;
    int n4;

    int cont;

    Console.WriteLine("Ingrese un número: ");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n4 = int.Parse(Console.ReadLine());

    if(n1 > 100){
        Console.WriteLine("El primer valor ingresado: " + n1 + " es mayor a 100.");
    }
    if(n2 > 100){
        Console.WriteLine("El segundo valor ingresado: " + n2 + " es mayor a 100.");
    }
    if(n3 > 100){
        Console.WriteLine("El tercer valor ingresado: " + n3 + " es mayor a 100.");
    }
    if(n4 > 100){
        Console.WriteLine("El cuarto valor ingresado: " + n4 + " es mayor a 100.");
    }
