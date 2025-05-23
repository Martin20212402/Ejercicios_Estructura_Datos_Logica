// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// 8. El negocio de desinfectante antes mencionado vende además detergente
// suelto, y los precios se aplican según la siguiente escala:
// a. 25 ARS por litro los primeros 50 litros.
// b. 20 ARS por litro si la venta es de 51 a 200 litros.
// c. 15 ARS por litro si la venta es de 201 a 500 litros.
// d. 10 ARS por litro si la venta es de más de 500 litros.
// Además, si paga en efectivo, tiene un adicional del 10% sobre el importe final.
// Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago
// (ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) y calcule
// y emita por pantalla el monto final a abonar por el cliente.

int litros;
double precioAAbonar = 0;
int tipoPago;
double precioFinal;

Console.WriteLine("Ingrese la cantidad de litros: ");
litros = int.Parse(Console.ReadLine());

if(litros <= 50){
    precioAAbonar = litros * 25;
}else if(litros <= 200){
    precioAAbonar = litros * 20;
}else if(litros <= 500){
    precioAAbonar = litros * 15;
}else{
    precioAAbonar = litros * 10;
}

Console.WriteLine("El precio a abonar es de: " + precioAAbonar);

Console.WriteLine("Ingrese el tipo de pago: 1 pago efectivo - 0 otras opciones de pago");
tipoPago = int.Parse(Console.ReadLine());

if(tipoPago == 1){
    precioFinal = precioAAbonar*0.90;
}else{
    precioFinal = precioAAbonar;
}

Console.WriteLine(precioFinal);
