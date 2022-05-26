// Continuar o laco
bool continuar = true;

// Nomes
string nome1 = "";
string nome2 = "";
string nome3 = "";

// Laco
while (continuar == true)
{
    Console.WriteLine("Informe um nome");
    string nome = Console.ReadLine();

    if (nome1 == "")
    {
        nome1 = nome;
    }
    else if (nome2 == "" && nome != nome1)
    {
        nome2 = nome;
    }
    else if(nome3 == "" && nome != nome1 && nome != nome2)
    {
        nome3 = nome;
        continuar = false;
    }

}

// Exibir nomes
Console.WriteLine(nome1);
Console.WriteLine(nome2);
Console.WriteLine(nome3);
