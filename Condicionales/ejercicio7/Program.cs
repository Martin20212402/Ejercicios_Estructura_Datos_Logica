// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
    //7. Hacer un programa para ingresar cuatro números distintos y luego mostrar por
    //pantalla el mayor de ellos.

    int n1;
    int n2;
    int n3;
    int n4;

    int mayor;

    Console.WriteLine("Ingrese un número: ");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n4 = int.Parse(Console.ReadLine());

    if(n1 > n2){
        mayor = n1;
    }else{
        mayor = n2;
    }
    if(n3 > mayor){
        mayor = n3;
    } 
    if(n4 > mayor){
        mayor = n4;
    }
    Console.WriteLine(mayor);

    //Otra opción con concatenadores op. lógicos

    int a;
    int b;
    int c;
    int d;

    int mayorValor;

    Console.WriteLine("Ingrese un número: ");
    a = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    b = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    c = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    d = int.Parse(Console.ReadLine());

    if(a > b && a > c && a > d){
        mayorValor = a;
    }else if(b > a && b > c && b > d){
        mayorValor = b;
    }else if(c > a && c > b && c > d){
        mayorValor = c;
    }else{
        mayorValor = d;
    }
    Console.WriteLine(mayorValor);

