// Variaveis
string nomeProduto = "";
double valorProduto = 0.0;

// Obter dados
Console.Write("Nome do produto: "); 
nomeProduto = Console.ReadLine();

Console.Write("Quanto custa o produto?"); 
valorProduto = Convert.ToDouble(Console.ReadLine());

// Limpar tela
Console.Clear();

// Mensagem
Console.WriteLine(nomeProduto + "custa R$" + (valorProduto * 0.9));