//Calcule el tiempo hasta el encuentro y la distancia que recorrió cada vehiculo
//Definir variables
double velocidadVehiculo1, velocidadVehiculo2, distanciaTotal, tiempoEncuentro, distanciaVehiculo1, distanciaVehiculo2;
//Solicitar al usuario la velocidad de cada vehículo y la distancia total entre ellos
Console.Write("Ingrese la velocidad del primer vehículo (en km/h): ");
velocidadVehiculo1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la velocidad del segundo vehículo (en km/h): ");
velocidadVehiculo2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la distancia total entre los vehículos (en km): ");
distanciaTotal = Convert.ToDouble(Console.ReadLine());
//Calcular el tiempo hasta el encuentro
tiempoEncuentro = Math.Round(distanciaTotal / (velocidadVehiculo1 + velocidadVehiculo2), 2);
//Calcular la distancia que recorrió cada vehículo
distanciaVehiculo1 = Math.Round(velocidadVehiculo1 * tiempoEncuentro, 2);
distanciaVehiculo2 = Math.Round(velocidadVehiculo2 * tiempoEncuentro, 2);
//Mostrar los resultados
Console.Write($"El tiempo recorrido hasta el encuentro es: {tiempoEncuentro} horas y la distancia recorrida por el primer vehículo es: {distanciaVehiculo1} km y por el segundo vehículo es: {distanciaVehiculo2} km");
