// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 11. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla
// cuántos son menores a 100.

    int n1;
    int n2;
    int n3;
    int n4;

    int cont = 0;

    Console.WriteLine("Ingrese un número: ");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n4 = int.Parse(Console.ReadLine());

    if(n1 < 100){
        cont = cont + 1;
    }
     if(n2 < 100){
        cont = cont + 1;
    }
     if(n3 < 100){
        cont = cont + 1;
    }
     if(n4 < 100){
        cont = cont + 1;
    }
    Console.WriteLine("La cantidad de números menores a 100 es de: " + cont);
    