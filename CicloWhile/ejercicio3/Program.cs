// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 3. Hacer un programa que solicite la edad de un grupo de personas. El programa
// deberá pedir edades hasta que se ingrese una edad menor a 18 años. Deberá
// mostrar por pantalla cuántas personas mayores se registraron.


int edad;
int cont = 0;

Console.WriteLine("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine());

while(edad >= 18){
    Console.WriteLine("Ingrese su edad: ");
    edad = int.Parse(Console.ReadLine());
    cont++;
}

Console.WriteLine("Las edades ingresadas mayores a 18 años son: " + cont);
