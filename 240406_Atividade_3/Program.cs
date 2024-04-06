using System;

int x = 1;
int y = 1;
char op = ' ';
float res = 0;

Console.WriteLine("Insira seu operador matemático (+|-|*|/):");
op = char.Parse(Console.ReadLine());

if (op == '+')
{
    for (x = 1;x <= 9; x++)
    {
        for (y = 1;y <= 9; y++)
            {
            res = x+y;
            Console.WriteLine($"{x} + {y} = {res}");
            }
        Console.WriteLine("-------------");
    }
}

if (op == '-')
{
    for (x = 1;x <= 9; x++)
    {
        for (y = 1;y <= 9; y++)
            {
            res = x-y;
            Console.WriteLine($"{x} - {y} = {res}");
            }
        Console.WriteLine("-------------");
    }
}

if (op == '*')
{
    for (x = 1;x <= 9; x++)
    {
        for (y = 1;y <= 9; y++)
            {
            res = x*y;
            Console.WriteLine($"{x} * {y} = {res}");
            }
        Console.WriteLine("-------------");
    }
}

if (op == '/')
{
    for (x = 1;x <= 9; x++)
    {
        for (y = 1;y <= 9; y++)
            {
            res = x/y;
            Console.WriteLine($"{x} / {y} = {res}");
            }
        Console.WriteLine("-------------");
    }
}