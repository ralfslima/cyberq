// Variaveis
int l1, l2, l3, l4;

Console.Write("Lado 1: "); 
l1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lado 2: "); 
l2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lado 3: "); 
l3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lado 4: "); 
l4 = Convert.ToInt32(Console.ReadLine());

// Condicional
if (l1 == l2 && l1 == l3 && l1 == l4)
{
    Console.WriteLine("É um quadrado");
}
else
{
    Console.WriteLine("Não é um quadrado");
}