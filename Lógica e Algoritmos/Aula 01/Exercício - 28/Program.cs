// Variavel
double distancia;
int tipo;

// Obter dados
Console.Write("Informe uma distancia: ");
distancia = Convert.ToDouble(Console.ReadLine());

Console.Write("1) Metros para Quilometros | 2) Quilometros para Metros");
tipo = Convert.ToInt32(Console.ReadLine());

// Condicional
if(tipo == 1)
{
    Console.WriteLine(distancia / 1000);
}
else
{
    Console.WriteLine(distancia * 1000);
}