// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 9. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad
// de aquellas personas mayores a 18 años.
//a modo practico ingreso de 5 edades.

int edad;
int promedio;
int acu = 0;
int cont = 0;

for(int x = 0; x < 5; x++){
    Console.WriteLine("Ingrese una edad: ");
    edad = int.Parse(Console.ReadLine());

    if(edad > 18){
        acu = edad + acu;  
        cont++; 
    }
}

promedio = acu / cont;
Console.WriteLine("El promedio de las edades mayores a 18 años es de: " + promedio);


