int x;
int y;
int z = 0;
double pot;
Console.WriteLine("Algoritmo para descobrir y potências de uma base x");
Console.WriteLine("Insira um número para a base");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira um número máximo de potências");
y = Convert.ToInt32(Console.ReadLine());
while ( y >= z )
{
    pot = Math.Pow(x, z);
    Console.WriteLine(x + "^" + z + " = " + pot);
    z++;
}
Console.WriteLine("fim do código");