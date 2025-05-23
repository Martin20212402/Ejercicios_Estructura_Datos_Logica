// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 9. Una importante marca de computadoras permite elegir cierta configuración del
// equipo a comprar. Para ello existe la siguiente escala de precios:
//                i5 (1)     i7 (2)       i9 (3)
// 8 RAM (1)    USD 800     USD 900      USD 1200
// 16 RAM (2)   USD 900     USD 1000     USD 1400
// 32 RAM (3)   USD 1000    USD 1400     USD 2000
// Además, el equipo viene con un disco que permite almacenar 500 GB de
// información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo
// adicional de USD 300.
// Hacer un programa que solicite la opción de procesador, la opción de memoria
// RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender)
// y calcule y emita por pantalla el monto de la máquina seleccionada.

int procesador, memoria, disco;
float precio = 0;
float precioFinal = 0;

Console.WriteLine("Ingrese procesador: ");
procesador = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese memoria: ");
memoria = int.Parse(Console.ReadLine());

Console.WriteLine("Extiende disco: ");
disco = int.Parse(Console.ReadLine());

// if(procesador == 1 && memoria == 1){
//     precio = 800;
// }else if(procesador == 1 && memoria == 2){
//     precio = 900;
// }else if(procesador == 1 && memoria == 3){
//     precio = 1000;
// }else if(procesador == 2 && memoria == 1){
//     precio = 900;
// }else if(procesador == 2 && memoria == 2){
//     precio = 1000;
// }else if(procesador == 2 && memoria == 3){
//     precio = 1400;
// }else if(procesador == 3 && memoria == 1){
//     precio = 1200;
// }else if(procesador == 3 && memoria == 2){
//     precio = 1400;
// }else if(procesador == 3 && memoria == 3){
//     precio = 2000;
// }

// Console.WriteLine("El precio es el siguiente: " + precio);
 


// if(disco == 1){
//     precioFinal = precio + 300;
// }else{
//     precioFinal = precio;
// }

// Console.WriteLine("Precio final es: " + precioFinal);

//---------------------------------------------------------
//Otra alternativa de resolución

// if(procesador == 1){
//     if(memoria == 1){
//         precio = 800;
//     }else if(memoria == 2){
//         precio = 900;
//     }else{
//         precio = 1000;
//     }
// }
// if(procesador == 1){
//     if(memoria == 1){
//         precio = 900;
//     }else if(memoria == 2){
//         precio = 1000;
//     }else{
//         precio = 1400;
//     }
// }

// if(procesador == 3){
//     if(memoria == 1){
//         precio = 1200;
//     }else if(memoria == 2){
//         precio = 1400;
//     }else{
//         precio = 2000;
//     }
// }

// Console.WriteLine("El precio es el siguiente: " + precio);

// if(disco == 1){
//     precioFinal = precio + 300;
// }else{
//     precioFinal = precio;
// }

// Console.WriteLine("Precio final es: " + precioFinal);

//---------------------------------------------------------
//Otra alternativa con if con switch de resolución

// if(procesador == 1){
//     switch (memoria)
//     {
//         case 1:
//             precio = 800;
//             break;
//          case 2:
//             precio = 900;
//             break;    
        
//         default:
//             precio = 1000;
//             break; 

//     }
// }
// if(procesador == 1){
//     switch (memoria)
//     {
//         case 1:
//             precio = 900;
//             break;
//          case 2:
//             precio = 1000;
//             break;    
        
//         default:
//             precio = 1400;
//             break; 

//     }
// }
// if(procesador == 3){
//     switch (memoria)
//     {
//         case 1:
//             precio = 1200;
//             break;
//          case 2:
//             precio = 1400;
//             break;    
        
//         default:
//             precio = 2000;
//             break; 

//     }
// }

// Console.WriteLine("El precio es el siguiente: " + precio);

// if(disco == 1){
//     precioFinal = precio + 300;
// }else{
//     precioFinal = precio;
// }

// Console.WriteLine("Precio final es: " + precioFinal);

//Alternativa switch con switch

switch(procesador){
    case 1:
        switch (memoria)
        {
            case 1:
                precio = 800;
                break;
            case 2:
                precio = 900;
                break;              
            default:
                precio = 1000;
                break;
        }
    break;  
    case 2:
        switch (memoria)
        {
            case 1:
                precio = 900;
                break;
            case 2:
                precio = 1000;
                break;              
            default:
                precio = 1400;
                break;
        }
    break; 
    case 3:
        switch (memoria)
        {
            case 1:
                precio = 1200;
                break;
            case 2:
                precio = 1400;
                break;              
            default:
                precio = 2000;
                break;
        }
    break; 
}

Console.WriteLine("El precio es el siguiente: " + precio);

if(disco == 1){
    precioFinal = precio + 300;
}else{
    precioFinal = precio;
}

Console.WriteLine("Precio final es: " + precioFinal);









