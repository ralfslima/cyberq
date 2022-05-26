// Variaveis
int l1, l2, l3;

// Obter dados
Console.Write("Lado 1: "); 
l1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lado 1: "); 
l2 =  Convert.ToInt32(Console.ReadLine());
Console.Write("Lado 1: "); 
l3 =  Convert.ToInt32(Console.ReadLine());

// Condicional
if (l1 == l2 && l1 == l3)
{
    Console.WriteLine("Equilátero");
}
else if (l1 != l2 && l2 != l3 && l1 != l3)
{
    Console.WriteLine("Escaleno");
}
else
{
    Console.WriteLine("Escaleno");
}