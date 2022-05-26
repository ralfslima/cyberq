// Variavel contendo a media
double media = Convert.ToDouble(Console.ReadLine());

// Condicional
if(media < 0 || media > 10)
{
    Console.WriteLine("Media invalida");
}
else if(media >= 7)
{
    Console.WriteLine("Aprovado(a)");
}
else if(media >= 5)
{
    Console.WriteLine("Em exame");
}
else
{
    Console.WriteLine("Reprovado(a)");
}