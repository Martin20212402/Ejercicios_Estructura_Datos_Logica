// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 10. Hacer un programa que solicite 20 números y luego emitir por pantalla el
// máximo de los números pares y el mínimo de los números impares.

// int n;
// int maxPar = 0;
// int minImpar = 0;

// int contPar = 0;
// int contImpar = 0;

// for(int x = 0; x <6; x++){

//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());

//     if(n % 2 == 0){
//         contPar++;       //trabajo con pares
//         if(contPar == 1){
//             maxPar = n;
//         }else if(n > maxPar){
//             maxPar = n;
//         }
//     }else{
//         contImpar++;     //trabajo con impares
//         if(contImpar == 1){
//             minImpar = n;
//         }else if(n < minImpar){
//             minImpar = n;
//         }
//     }
// }
// Console.WriteLine("El máximo de los pares es: " + maxPar);
// Console.WriteLine("El mínimo de los imparespares es: " + minImpar);

//Otra resolución con bandera -> para marcar el camino

// 10. Hacer un programa que solicite 20 números y luego emitir por pantalla el
// máximo de los números pares y el mínimo de los números impares.

int n;
int maxPar = 0;
int minImpar = 0;

bool banTengoPar = false;
bool banTengoImpar = false;

for(int x = 0; x <6; x++){

    Console.WriteLine("Ingrese un número: ");
    n = int.Parse(Console.ReadLine());

    if(n % 2 == 0){
        //trabajo con pares
        if(banTengoPar == false){
            maxPar = n;
            banTengoPar = true;
        }else if(n > maxPar){
            maxPar = n;
        }
    }else{
        //trabajo con impares
        if(banTengoImpar == false){
            minImpar = n;
            banTengoImpar = true;
        }else if(n < minImpar){
            minImpar = n;
        }
    }
}
Console.WriteLine("El máximo de los pares es: " + maxPar);
Console.WriteLine("El mínimo de los imparespares es: " + minImpar);


