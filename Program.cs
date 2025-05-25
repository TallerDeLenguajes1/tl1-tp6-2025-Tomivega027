// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);


// ejercicio 1 invertir 
int num;
int numInvertido = 0;
Console.WriteLine("Numero a invertir:");
string buff = Console.ReadLine();
if (int.TryParse(buff, out num))
{
    while (num > 0)
    {
        int aux = num % 10;
        numInvertido = numInvertido * 10 + aux;
        num /= 10;
    }
    Console.WriteLine("NUMERO INVERTIDO:" + numInvertido);
}


    int opcion;
do
{
    Console.WriteLine("   ");
    Console.WriteLine("****CALCULADORA****");
    Console.WriteLine("1.SUMA");
    Console.WriteLine("2.RESTA");
    Console.WriteLine("3.MULTIPLICACION");
    Console.WriteLine("4.DIVICION");
    Console.WriteLine("5.SALIR");
    Console.WriteLine("Elija una opcion:");
    string buf = Console.ReadLine();
    int.TryParse(buf, out opcion);

        Console.WriteLine("Ingrese un numero:");
        int numero1;
        string buff1 = Console.ReadLine();
        int.TryParse(buff1 , out numero1);

        Console.WriteLine("ingrese otro numero:");
        int numero2;
        string buff2 = Console.ReadLine();
        int.TryParse(buff2, out numero2);
    

    switch (opcion)
    {
        case 1:
            int suma = numero1 + numero2;
            Console.WriteLine("RESULTADO SUMA:" + suma);
            break;
        case 2:
            int resta = numero1 - numero2;
            Console.WriteLine("RESULTADO RESTA:" + resta);
            break;
        case 3:
            int mult = numero1 * numero2;
            Console.WriteLine("RESULTADO MULTIPLICACION:" + mult);
            break;
        case 4:
            float division;
            if (numero2 != 0)
            {
                division =(float)numero1 / numero2;
                Console.WriteLine("RESULTADO DIVISION:" + division);
            }
            else
            {
                Console.WriteLine("numero2 es igual a 0");
            }
            break;
        default:
            Console.WriteLine("opcion salir");
            break;

    }


}while (opcion != 5) ;


//CALCULADORA 2 
double numero;
Console.WriteLine("ingrese un numero:");
string buff3 = Console.ReadLine();
double.TryParse(buff3, out numero);


Console.WriteLine("1.Valor absoluto");
double valorAbsoluto = Math.Abs(numero); // valor absoluto del numero ingresado
Console.WriteLine($"El valor abs. del numero {numero}:{valorAbsoluto}");

Console.WriteLine("2.Cuadrado");
double cuadrado = numero * numero; // cuadrado del numero ingresado
Console.WriteLine($"Cuadrado del numero {numero}: {cuadrado}");

Console.WriteLine("3.Raiz Cuadrada");
double raiz;
if (numero >= 0)
{
    raiz = Math.Sqrt(numero); // obtenemos la raiz cuadrada del numero ingresado
    Console.WriteLine($"La raiz del numero {numero} :" + raiz);
}
else
{
    Console.WriteLine("Numero invalido");
}

double radianes = numero * Math.PI / 180; //pasamos el numero ingresado a radianes

Console.WriteLine("4.Sen"); //seno
double seno = Math.Sin(radianes);
Console.WriteLine($"El seno del numero{numero}:"+ seno);

Console.WriteLine("5.Cos"); //coseno
double cos = Math.Cos(radianes);
Console.WriteLine($"Cos del numero {numero}" + cos);

Console.WriteLine("6.Numero float a entero"); // numero float a entero
int entero = (int)numero;
Console.WriteLine($"Numero Float: {numero} numero Entero:" + entero);

Console.WriteLine("ingrese dos numeros");
Console.WriteLine("numero uno : ");
int x;
string buff4 = Console.ReadLine();
int.TryParse(buff4, out x);

Console.WriteLine("numero dos:");
int y;
string buff5 = Console.ReadLine();
int.TryParse(buff5, out y);

if (x > y)
{
    Console.WriteLine("El maximo entre los dos es:" + x);
    Console.WriteLine("El minimo entre los dos es:" + y);
}else
{    
    Console.WriteLine("El maximo entre los dos es:" + y);
    Console.WriteLine("El minimo entre los dos es:" + x);
}


// ejercicio 4 "Cadena de texto "

Console.WriteLine("Ingrese una cadena de texto");
string cadena1 = Console.ReadLine();
int longitud = cadena1.Length;

Console.WriteLine("Ingrese una segunda cadena de texto");
string cadena2 = Console.ReadLine();
string concatenacion = cadena1 + cadena2;

Console.WriteLine("Ingrese la posición inicial de la subcadena:");
int inicio;
string buff6 = Console.ReadLine();
int.TryParse(buff6, out inicio);

Console.WriteLine("Ingrese la cantidad de caracteres a extraer de cadena1:");
string buff7 = Console.ReadLine();
int cantidad;
int.TryParse(buff7, out cantidad);

if (cantidad >= 0 && inicio + cantidad <= cadena1.Length)
{
    string subcadena = cadena1.Substring(inicio, cantidad);
    Console.WriteLine($"Subcadena extraida: {subcadena}");
}
else
{
    Console.WriteLine("La posicion inicial o cantidad de caracteres a extrar excedientes");
}
int opcion2;
Console.WriteLine("   ");
    Console.WriteLine("****CALCULADORA****");
    Console.WriteLine("1.SUMA");
    Console.WriteLine("2.RESTA");
    Console.WriteLine("3.MULTIPLICACION");
    Console.WriteLine("4.DIVICION");
    Console.WriteLine("5.SALIR");
    Console.WriteLine("Elija una opcion:");
    string buff8 = Console.ReadLine();
    int.TryParse(buff8, out opcion2);

        Console.WriteLine("Ingrese un numero:");
        int num1;
        string buff9 = Console.ReadLine();
        int.TryParse(buff9 , out num1);

        Console.WriteLine("ingrese otro numero:");
        int num2;
        string buff10 = Console.ReadLine();
        int.TryParse(buff10, out num2);
    

    switch (opcion2)
    {
        case 1:
            int suma = num1 + num2;
            Console.WriteLine($"la suma de {num1} y de {num2} es igual a: {suma}");
            break;
        case 2:
            int resta = num1 - num2;
            Console.WriteLine($"la resta de {num1} y de {num2} es igual a: {resta}");
            break;
        case 3:
            int mult = num1 * num2;
            Console.WriteLine($"la multiplicacion  de {num1} y de {num2} es igual a: {mult}");
            break;
        case 4:
            float division;
            if (num2 != 0)
            {
                division =(float)num1 / num2;
                Console.WriteLine($"la division de {num1} y de {num2} es igual a: {division}");
            }
            else
            {
                Console.WriteLine("num2 es igual a 0");
            }
            break;
        default:
            Console.WriteLine("opcion salir");
            break;

    }










