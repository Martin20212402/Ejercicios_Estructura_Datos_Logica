// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//6. Una casa de video juegos otorga un descuento dependiendo del importe de la
// compra realizada según los siguientes valores:
// • Si el importe es menor a ARS 1000, no hay descuento.
// • Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un
// descuento del 10%.
// • Si el importe es ARS 5000 o más, aplica un descuento del 18%.
// Hacer un programa para ingresar un importe de venta y luego muestre por
// pantalla el importe final con el descuento que corresponda.

double importeCompra;
double importeFinal;

Console.WriteLine("Ingrese el importe de la compra: ");
importeCompra = double.Parse(Console.ReadLine());

if(importeCompra < 1000){
    importeFinal = importeCompra;
}else if(importeCompra < 5000){
    importeFinal = importeCompra*0.9;
}else{
    importeFinal = importeCompra*0.82;
}

Console.WriteLine("El importe a abonar es de: " + importeFinal);

// 2.Otra solución con operadores de concatenación lógicos.
// operadores lógicos. && || !=

float importeCompra2;
float importeFinal2 = 0;

Console.WriteLine("Ingrese el importe de la compra: ");
importeCompra2 = float.Parse(Console.ReadLine());

if(importeCompra2 >= 1000 && importeCompra2 < 5000){
    importeFinal2 = importeCompra2*0.90F;
}else if (importeCompra2 >= 5000)
    importeFinal2 = importeCompra2*0.82F;
else{
    importeFinal2 = importeCompra2;
}   
Console.WriteLine("El importe a abonar es: " + importeFinal2); 



// 3.Otra solución del ejercicio sin utilizar variable importeFinal

double importeCompra3;


Console.WriteLine("Ingrese el importe de la compra: ");
importeCompra3 = double.Parse(Console.ReadLine());

if(importeCompra3 >= 5000){
    importeCompra3 = importeCompra3*0.82;
}else{
    if(importeCompra3 >= 1000){
        importeCompra3 = importeCompra3*0.9;
    }
}

Console.WriteLine("El importe a abonar es de: " + importeCompra3);

