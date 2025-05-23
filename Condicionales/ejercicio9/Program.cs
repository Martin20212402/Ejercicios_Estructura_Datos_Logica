// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 9. Hacer un programa para ingresar cinco números distintos y luego mostrar por
// pantalla el mayor y el menor de ellos.

 
    int n1;
    int n2;
    int n3;
    int n4;
    int n5;

    int mayor;
    int menor;

    Console.WriteLine("Ingrese un número: ");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n4 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n5 = int.Parse(Console.ReadLine());

    if(n1 > n2){
        mayor = n1;
        menor = n2;
    }else{
        mayor = n2;
        menor = n1;
    }
    if(n3 > mayor){
        mayor = n3;
    }else if(n3 < menor){
        menor = n3;
    }
    if(n4 > mayor){
        mayor = n4;
    }else if(n4 < menor){
        menor = n4;
    }
    if(n5 > mayor){
        mayor = n5;
    }else if(n5 < menor){
        menor = n5;
    }

    Console.WriteLine("El nro ingresado mayor es: " + mayor);
    Console.WriteLine("El nro ingresado mayor es: " + menor);
