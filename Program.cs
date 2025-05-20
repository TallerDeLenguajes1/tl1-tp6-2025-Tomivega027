// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

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

int num1;
Console.WriteLine("Numero a:");
string buff1 = Console.ReadLine();
int.TryParse(buff1, out num1);

int num2;
Console.WriteLine("Numero b:");
string buff2 = Console.ReadLine();
int.TryParse(buff2, out num2);

int op;
    Console.WriteLine("CALCULADORA:");
    Console.WriteLine("1.SUMA:");
    Console.WriteLine("2.RESTA:");
    Console.WriteLine("3.MULTIPLACION:");
    Console.WriteLine("4.DIVISION:");
    Console.WriteLine("0.SALIR:");
    Console.WriteLine("SELECCIONE LA OPERACION:");
string buff3 = Console.ReadLine();
int.TryParse(buff3, out op);
while (op != 0)
{
    switch (op)
    {
        case 1:
            int suma = 0;
            suma = num1 + num2;
            Console.WriteLine("suma:" + suma);
            break;
        case 2:
            int resta = 0;
            resta = num1 - num2;
            Console.WriteLine("resta:" + resta);
            break;
        case 3:
            int multp = 0;
            multp = num1 * num2;
            Console.WriteLine("multiplicacion:" + multp);
            break;
        case 4:
            float division = 0;
            if (num2 != 0)
            {
                division = num1 / num2;
                Console.WriteLine("division:" + division);
            }
            break;
        default:
            op = 0;
            break;
    }
    Console.WriteLine("CALCULADORA:");
    Console.WriteLine("1.SUMA:");
    Console.WriteLine("2.RESTA:");
    Console.WriteLine("3.MULTIPLACION:");
    Console.WriteLine("4.DIVISION:");
    Console.WriteLine("0.SALIR:");
    Console.WriteLine("SELECCIONE LA OPERACION:");
    buff3 = Console.ReadLine();
    int.TryParse(buff3, out op);
}





