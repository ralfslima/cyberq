// Variavel contendo uma cidade
string cidade = "Blumenau";

// Estrutura de escolha
switch(cidade)
{
    case "Blumenau":
        Console.WriteLine("Cidade onde e realizada a Oktoberfest");
    break;    
    
    case "Florianopolis":
        Console.WriteLine("Capital do estado");
    break;

    default:
        Console.WriteLine("Cidade nao encontrada");
    break;
}