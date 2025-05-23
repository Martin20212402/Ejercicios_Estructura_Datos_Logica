// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//3. Hacer un programa para ingresar dos números y que luego emita por pantalla
//el mayor de ellos o un cartel aclaratorio “Son iguales” en el caso de que así sea.
//Nota: los números pueden ser iguales.

//Declaro una variable para poder guardar valores espacio en memoria
int n1;
int n2;

//Pedir un número datos al usuario datos
Console.WriteLine("Ingrese un número");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese otro número");
n2 = int.Parse(Console.ReadLine());

//Proceso. Mostrar en pantalla
if(n1 > n2){
    Console.WriteLine("El número ingresado mayor es: " + n1);
}else if(n2 > n1){
    Console.WriteLine("El número ingresado mayor es: " + n2);
}else{
    Console.WriteLine("Son iguales los números ingresados.");
}

