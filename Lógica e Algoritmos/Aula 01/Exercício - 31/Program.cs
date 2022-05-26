// Variaveis
double valor, taxa;
int    meses;

// Obter dados
Console.Write("Valor aplicado: R$");
valor = Convert.ToInt32(Console.ReadLine());
Console.Write("Por quantos meses: ");
meses = Convert.ToInt32(Console.ReadLine());
Console.Write("Qual a taxa: ");
taxa = Convert.ToDouble(Console.ReadLine());

// Exibir mensagem
Console.WriteLine("O total no final será de: R$"+ ((valor + (valor * (taxa / 100) * meses ))));