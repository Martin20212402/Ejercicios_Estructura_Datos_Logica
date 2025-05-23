// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 11. Hacer un programa para ingresar 5 números y luego calcule y emita el mayor
// de los primos de la lista. En caso de no haber ningún número primo, deberá
// aclararlo con un cartel.

int n;
int mayorPrimo = 0;
int banPrimo = 0;

for(int x = 0; x < 5; x++){

    Console.WriteLine("Ingrese un número: ");
    n = int.Parse(Console.ReadLine());

    int cont = 0;

    for (int y = 1; y <= n; y++){
        
        if(n % y == 0){
            cont++;
        }

    }
    if(cont == 2){
        if(banPrimo == 0){
            mayorPrimo = n;
            banPrimo = 1;
        }else{
            if(n > mayorPrimo){
                mayorPrimo = n;
            }
        }
    }
}
if(banPrimo == 1){        
    Console.WriteLine(mayorPrimo);
}else{
    Console.WriteLine("No hay primos.");
}


