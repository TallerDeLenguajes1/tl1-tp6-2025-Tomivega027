// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
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

