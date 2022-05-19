int fib = 0;
int ini = 1;
int add = 0;
int x;
int arg;
Console.WriteLine("Algoritmo para calcular a sequência de Fibonacci segundo o número de argumentos");
Console.WriteLine("Insira o número de argumentos a ser calculado:");
arg = Convert.ToInt32(Console.ReadLine());
x = arg;
if (x > 1)
{
    while (x > 1)
    {
        fib = ini + add;
        add = ini;
        ini = fib;
        --x;
    }
}
Console.WriteLine(arg + " argumento: " + fib);
Console.WriteLine("fim do código");
