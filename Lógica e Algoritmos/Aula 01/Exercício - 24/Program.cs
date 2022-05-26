// Salario
double sal;

// Obter dados
Console.Write("Seu Salário: R$"); sal = Convert.ToDouble(Console.ReadLine());
Console.Write("Quanto que você gasta com Luz: R$"); sal -= Convert.ToDouble(Console.ReadLine());
Console.Write("Quanto que você gasta com Internet: R$"); sal -= Convert.ToDouble(Console.ReadLine());
Console.Write("Quanto que você gasta com Água: R$"); sal -= Convert.ToDouble(Console.ReadLine());
Console.Write("Quanto que você gasta com Mercado: R$"); sal -= Convert.ToDouble(Console.ReadLine());
Console.Write("Quanto que você gasta com Aluguel: R$"); sal -= Convert.ToDouble(Console.ReadLine());

// Retorno
Console.WriteLine("O que te resta é: R$" + sal);