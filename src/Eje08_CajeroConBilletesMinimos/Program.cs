//Cajero ingresando con billetes minimos de 5000, 10000, 20000 y 50000 ingresando su valor a retirar
//El cajero debe entregar el menor numero de billetes posibles
int billete50000, billete20000, billete10000, billete5000, valorRetirar;
//Se solicita al usuario el valor a retirar
Console.Write("Ingrese el valor a retirar (solo multiplos de 5000): ");
valorRetirar = Convert.ToInt32(Console.ReadLine());
//Se calcula el numero de billetes de 50000
billete50000 = valorRetirar / 50000;
valorRetirar %= 50000;
//Se calcula el numero de billetes de 20000
billete20000 = valorRetirar / 20000;
valorRetirar %= 20000;
//Se calcula el numero de billetes de 10000
billete10000 = valorRetirar / 10000;
valorRetirar %= 10000;
//Se calcula el numero de billetes de 5000
billete5000 = valorRetirar / 5000;
//se muestra el resultado al usuario
Console.WriteLine($"valor entregado: {billete50000 * 50000 + billete20000 * 20000 + billete10000 * 10000 + billete5000 * 5000}");
Console.WriteLine("Billetes de 50000: " + billete50000);
Console.WriteLine("Billetes de 20000: " + billete20000);
Console.WriteLine("Billetes de 10000: " + billete10000);
Console.WriteLine("Billetes de 5000: " + billete5000);
