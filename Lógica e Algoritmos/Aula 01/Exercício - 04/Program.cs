// Variaveis
int   n1, n2;
string operacao;
double resultado = 0;

Console.Write("Número 1: ");
n1 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Número 2: ");
n2 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Qual operação deseja realizar? ");
operacao = Console.ReadLine();

switch (operacao)
{
    case "+":
        resultado = n1 + n2;
        break;
    case "-":
        resultado = n1 - n2;
        break;
    case "*":
        resultado = n1 * n2;
        break;
    case "/":
        resultado = n1 / n2;
        break;
    default:
        Console.WriteLine("Operação inválida");
        break;
}

Console.WriteLine(resultado);
