// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//3. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar
//ningún pedido de datos.


for( int x = 0; x < 10; x++){
    Console.WriteLine(x+1);
}

Console.WriteLine("\n");

//Otra resolución establecer una variable contadora.

int con = 1;
for(int x = 0; x < 10; x++){
    Console.WriteLine(con);
    con++;
}


Console.WriteLine("\n");

//Otra resolución con while


//int cont = 0; podes iniciar tu variable contadora con cero, pero en el while primero contas
//y despues lees.
int cont = 1;

while(cont <= 10){
    Console.WriteLine(cont);
    cont++;
}

