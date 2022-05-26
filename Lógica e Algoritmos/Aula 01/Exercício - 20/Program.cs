// Variaveis
double valor;
string   moeda;

// Obter dados
Console.Write("Digite um valor: "); valor = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Em qual moeda está o valor: \n1 - Real para Dolar \n2 - Dólar para Real \n3 - Real para Euro \n4 - Euro para Real \n5 - Real para Libra \n6 - Libra para Real");
moeda = Console.ReadLine();

switch (moeda)
{
    case "1":
        Console.WriteLine("US$" + valor / 4.8);
        break;
    case "2":
        Console.WriteLine("R$"+valor * 4.8);
        break;
    case "3":
        Console.WriteLine("E"+ valor * 5.12);
        break;
    case "4":
        Console.WriteLine("R$"+ valor / 5.12);
        break;
    case "5":
        Console.WriteLine("L"+ valor * 7);
        break;
    case "6":
        Console.WriteLine("R$"+ valor / 7);
        break;
    default:
        Console.WriteLine("Opção invalida");
        break;
}
