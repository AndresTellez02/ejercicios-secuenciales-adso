//Calcular un número de cuatro cifras y muestre por separado millares, centenas, decenas y unidades.
//Definir variables
int numero, millares, centenas, decenas, unidades;
Console.Write("Introduce un número de cuatro cifras: ");
numero = Convert.ToInt32(Console.ReadLine());
//Calcular millares, centenas, decenas y unidades
millares = numero / 1000;
centenas = (numero % 1000) / 100;
decenas = (numero % 100) / 10;
unidades = numero % 10;
//Mostrar resultados
Console.Write($"Su numero ingresa es: {numero} y sus cifras son: \nMillares: {millares} \nCentenas: {centenas} \nDecenas: {decenas} \nUnidades: {unidades}");