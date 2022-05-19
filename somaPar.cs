int x;
int y;
int sum = 0;
Console.WriteLine("Algoritmo para somar números pares de um dado intervalo");
Console.WriteLine("Insira um número inicial");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira um número final");
y = Convert.ToInt32(Console.ReadLine());
while (x <= y)
{
    if (x % 2 == 0)
    {
        sum += x;
    }
    ++x;
}
Console.WriteLine("Soma de todos os números pares do intervalo: " + sum);