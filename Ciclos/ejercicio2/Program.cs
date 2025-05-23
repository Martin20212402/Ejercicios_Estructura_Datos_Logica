// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//2. Hacer un programa que solicite 20 números y calcule y emita por pantalla
//cuántos son positivos (mayores a cero). Se debe mostrar un solo valor: el
//conteo final.
//Con fines prácticos la condición x<5.

int n;
int cont = 0;

for(int x = 0; x < 5; x++){
    Console.WriteLine("Ingrese un número: ");
    n = int.Parse(Console.ReadLine());

    if(n > 0){
        cont = cont + 1;
        //cont++;
    }

}

Console.WriteLine("Los números ingresados mayores a 0 (positivos) son: " + cont + " número/s.");
