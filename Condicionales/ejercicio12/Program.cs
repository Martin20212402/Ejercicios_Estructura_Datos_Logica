// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// 12. Hacer un programa para ingresar un valor que estará expresado en minutos. 
//Si los minutos superan los 60, pasar el valor a horas, de lo contrario dejarlo en
// minutos. 
//Mostrar el resultado en pantalla aclarando si se muestran minutos u horas.


float minutos;
float horas = 0;

Console.WriteLine("Ingrese un número: ");
minutos = float.Parse(Console.ReadLine());

if(minutos > 60){
    horas = minutos / 60;
    Console.WriteLine("Resultado en horas: " + horas + " hora.");
}else{
    Console.WriteLine("Resultado en minutos: " + minutos + " min.");
}
