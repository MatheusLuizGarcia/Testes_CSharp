double x;
double y = 1;
double res;
Console.WriteLine("Algoritmo para determinar a tabuada de 1 a 10 de qualquer número");
Console.WriteLine("insira um número");
x = Convert.ToDouble(Console.ReadLine());
while ( y <= 10)
{
    res = x * y;
    Console.WriteLine(x + " x " + y + " = " + res);
    ++y;
}
Console.WriteLine("fim do código");