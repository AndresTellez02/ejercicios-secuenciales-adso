//Intercambio con variable auxiliar
//definir variabes
int a, b, c;
//Ingreso de valor a
Console.Write("Ingrese su primer valor: ");
a = Convert.ToInt32(Console.ReadLine());
//Ingreso de valor b
Console.Write("Ingrese su segundo valor: ");
b = Convert.ToInt32(Console.ReadLine());
//Intercambio
c = a;
a = b;
b = c;
Console.WriteLine($"Los valores intercambiados son: {a}, {b}");