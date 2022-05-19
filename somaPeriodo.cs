int x;
int y;
int sum = 0;
Console.WriteLine("Algoritmo para somar números inteiros em um dado intervalo");
Console.WriteLine("Insira o número inicial");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira o número final");
y = Convert.ToInt32(Console.ReadLine());
while (x <= y)
{
    sum += x;
    ++x;
}
Console.WriteLine("Soma de todos os números no intervalo: " + sum);
