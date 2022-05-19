Console.WriteLine("Programa que mostra todos os quadrados de números em um dado intervalo");
Console.WriteLine("Defina o número inicial x");
int ini = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Defina o número final y");
int fin = Convert.ToInt32(Console.ReadLine());
int quad;
while ( ini <= fin )
{
    quad = ini * ini;
    Console.WriteLine( ini + "² = " + quad );
    ++ini;
}
Console.Write("fim do código");
Console.ReadKey();