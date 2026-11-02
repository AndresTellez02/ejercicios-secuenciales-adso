//Calcule el negocio o perdida de un producto
//Definir Variables
double costoFabricacion, precioVenta, unidadesVendidas, gananciasTotales, porcentajeRentabilidad;
//Ingresar el costo de fabricacion del producto
Console.Write("Ingrese el costo de fabricacion del producto: ");
costoFabricacion = Convert.ToDouble(Console.ReadLine());
//Ingresar el precio de venta del producto
Console.Write("Ingrese el precio de venta del producto: ");
precioVenta = Convert.ToDouble(Console.ReadLine());
//Ingresar la cantidad de unidades vendidas
Console.Write("Ingrese la cantidad de unidades vendidas: ");
unidadesVendidas = Convert.ToDouble(Console.ReadLine());
//Calcular las ganancias totales y el porcentaje de rentabilidad
gananciasTotales = (precioVenta - costoFabricacion) * unidadesVendidas;
porcentajeRentabilidad = (gananciasTotales / (costoFabricacion * unidadesVendidas)) * 100;
//Mostrar los resultados
Console.Write($"Las ganancias totales son: {gananciasTotales} y el porcentaje de rentabilidad es: {porcentajeRentabilidad:F2}%");