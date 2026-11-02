//Calcular un número entero de tres cifras y muestre su inverso
//Definir variables
int numero, centenas, decenas, unidades;
Console.Write("Ingrese un número entero de tres cifras: ");
numero = Convert.ToInt32(Console.ReadLine());
//separar las cifras del número
centenas = numero / 100;
decenas = (numero / 10) % 10;
unidades = numero % 10;
//mostrar el inverso del número
Console.Write("El inverso del número es: {0}{1}{2}", unidades, decenas, centenas);
Console.ReadKey();