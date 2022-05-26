// Variaveis
string nome;
string cidade;
int idade;

// Obter dados
Console.Write("Digite seu nome: "); 
nome = Console.ReadLine();

Console.Write("Digite a cidade em que você mora: ");
cidade = Console.ReadLine();

Console.Write("Digite a sua idade: ");
idade = Convert.ToInt32( Console.ReadLine() );

// Limpar console
Console.Clear();

// Mensagem
Console.WriteLine("Olá, "+nome+", voce mora em: "+cidade+" e tem "+idade+" anos.");
