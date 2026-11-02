//Calcular las latas gastadas y litros sueltos
//definir variables
double metrosCuadrados, metrosPintados, rendimiento, litrosLatas, latasCompletas, litrosSueltos;
//ingresar los metros cuadrados a pintar
Console.Write("Ingresa los metros cuadrados a pintar: ");
metrosCuadrados = Convert.ToDouble(Console.ReadLine());
//ingresar el rendimiento de la pintura
Console.Write("Ingresa el rendimiento de la pintura (m2/litro): ");
rendimiento = Convert.ToDouble(Console.ReadLine());
//ingresar los litros por lata
Console.Write("Ingresa los litros por lata: ");
litrosLatas = Convert.ToDouble(Console.ReadLine());
//calcular los metros pintados, latas completas y litros sueltos
metrosPintados = metrosCuadrados / rendimiento;
latasCompletas = Math.Truncate(metrosPintados / litrosLatas);
litrosSueltos = metrosPintados % litrosLatas;
//mostrar los resultados
Console.Write($"Se usaron {latasCompletas} latas completas y sobraron {litrosSueltos} litros sueltos.");