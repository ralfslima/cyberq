// Menu de candidatos
string menu = "*** ESCOLHA UM DOS CANDIDATOS ***\n";
       menu += "1) Joao\n";
       menu += "2) Maria\n";
       menu += "3) Isabella\n";
       menu += "4) Finalizar votacao";

// Contadores
int joao = 0, maria = 0, isabella = 0;

// Variavel voto
int voto = 0;

// Laco
do
{
    // Obter o voto
    Console.WriteLine(menu);
    voto = Convert.ToInt32(Console.ReadLine());

    // Contabilizar votos
    switch(voto)
    {
        case 1:
            joao++;
        break;
        
        case 2:
            maria++;
        break;
        
        case 3:
            isabella++;
        break;
    }

    // Limpar o console
    Console.Clear();
} while (voto != 4);

// Exibir votos
Console.WriteLine("Joao obteve: " + joao + " votos.");
Console.WriteLine("Maria obteve: " + maria + " votos.");
Console.WriteLine("Isabella obteve: " + isabella + " votos.");