//Calcular un numero entero de dos cifras y invertir su valor
//Definir variables
double numero, decenas, unidades, numeroInvertido;
Console.Write("Ingrese un numero entero de dos cifras: ");
numero = Convert.ToDouble(Console.ReadLine());
//Calcular las decenas y unidades
unidades= numero % 10;
decenas = Math.Truncate(numero / 10);
//Calcular el numero invertido
numeroInvertido = unidades * 10 + decenas;
//Mostrar el numero ingresado y el numero invertido
Console.WriteLine($"El numero ingresado es: {numero} y el numero invertido es: {numeroInvertido}");
