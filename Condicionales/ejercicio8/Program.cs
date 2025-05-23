// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//8. Hacer un programa para ingresar cuatro números distintos y luego mostrar por
// pantalla el menor de ellos.


    int n1;
    int n2;
    int n3;
    int n4;

    int menor;

    Console.WriteLine("Ingrese un número: ");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número: ");
    n4 = int.Parse(Console.ReadLine());

    if(n1 < n2){
        menor = n1;
    }else{
        menor = n2;
    }
    if(n3 < menor){
        menor = n3;
    }
    if(n4 < menor){
        menor = n4;
    }

    Console.WriteLine(menor);


