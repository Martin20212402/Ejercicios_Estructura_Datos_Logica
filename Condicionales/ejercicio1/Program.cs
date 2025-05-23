using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Hacer un programa para ingresar un número 
            // y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

            //Declarar variable para poder guardar valores
            int n1;

            //Pedir un número dato
            Console.WriteLine("Ingrese un número");
            n1 = int.Parse(Console.ReadLine());

            //Proceso. Mostar en pantalla.
            if(n1 > 10){
                Console.WriteLine("Es mayor a 10");
            }else{
                Console.WriteLine("Es menor a 10");
            }

        }
    }
}        

