// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 4. Un importante negocio de desinfectante líquido realiza descuentos
// dependiendo de la cantidad de litros vendidos según la siguiente escala:
// a. Si vende menos de 100 litros, no hay descuento.
// b. Si vende entre 101 y 300 litros, el descuento es del 10%.
// c. Si vende entre 301 y 500 litros, el descuento es del 15%.
// d. Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

// Hacer un programa que solicite el ingreso del importe total de la venta y la
// cantidad de litros vendidos y calcule y emita el importe con el descuento
// aplicado.

float importeTotal;
float litros;
float importeAAbonar = 0;

Console.WriteLine("Ingrese el importe total de la venta: ");
importeTotal = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
litros = float.Parse(Console.ReadLine());

// a. Si vende menos de 100 litros, no hay descuento.
// b. Si vende entre 100 y 300 litros, el descuento es del 10%.
// c. Si vende entre 301 y 500 litros, el descuento es del 15%.
// d. Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
if(litros < 100){
    importeAAbonar = importeTotal;
}else if(litros >= 100 && litros <= 300){
    importeAAbonar = importeTotal*0.9F;
}else if(litros >= 301 && litros <= 500){
    importeAAbonar = importeTotal*0.85F;
}else{
    importeAAbonar = importeTotal*0.75F;
}

Console.WriteLine("El importe a abonar es de: " + importeAAbonar);

//Otra resolución sin operadores lógicos de concatenación
float importeTotal1;
float litros1;
float importeAAbonar1 = 0;

Console.WriteLine("Ingrese el importe total de la venta: ");
importeTotal1 = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
litros1 = float.Parse(Console.ReadLine());

if(litros1 < 100){
    importeAAbonar1 = importeTotal1;
}else if(litros1 <= 300){
    importeAAbonar1 = importeTotal1*0.9F;
}else if(litros1 <= 500){
    importeAAbonar1 = importeTotal1*0.85F;
}else{
    importeAAbonar1 = importeTotal1*0.75F;
}

Console.WriteLine("El importe a abonar es de: " + importeAAbonar1);

//Escenarios para tener una sola variable, en la cual el importeFinal no lo requiero
//la asignación es destructiva.

float litros2, importeFinal2;

Console.WriteLine("Ingrese el importe total de la venta: ");
importeFinal2 = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
litros2 = float.Parse(Console.ReadLine());

// a. Si vende menos de 100 litros, no hay descuento.
// b. Si vende entre 100 y 300 litros, el descuento es del 10%.
// c. Si vende entre 301 y 500 litros, el descuento es del 15%.
// d. Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

if(litros > 500){
    importeFinal2 = importeFinal2 * 0.75F;
}else if(litros > 300){
    importeFinal2*=0.85F;
}else if(litrso >= 100){
    importeFinal2*=0.90F;
}

Console.WriteLine("El importe final a abonar es de: " + importeFinal2)









