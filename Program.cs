// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//EJERCICIO 1.
Console.WriteLine("\n----------Ejercicio 1----------\n");

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
Console.WriteLine("\n----------Ejercicio 2----------\n");

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



//EJERCICIO 3.
Console.WriteLine("\n----------Ejercicio 3----------\n");

int parteEntera;
float numero1, numero2, minimo, maximo;
double numero, valAbs, cuadrado, raizCuad, seno, coseno;

Console.WriteLine("\nIngrese un numero:");

//Calculo el valor absoluto.
if (double.TryParse(Console.ReadLine(), out numero))
{
    valAbs = Math.Abs(numero);
    Console.WriteLine("\nEl valor absoluto del numero es: " + valAbs);

    //Calculo el cuadrado.
    cuadrado = numero*numero;
    Console.WriteLine("\nEl cuadrado del numero es: " + cuadrado);

    //Calculo la raiz cuadrada.
    if (numero > 0)
    {
        raizCuad = Math.Sqrt(numero);
        Console.WriteLine("\nEl raiz cuadrada del numero es: " + raizCuad);
    }else
    {
        Console.WriteLine("\nEl numero ingresado es negativo no tiene raiz.");
    }

    //Calculo el seno.
    seno = Math.Sin(numero * Math.PI / 180);
    Console.WriteLine("\nEl seno del numero es: " + seno);

    //Calculo el coseno.
    coseno = Math.Cos(numero * Math.PI / 180);
    Console.WriteLine("\nEl coseno del numero es: " + coseno);

    //Calculo la parte entera.
    parteEntera = (int)numero;
    Console.WriteLine("\nLa parte entera del numero es: " + parteEntera);

} else
{
    Console.WriteLine("El numero ingresado es invalido.");
}

Console.WriteLine("\nIngrese el primer numero:");
float.TryParse(Console.ReadLine(), out numero1);
Console.WriteLine("\nIngrese el segundo numero:");
float.TryParse(Console.ReadLine(), out numero2);

if (numero1 > numero2)
{
    maximo = numero1;
    minimo = numero2;
    Console.WriteLine("\nEl maximo es: :" + maximo);
    Console.WriteLine("\nEl minimo es: " + minimo);

} else
{
    if (numero1 < numero2)
    {
        maximo = numero2;
        minimo = numero1;
        Console.WriteLine("\nEl maximo es: :" + maximo);
        Console.WriteLine("\nEl minimo es: " + minimo);
    } else
    {
        Console.WriteLine("\nLos numeros son iguales:" + numero1);
    }
}
