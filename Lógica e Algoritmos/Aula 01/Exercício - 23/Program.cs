// Variavel
double temp;

// Obter dados
Console.Write("Digite uma temperatura: "); 
temp = Convert.ToDouble(Console.ReadLine());
Console.Write("Em qual unidade está essa temperatura? [C ou F] ");

switch (Console.ReadLine())
{
    case "C" :
        Console.WriteLine((temp * 1.8) + 32 );
        break;
    case "F":
        Console.WriteLine((temp - 32) / 1.8 );
        break;
}