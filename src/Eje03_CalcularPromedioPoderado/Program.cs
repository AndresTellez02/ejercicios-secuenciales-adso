//Calcular promedio ponderado (25/35/40)
//Defrinir variables
double nota1, nota2, nota3, definitiva;
//solicitar al usuario que ingrese las notas
Console.Write("Ingrese la primera nota (25%): ");
nota1= Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la segunda nota (35%): ");
nota2= Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la tercera nota (40%): ");
nota3= Convert.ToDouble(Console.ReadLine());
//calcular el promedio ponderado
definitiva= (nota1 * 0.25) + (nota2 * 0.35) + (nota3 * 0.40);
//mostrar el resultado
Console.WriteLine("La definitiva es: " + definitiva);
