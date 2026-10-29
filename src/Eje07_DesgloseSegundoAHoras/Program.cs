//Desglose de segundos a horas
//definir variable de segundos y horas
double segundos, horas;
Console.Write("Ingrese la cantidad de segundos: ");
segundos = Convert.ToDouble(Console.ReadLine());
//desglose de segundos a horas
horas = segundos / 3600;
Console.WriteLine("La cantidad de horas es: " + horas);