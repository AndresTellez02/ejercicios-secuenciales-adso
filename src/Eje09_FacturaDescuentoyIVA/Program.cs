//Calcular la factura con descuento e IVA
//definir variables
double factura, descuento, iva, total, totalConDescuento, totalConIva;
Console.Write("Ingrese el valor de la factura: ");
factura = Convert.ToDouble(Console.ReadLine());
//calcular el descuento
Console.Write("Ingrese el porcentaje de descuento: ");
descuento = Convert.ToDouble(Console.ReadLine());
totalConDescuento = factura - (factura * descuento / 100);
//calcular el IVA
Console.Write("Ingrese el porcentaje de IVA: ");
iva = Convert.ToDouble(Console.ReadLine());
totalConIva = totalConDescuento + (totalConDescuento * iva / 100);
//mostrar resultados
Console.WriteLine("Total con descuento: " + totalConDescuento);
Console.WriteLine("Total con IVA: " + totalConIva);