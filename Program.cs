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

