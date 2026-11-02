//Calcular la suma de 3 digitos de un numero entero
//definir variables
int numero, suma, digito1, digito2, digito3;
Console.Write("Ingrese un numero entero de 3 digitos: ");
numero = Convert.ToInt32(Console.ReadLine());
//obtener los digitos del numero
digito1 = numero / 100; //obtener el primer digito
digito2 = (numero / 10) % 10; //obtener el segundo digito
digito3 = numero % 10; //obtener el tercer digito
//calcular la suma de los digitos
suma = digito1 + digito2 + digito3;
//mostrar el resultado
Console.WriteLine($"El numero ingresado es: {numero} y la suma de sus digitos es: {suma}");