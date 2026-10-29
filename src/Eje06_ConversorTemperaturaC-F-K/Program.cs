//Conversor de temperatur C° F° Kelvin
//definir variables
double celsius, fahrenheit, kelvin;
//Temperatura en Celsius
Console.Write("Digite a temperatura en Celsius: ");
celsius = Convert.ToDouble(Console.ReadLine());
//Temperatura en Fahrenheit
fahrenheit = (celsius * 9/5) + 32;
//Temperatura en Kelvin
kelvin = celsius + 273.15;
//Mostrar resultados
Console.WriteLine("La temperatura en Fahrenheit es: " + fahrenheit);
Console.WriteLine("La temperatura en Kelvin es: " + kelvin);