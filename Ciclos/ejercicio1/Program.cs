// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1. Hacer un programa que solicite el ingreso de 10 números y que muestre el
//mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
//Con fines practicos realizo vueltas del ciclo hasta 5 iteraciones.

int n;
int max = 0;


for(int x = 0; x < 5; x++){
    Console.WriteLine("Ingrese un número: ");
    n = int.Parse(Console.ReadLine());

    if(x == 0){
        max = n;
    }else{
        if(n > max){
            max = n;
        }
    }


    //-----------------------------
    //Otra resolución. solo para números positivos
    // if(n > max){
    //     max = n;
    // }
}

Console.WriteLine("El valor máximo ingresado es: "+ max);
