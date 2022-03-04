//variables para el programa
int selection = 0;
double temperatura;
double resultado;

//mensaje para que el usuario sepa que hacer
Console.WriteLine("Bienvenido, por favor ingrese el número de la opcion que desea utilizar: ");
Console.WriteLine("0 - Convertir de Celsius a Fahrenheit");
Console.WriteLine("1 - Convertir de Fahrenheit a Celsius");
selection = int.Parse(Console.ReadLine());

//switch par que se tomen las opciones que pueda tomar el usuario
switch (selection)
{
    case 0:
        Console.WriteLine("Por favor ingrese el valor que desea convertir a grados Fahrenheit");
        temperatura = double.Parse(Console.ReadLine());
        resultado = (temperatura * 1.8) + 32;
        Console.WriteLine("La conversion se ha realizado satisfactoriamente");
        Console.WriteLine("La temperatua es: " + resultado + " grados Fahrenheit");
        break;
    case 1:
        Console.WriteLine("Por favor ingrese el valor que desea convertir a grados Celsius");
        temperatura = double.Parse(Console.ReadLine());
        resultado = (temperatura - 32) * 1.8;
        Console.WriteLine("La conversion se ha realizado satisfactoriamente");
        Console.WriteLine("La temperatua es: " + resultado + " grados Celsius");
        break;

};
