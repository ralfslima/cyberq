// Variavel
int ano = 0;

// Obter ano
Console.Write("Digite um ano: ");
ano = Convert.ToInt16( Console.ReadLine() );

//Validacao
if (ano % 4 == 0)
{
    Console.WriteLine("É um ano bissexto");
} 
else
{
    Console.WriteLine("Não é um ano bissexto");
}