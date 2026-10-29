//Calcula el area del rectangulo y luego incrementar su base por 2 y su altura por 3 y luego calcular el area nuevamente
//defrinir variables
double baseRectangulo, alturaRectangulo, areaInicial, areaFinal;
//escribir en consola para que el usuario ingrese la base y la altura del rectangulo
Console.Write("Ingrese la base del rectangulo: ");
baseRectangulo = Convert.ToDouble(Console.ReadLine());
//escribir en consola para que el usuario ingrese la altura del rectangulo
Console.Write("Ingrese la altura del rectangulo: ");
alturaRectangulo = Convert.ToDouble(Console.ReadLine());
//calcular el area del rectangulo
areaInicial = baseRectangulo * alturaRectangulo;
//calcular el area del rectangulo despues de incrementar la base y la altura
areaFinal= (baseRectangulo * 2) * (alturaRectangulo * 3);
//escribir en consola el area inicial y el area final
Console.WriteLine("El area inicial del rectangulo es: " + areaInicial);
Console.WriteLine("El area final del rectangulo despues de incrementar la base y la altura es: " + areaFinal);