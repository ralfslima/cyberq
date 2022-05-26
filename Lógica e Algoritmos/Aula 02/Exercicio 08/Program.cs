// Contadores
int acertos = 0, erros = 0;

// Laco
while(acertos < 7 && erros < 7)
{
    // Limpar console
    Console.Clear();

    // Exibir contadores
    Console.WriteLine("Acertos: " + acertos);
    Console.WriteLine("Erros: " + erros);
    Console.WriteLine("-------------------");

    // Obter a letra
    Console.WriteLine("Informe uma letra");
    string letra = Console.ReadLine();

    // Condicional
    if(letra == "e" || letra == "s" || letra == "t" || letra == "u" || letra == "d" || letra == "a" || letra == "r")
    {
        acertos++;
    }
    else
    {
        erros++;
    }

}
