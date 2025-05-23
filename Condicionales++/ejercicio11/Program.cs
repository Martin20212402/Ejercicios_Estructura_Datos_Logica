// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 11. Hacer un programa para ingresar tres números y luego mostrarlos ordenados
// de menor a mayor.
int a;
int b;
int c;



Console.WriteLine("Ingrese un nro.");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un nro.");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un nro.");
c = int.Parse(Console.ReadLine());

if(a < b && a < c){
    Console.WriteLine(a);
    if(b < c){
        Console.WriteLine(b);
        Console.WriteLine(c);
    }else{
        Console.WriteLine(c);
        Console.WriteLine(b);        
    }
}else if( b < a && b < c){
    Console.WriteLine(b);
    if(c < a){
        Console.WriteLine(c);
        Console.WriteLine(a);
    }else{
        Console.WriteLine(a);
        Console.WriteLine(c);
    }
}else{
    Console.WriteLine(c);
    if(b < a){
        Console.WriteLine(b);
        Console.WriteLine(a);
    }else{
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}      

// if (a < b && a < c)
// {
//     Console.WriteLine(a);
//     if (b < c)
//     {
//         Console.WriteLine(b);
//         Console.WriteLine(c);
//     }
//     else
//     {
//         Console.WriteLine(c);
//         Console.WriteLine(b);
//     }
// }
// else if (b < a && b < c)
// {
//     Console.WriteLine(b);
//     if (a < c)
//     {
//         Console.WriteLine(a);
//         Console.WriteLine(c);
//     }
//     else
//     {
//         Console.WriteLine(c);
//         Console.WriteLine(a);
//     }
// }
// else
// {
//     Console.WriteLine(c);
//     if (a < b)
//     {
//         Console.WriteLine(a);
//         Console.WriteLine(b);
//     }
//     else
//     {
//         Console.WriteLine(b);
//         Console.WriteLine(a);
//     }
// }