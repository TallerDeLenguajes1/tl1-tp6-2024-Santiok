// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//EJERCICIO 1.

int num, invertido = 0;

Console.WriteLine("\nIngrese un numero");
int.TryParse(Console.ReadLine(), out num);

if (num > 0)
{
    int aux = num, dig = 0;

    while (aux != 0)
    {
        dig = (aux % 10);
        invertido = invertido*10 + dig;
        aux = (aux / 10);
    }
}

Console.WriteLine("\nEl numero invertido es: " + invertido);

//EJERCICIO 2.

int opcion, num1, num2, resultado;

Console.WriteLine("\nIngrese una opcion:");
Console.WriteLine("1)Sumar");
Console.WriteLine("2)Restar");
Console.WriteLine("3)Multiplicar");
Console.WriteLine("4)Dividir");
int.TryParse(Console.ReadLine(), out opcion);

switch (opcion)
{
    case 1:

        Console.WriteLine("\nIngrese el primer numero");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("\nIngrese el segundo numero");
        int.TryParse(Console.ReadLine(), out num2);

        resultado = num1 + num2;

        Console.WriteLine("El resultado es: " + resultado);

    break;

    case 2:  

        Console.WriteLine("\nIngrese el primer numero");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("\nIngrese el segundo numero");
        int.TryParse(Console.ReadLine(), out num2);

        resultado = num1 - num2;

        Console.WriteLine("El resultado es: " + resultado);

    break;

    case 3:  

        Console.WriteLine("\nIngrese el primer numero");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("\nIngrese el segundo numero");
        int.TryParse(Console.ReadLine(), out num2);

        resultado = num1 * num2;

        Console.WriteLine("El resultado es: " + resultado);

    break;

    case 4: 
     
        Console.WriteLine("\nIngrese el primer numero");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("\nIngrese el segundo numero");
        int.TryParse(Console.ReadLine(), out num2);

        resultado = num1 / num2;

        Console.WriteLine("El resultado es: " + resultado);

    break;

    default:
    Console.WriteLine("La opcion ingresada es incorrecta.");
    break;
}