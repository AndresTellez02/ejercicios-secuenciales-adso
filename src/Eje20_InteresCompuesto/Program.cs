//Calcule el capital final con tasa de interes mensual y numero de meses
//Definir variables
double capitalInicial, tasaInteresMensual, capitalFinal, interesGanado;
int numeroMeses;
//Solicitar al usuario que ingrese el capital inicial
Console.Write("Ingrese el capital inicial: ");
capitalInicial = Convert.ToDouble(Console.ReadLine());
//Solicitar al usuario que ingrese la tasa de interes mensual
Console.Write("Ingrese la tasa de interes mensual (en porcentaje): ");
tasaInteresMensual = Convert.ToDouble(Console.ReadLine()) / 100;
//Solicitar al usuario que ingrese el numero de meses
Console.Write("Ingrese el numero de meses: ");
numeroMeses = Convert.ToInt32(Console.ReadLine());
//Calcular el capital final y interes mensual
capitalFinal = Math.Round(capitalInicial * Math.Pow(1 + tasaInteresMensual, numeroMeses), 2);
interesGanado = Math.Round(capitalFinal - capitalInicial, 2);
//Mostrar el resultado
Console.WriteLine($"El capital final es: {capitalFinal} y el interes ganado es: {interesGanado}");