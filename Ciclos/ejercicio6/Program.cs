// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//6. Hacer un programa que solicite UN número y luego calcule y emita un cartel
// aclaratorio si el mismo es primo o no es primo.
// Nota: un numero es primo cuando es divisible únicamente por 1 y por sí
// mismo.

int n;
int cont = 0;

Console.WriteLine("Ingrese un número: ");
n = int.Parse(Console.ReadLine());

for(int x = 1; x <= n; x++){
   

    if(n % x == 0){
        cont++;
    }

}    

if(cont == 2){
    Console.WriteLine("El número ingresado es primo.");
}else{
    Console.WriteLine("El número ingresado no es primo.");
}

//Otra opción de resolución.

int n1;
int cont1 = 0;

Console.WriteLine("Ingrese un número: ");
n1 = int.Parse(Console.ReadLine());

for(int x = 2; x < n1; x++){
   

    if(n % x == 0){
        cont1++;
    }

}    

if(cont1 == 0){     //si da cero es primo porque nunca se dividio por los que estaban entre medio de uno y si mismo.
    Console.WriteLine("El número ingresado es primo.");
}else{
    Console.WriteLine("El número ingresado no es primo.");
}




