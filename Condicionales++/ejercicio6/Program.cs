// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// 6. Hacer un programa para ingresar por teclado la longitud de los tres lados de un
// triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo
// de triángulo corresponde:
// a. Equilátero: cuando los tres lados sean iguales.
// b. Isósceles: cuando dos de los tres lados sean iguales.
// c. Escaleno: cuando todos los lados sean distintos.

int l1;
int l2;
int l3;

Console.WriteLine("Ingrese el primer lado: ");
l1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo lado: ");
l2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer lado: ");
l3 = int.Parse(Console.ReadLine());

if(l1 == l2 && l2 == l3){
    Console.WriteLine("Es equilátero.");
}else if(l1 == l2 && l2 != l3){
    Console.WriteLine("Es isósceles.");
}else{
    Console.WriteLine("Es escaleno.");

}
