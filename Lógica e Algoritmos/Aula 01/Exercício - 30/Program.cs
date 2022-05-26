// Contador de acertos
int acertos = 0;

// Primeira pergunta
Console.WriteLine("Capital de Santa Catarina");
Console.WriteLine("1 - Blumenau");
Console.WriteLine("2 - Florianopolis");
if (Console.ReadLine() == "2")
{
    acertos++;
}

// Segunda pergunta
Console.WriteLine("Capital do Parana");
Console.WriteLine("1 - Londrina");
Console.WriteLine("2 - Curitiba");
if (Console.ReadLine() == "2")
{
    acertos++;
}

// Terceira pergunta
Console.WriteLine("Quanto e 2+2?");
Console.WriteLine("1 - 5");
Console.WriteLine("2 - 4");
if (Console.ReadLine() == "2")
{
    acertos++;
}

// Quarta pergunta
Console.WriteLine("Qual a populacao do Brasil?");
Console.WriteLine("1 - 100 milhoes");
Console.WriteLine("2 - 210 milhoes");
if (Console.ReadLine() == "2")
{
    acertos++;
}

// Quinta pergunta
Console.WriteLine("Capital de Sao Paulo");
Console.WriteLine("1 - Campinas");
Console.WriteLine("2 - Sao Paulo");
if (Console.ReadLine() == "2")
{
    acertos++;
}

Console.WriteLine("Voce acertou: "+ acertos+ " questoes."); 
