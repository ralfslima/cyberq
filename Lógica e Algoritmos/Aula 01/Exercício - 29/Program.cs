// Variaveis
int vv, vm;

// Obter dados
Console.Write("Qual o limite de velocidade: "); 
vm = Convert.ToInt32(Console.ReadLine());
Console.Write("Qual a velocidade do motorista: "); 
vv = Convert.ToInt32(Console.ReadLine());

// Condicional
if (vv <= vm)
{
    Console.WriteLine("Bom motorista");
}
else if (vv >= vm - 10 && vv <= vm + 10)
{
    Console.WriteLine("Multa de R$50,00");
}
else if (vv >= vm - 20 && vv <= vm + 20)
{
    Console.WriteLine("Multa de R$100,00");
}
else
{
    Console.WriteLine("Multa de R$200,00");
}
