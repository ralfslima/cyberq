// Variavel idade
int idade = 0;

// Obter idade
idade = Convert.ToInt32(Console.ReadLine());

// Condicional
if(idade >= 18)
{
    Console.WriteLine("Apto para obter a CNH");
}
else
{
    Console.WriteLine("Infelizmente voce não está apto para obter a CNH");
}