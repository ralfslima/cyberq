// Variaveis
double n1, n2;

// Obter notas
Console.WriteLine("Digite suas duas notas: ");
Console.Write("Nota 1: "); 
n1 = Convert.ToDouble( Console.ReadLine() );
Console.Write("Nota 2: "); 
n2 =  Convert.ToDouble( Console.ReadLine() );

// Limpar console
Console.Clear();

// Mensagem
Console.WriteLine("Sua média é de:" + ((n1 + n2) / 2));