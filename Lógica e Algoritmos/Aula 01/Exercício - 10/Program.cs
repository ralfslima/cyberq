// Variaveis
double  preco, precoFinal = 0;
string   opcao;
string nomeProduto;

Console.Write("Nome do produto: "); 
nomeProduto = Console.ReadLine();
Console.Write("Valor do produto: ");
preco = (float) Convert.ToDecimal(Console.ReadLine());
Console.Write("Forma de pagamento [V = À vista, P = A prazo]: ");
opcao = Console.ReadLine();

// Escolha
switch (opcao)
{
    case "V":
        precoFinal = ( (preco >= 500) ? preco * 0.9 : preco);
        break;
    case "P":
        precoFinal = preco;
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}

// Retorno
Console.WriteLine("O valor final ficou em: R$"+ precoFinal);