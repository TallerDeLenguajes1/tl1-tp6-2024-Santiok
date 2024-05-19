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

//EJERCICIO 4.

int longitud;

//Ingreso una frase.

Console.WriteLine("\nIngrese una frase:");
string frase = Console.ReadLine();

//Obtengo la longitud de la frase.

longitud = frase.Length;

Console.WriteLine("\nLa longitud de la frase es: " + longitud);

//Ingreso la segunda frase.

Console.WriteLine("\nIngrese una segunda frase:");
string frase2 = Console.ReadLine();

//Concateno las frases.

string fraseConcatenada = String.Concat(frase, " ", frase2);
Console.WriteLine("\nLa nueva frase concatenada es: " + fraseConcatenada
);

//Extraer una subcadena.

string subcadena = frase.Substring(0, 4);
Console.WriteLine("\nLa subcadena es: " + subcadena);

//Recorrer la frase.

foreach (char caracter in frase)
{
    Console.WriteLine(caracter);
}

//Buscar la ocurrencia de un caracter en la frase.

Console.WriteLine("\nIngrese la palabra que quiere buscar:");
string palabra = Console.ReadLine();

//Convertir la frase en minuscula y luego en mayuscula.

string mayusculas = frase.ToUpper();

string minusculas = frase.ToLower();

Console.WriteLine("\nFrase en mayuscula: " + mayusculas);

Console.WriteLine("\nFrase en minúsculas: " + minusculas);



