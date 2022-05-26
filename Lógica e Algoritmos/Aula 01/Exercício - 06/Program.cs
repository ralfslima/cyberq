// Variaveis
double    n1, n2, n3;
double media;
string   situacao;

Console.Write("Nota 1: "); n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Nota 2: "); n2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Nota 3: "); n3 = Convert.ToDouble(Console.ReadLine());

media = (n1 + n2 + n3) / 3;

if (media <= 10 && media >= 7)
    situacao = "Aprovado";

else if (media <= 6.9 && media >= 5)
    situacao = "Em exame";

else
    situacao = "Reprovado";

Console.WriteLine(situacao);