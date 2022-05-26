// Variaveis
int hora;
int cidade;

// Obter dados
Console.Write("Digite um horário na sua região: "); 
hora = Convert.ToInt32(Console.ReadLine());
Console.Write("1) Cidade do Mexico");
Console.Write("2) Nova Iorque");
Console.Write("3) Toquio");
cidade = Convert.ToInt32(Console.ReadLine());

// Condicional
if(cidade == 1)
{
Console.WriteLine("No México, seriam: " +  (hora - 2));
}
else if(cidade == 2)
{
Console.WriteLine("Em Nova Yorque, seriam: ", (hora - 1));
}
else
{
Console.WriteLine("Em Tóquio, seriam:", (hora + 12));
}

