// Obter o valor investido
Console.WriteLine("Informe o valor que sera investido");
double valor = Convert.ToDouble(Console.ReadLine());

// Obter o periodo
Console.WriteLine("Informe o periodo (meses)");
int periodo = Convert.ToInt32(Console.ReadLine());

// Obter a taxa de juros
Console.WriteLine("Informe a taxa de juros");
double taxa = Convert.ToDouble(Console.ReadLine());

// Indice
int indice = 1;

// Limpar o console
Console.Clear();

// Laco
do
{
    double ganhosNoMes = valor * (taxa / 100);

    valor += ganhosNoMes;

    Console.WriteLine(indice + " - {0:C2}", valor);
    indice++;
} while (indice <= periodo);