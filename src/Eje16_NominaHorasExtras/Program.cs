//Calcular la nomina con horas extras
//Definir Variables
double horasTrabajadas, valorHora, salarioBase, horasExtras, total;
//Solicitar al usuario el número de horas trabajadas
Console.Write("Ingrese el número de horas trabajadas: ");
horasTrabajadas = Convert.ToDouble(Console.ReadLine());
//Solicitar al usuario el valor de la hora
Console.Write("Ingrese el valor de la hora: ");
valorHora = Convert.ToDouble(Console.ReadLine());
//calcular el salario base, las horas extras y el total a pagar
salarioBase = horasTrabajadas * valorHora;
horasExtras= salarioBase * 0.25; // Suponiendo que las horas extras son el 25% del salario base
total = salarioBase + horasExtras;
//Mostrar el resultado
Console.Write($"El salario base es de: {salarioBase:C}, las horas extras son: {horasExtras:C}, y el total a pagar es: {total:C}");