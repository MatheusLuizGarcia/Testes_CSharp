using System;
{
    Console.WriteLine("insira quantos números deseja calcular:");
    int x = Convert.ToInt32(Console.ReadLine());
    int fib = 0;
    int add = 0;
    int ini = 1;
    while (x != 0)
    {
        fib = ini + add;
        ini = fib;
        add = ini;
        --x;
    }
    Console.WriteLine("número da sequência: " + fib);
    Console.ReadKey();
}