//Calcular la distanica. los galones necesarios y costo del combustible para un viaje
//Definir variables
double distancia, autonomia, precioGalon, galonesNecesarios, costoCombustible, tiempo, velocidad;
//Solicitar al usuario la velocidad promedio del viaje
Console.Write("Ingrese la velocidad promedio del viaje (km/h): ");
velocidad = Convert.ToDouble(Console.ReadLine());
//Solicitar al usuario el tiempo estimado del viaje
Console.Write("Ingrese el tiempo estimado del viaje (horas): ");
tiempo = Convert.ToDouble(Console.ReadLine());
//solicitar al usuario la autonomía del vehículo
Console.Write("Ingrese la autonomía del vehículo (km/galón): ");
autonomia = Convert.ToDouble(Console.ReadLine());
//Solicitar al usuario el precio del galón de combustible
Console.Write("Ingrese el precio del galón de combustible ($): ");
precioGalon = Convert.ToDouble(Console.ReadLine());
//calcular la distancia del viaje
distancia = velocidad * tiempo;
//calcular los galones necesarios para el viaje
galonesNecesarios = distancia / autonomia;
//calcular el costo del combustible para el viaje
costoCombustible = galonesNecesarios * precioGalon;
//Mostrar resultados de la distancia, galones necesarios y costo del combustible
Console.WriteLine($"La distancia del viaje es: {distancia} km, los galones necesarios son: {galonesNecesarios} y el costo del combustible es: ${costoCombustible}");