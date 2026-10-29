//Calcular Area y Perimetro de un circulo
//definir radio
double area, perimetro, radio;
//Ingresar valor del radio
Console.Write("Ingrese el valor del radio: ");
radio = Convert.ToDouble(Console.ReadLine());
//calcular area y perimetro
area = Math.PI * (radio * radio);
perimetro = 2 * Math.PI * radio;
//mostrar resultados
Console.WriteLine("El area del circulo es: " + area);
Console.WriteLine("El perimetro del circulo es: " + perimetro);