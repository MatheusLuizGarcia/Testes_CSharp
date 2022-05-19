int x;
int y;
Console.WriteLine("Algoritmo para verificação de números ímpares em um dado intervalo");
Console.WriteLine("Insira um número inicial");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira um número final");
y = Convert.ToInt32(Console.ReadLine());
while (x <= y)
{
    if (x % 2 != 0)
    {
        Console.WriteLine(x + " é Ímpar");
    }
    x++;
}
Console.WriteLine("fim do código");
