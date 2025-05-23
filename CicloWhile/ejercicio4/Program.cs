// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 4. Hacer un programa que solicite dos números y luego muestre los números
// entre el menor y el mayor de ellos. Acordate, usando While.

//Declaro variables. Espacio en memoria.
int a;
int b;
int menor = 0;
int mayor = 0;

//Pedir al usuario los datos(ingreso)
Console.WriteLine("Ingrese un número: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un número: ");
b = int.Parse(Console.ReadLine());

if(a > b){
    mayor = a;
    menor = b;
}else{
    mayor = b;
    menor = a;
}

mayor = mayor - 1;
while(menor < mayor){
    menor = menor + 1;    
    Console.WriteLine(menor);
    
}