// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 //6. Hacer un programa que solicite UN número y luego calcule y emita un cartel
 //aclaratorio si el mismo es primo o no es primo.
 //Nota: usando While. Ya lo hicimos con FOR, ahora con While.

// int n1;
// int cont1= 0;

// Console.WriteLine("Ingrese un número: ");
// n1 = int.Parse(Console.ReadLine());


// for(int x = 1; x <= n1; x++){

//     if(n1 % x == 0){
//         cont1++;
//     }

// }
// if(cont1 == 2){
//     Console.WriteLine("Es primo.");
// }else{
//     Console.WriteLine("No es primo.");
// }

int n;
int cont = 0;
int divisor = 1;  // en esta ocasión antes use la variable interna del ciclo for, ahora una 
                  //una variable auxiliar  

Console.WriteLine("Ingrese un número: ");
n = int.Parse(Console.ReadLine());

while (divisor <= n)
{
    if(n % divisor == 0){
        cont++;
        
    }
    divisor++;
}

if(cont == 2){
    Console.WriteLine("Es primo.");
}else{
    Console.WriteLine("No es primo.");
}