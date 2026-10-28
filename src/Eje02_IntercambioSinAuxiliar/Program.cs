//Intercambio de variables sin auxiliar
//definir variables
int a, b;
//Ingreso de variable a
Console.Write("Ingrese el valor de a: ");
a= Convert.ToInt32(Console.ReadLine());
//Ingreso de variable b
Console.Write("Ingrese el valor de b: ");
b= Convert.ToInt32(Console.ReadLine());
//Cambio de valores
a = a + b;
b = a - b;
a = a - b;
//Mostrar resultados
Console.WriteLine("Ahora a es: " + a);
Console.WriteLine("Ahora b es: " + b);