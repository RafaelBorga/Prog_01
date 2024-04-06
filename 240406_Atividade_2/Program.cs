using System;

int x = 0;
char op = ' ';
int y = 0;
int res = 0;

Console.WriteLine("Insira seu Primeiro número:");
x = int.Parse(Console.ReadLine());

Console.WriteLine("Insira seu Operador(+|-|*|/):");
op = char.Parse(Console.ReadLine());

Console.WriteLine("Insira seu Segundo número:");
y = int.Parse(Console.ReadLine());

if(op == '+')
{
    res = x+y;
    Console.WriteLine($"Resultado: {res}");
}

if(op == '-')
{
    res = x-y;
    Console.WriteLine($"Resultado: {res}");
}

if(op == '*')
{
    res = x*y;
    Console.WriteLine($"Resultado: {res}");
}

if(op == '/')
{
    if(y == 0)
    Console.WriteLine("Não é Possivel!");
    else
        {
        res = x/y;
        Console.WriteLine($"Resultado: {res}");
        }
}