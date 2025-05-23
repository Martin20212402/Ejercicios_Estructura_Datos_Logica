// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 2. Hacer un programa que solicite el ingreso de dos números y luego calcular:
// a. La resta si el primero es mayor que el segundo.
// b. La suma si son iguales.
// c. El producto si el primero es menor.
// Se deberá emitir un cartel por pantalla con el resultado correspondiente.

int n1;
int n2;
int resultado;

Console.WriteLine("Ingrese un número: ");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese otro número: ");
n2 = int.Parse(Console.ReadLine());

if(n1 > n2){
    resultado = n1 - n2;
}else if(n1 == n2){
    resultado = n1 + n2;
}else{
    resultado = n1 * n2;
}

Console.WriteLine("El resultado es: " + resultado);

//--------------------------------------------

//Otra alternativa if independientes

// if(n1 > n2){
//     resultado = n1 - n2;
// }
// if(n1 == n2){
//     resultado = n1 + n2;
// }
// if(n1 < n2){
//     resultado = n1 * n2;
// }
    
// Console.WriteLine("El resultado es: " + resultado);

//--------------------------------------------

//Otra alternativa if else

// if(n1 > n2){
//     resultado = n1 - n2;
// }else{
//      if(n1 == n2){
//      resultado = n1 + n2;
//      }else{
//            resultado = n1 * n2;
//      }
// }
    
// Console.WriteLine("El resultado es: " + resultado);