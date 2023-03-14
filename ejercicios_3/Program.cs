// los acumuladores y contadores se inicializan en 0. int contador = 0;
// acumulador + variable ó acumulador += variable;
// contador ++ ó -- (escribiéndolo así dentro del if, suma +1 al conteo.)



// 1 --------------------------------
//1. Hacer un programa para ingresar un número y 
// luego se emita por pantalla un cartel aclaratorio 
// si “Es mayor a 10” o “No es mayor a 10”.

// int numero1;

// Console.WriteLine("Ingrese un número: ");
// numero1 = int.Parse(Console.ReadLine());


// // cuando tenemos sólo 1 línea dentro del IF no es necesario colocar las {}.
// if (numero1 > 10)
//     Console.WriteLine("El número es mayor a 10");
// else
//     Console.WriteLine("El número es menor a 10");
// Console.WriteLine("Fin del Programa.");


// 2 --------------------------------------
// 2. Hacer un programa para ingresar un número y luego 
// se emita un cartel por pantalla “Positivo” si el número es mayor a cero, 
// “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.

// int numero1;

// Console.WriteLine("Ingrese un número: ");
// numero1 = int.Parse(Console.ReadLine());

// if (numero1 > 0)
//     Console.WriteLine("El número es POSITIVO.");
// else if (numero1 == 0)
//     Console.WriteLine("El numero es CERO.");
// else
//     Console.WriteLine("El número es NEGATIVO.");
// Console.WriteLine("Fin del Programa.");


// 3 ----------------------------------------
//3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
//Si el importe es menor a ARS 1000, no hay descuento.
//Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
//Si el importe es ARS 5000 o más, aplica un descuento del 18%.
//Hacer un programa para ingresar un importe de venta 
//y luego muestre por pantalla el importe final con el descuento que corresponda.

// float importe;

// Console.WriteLine("Ingrese el importe de la venta: ");
// importe = float.Parse(Console.ReadLine());

// // armar la condición para buscar el verdadero primero.

// if (importe >= 1000){
//     if (importe >= 5000)
//         importe = importe * 0.82F;
//     else 
//         importe = importe * 0.90F;
// }

// Console.WriteLine("El total a pagar es: " + importe);

// 4 -------------------------
//4. Hacer un programa para ingresar cuatro números distintos 
// y luego mostrar por pantalla el menor de ellos.

// int n1, n2, n3, n4, menor;

// Console.WriteLine("Ingrese un número: ");
// n1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese un número: ");
// n2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese un número: ");
// n3 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese un número: ");
// n4 = int.Parse(Console.ReadLine());

// if (n1 < n2)
//     menor = n1;
// else
//     menor = n2;

// if (n3 < menor)
//     menor = n3;

// if (n4 < menor)
//     menor = n4;

// Console.WriteLine("El menor es: " + menor);  


// 5 ------------------------------------
// 5. Hacer un programa para ingresar cuatro números 
// y luego mostrar por pantalla cuáles son mayores a 100.

// int a, b, c, d;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// c = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese el último: ");
// d = int.Parse(Console.ReadLine());

// if (a > 100)
//     Console.WriteLine("El primer valor: " + a + " es mayor a 100.");
// if (b > 100)
//     Console.WriteLine("El segundo valor: " + b + " es mayor a 100.");
// if (c > 100)
//     Console.WriteLine("El tercer valor: " + c + " es mayor a 100.");
// if (d > 100)
//     Console.WriteLine("El cuarto valor: " + d + " es mayor a 100.");


// EJERCICIOS EXTRAS RESUELTOS CON DIAGRAMAS ------------------------


// A ------------------------------------
//2. Hacer un programa para ingresar dos números distintos 
//y luego se muestre por pantalla el menor de ellos.

// int a, b;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = int.Parse(Console.ReadLine());

// if (a > b)
//     Console.WriteLine("El mayor es " + a);
// else
//     Console.WriteLine("El mayor es " + b);

// B ---------------------------------------------
// Hacer un programa para ingresar dos números y que luego emita por pantalla
//el mayor de ellos o un cartel aclaratorio “Son iguales” en el caso de que así sea.

// int a, b;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = int.Parse(Console.ReadLine());

// if (a > b)
//     Console.WriteLine("El mayor es " + a);
// else if (a < b)
//     Console.WriteLine("El mayor es " + b);
// else
//     Console.WriteLine("Son iguales");
    


// C -------------------------------------------
// Hacer un programa para ingresar un número y mostrar por pantalla 
//un cartel aclaratorio si el mismo es PAR o IMPAR.

// int a;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());

// if (a%2 == 0)
//     Console.WriteLine("Es Par");
// else
//     Console.WriteLine("Es impar");


// D -----------------------------------------------
// 7. Hacer un programa para ingresar cuatro números distintos 
// y luego mostrar por pantalla el mayor de ellos.

// int a, b, c, d, mayor;

// Console.WriteLine("ingrese un número: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// c = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese el último: ");
// d = int.Parse(Console.ReadLine());

// if (a > b)
//     mayor = a;
// else
//     mayor = b;

// if (c > mayor)
//     mayor = c;

// if (d > mayor)
//     mayor = d;

// Console.WriteLine("El mayor es: " + mayor);


// E -----------------------------------------------
// 9. Hacer un programa para ingresar cinco números distintos 
// y luego mostrar por pantalla el mayor y el menor de ellos.

// int a, b, c, d, e, mayor, menor;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// c = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// d = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese el último: ");
// e = int.Parse(Console.ReadLine());

// if (a > b){
//     mayor = a;
//     menor = b;
// }else{
//     mayor = b;
//     menor = a;
// }

// if (c > mayor)
//     mayor = c;
// else{
//     if (c < menor)
//         menor = c;
// }

// if (d > mayor)
//     mayor = d;
// else{
//     if (d < menor)
//         menor = d;
// }

// if (e > mayor)
//     mayor = e;
// else{
//     if (e < menor)
//         menor = e;
// }

// Console.WriteLine("El mayor es: " + mayor + ", y el menor: " + menor);


// F //////////////////////////////////////////
// 11. Hacer un programa para ingresar cuatro números 
// y luego mostrar por pantalla cuántos son menores a 100.

// int a, b, c, d, contador = 0;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// c = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese el último: ");
// d = int.Parse(Console.ReadLine());

// if (a > 100)
//     contador ++;
// if (b > 100)
//     contador ++;
// if (c > 100)
//     contador ++;
// if (d > 100)
//     contador ++;

// Console.WriteLine("Hay " + contador + " mayores a 100");
// Console.ReadLine();


// G ----------------------------------------------

// 12. Hacer un programa para ingresar un valor que estará expresado en minutos. Si
// los minutos superan los 60, pasar el valor a horas, de lo contrario dejarlo en
// minutos. Mostrar el resultado en pantalla aclarando si se muestran minutos u horas.

// int minuto, hora_final;

// Console.WriteLine("Ingrese un valor en minutos: ");
// minuto = int.Parse(Console.ReadLine());

// if (minuto > 60){
//     hora_final = minuto / 60;
//     Console.WriteLine("Son: " + hora_final + " horas");
// }else
//     Console.WriteLine("Son: " + minuto + " minutos");