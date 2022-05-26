// Continuar a executar o laco
int continuar = 0;

// Contadores
int alimenticio = 0;
int audio_video = 0;
int computador_notebook = 0;
int smartphone = 0;
int vestuario = 0;

// Somar valores dos produtos
double valor_alimenticio = 0;
double valor_audio_video = 0;
double valor_computador_notebook = 0;
double valor_smartphone = 0;
double valor_vestuario = 0;

// Laco
do
{
    // Obter o nome do produto
    Console.WriteLine("Informe o produto");
    string produto = Console.ReadLine();

    // Obter o segmento do produto
    Console.WriteLine("Informe o segmento do produto");
    Console.WriteLine("1) Alimenticio");
    Console.WriteLine("2) Áudio e Vídeo");
    Console.WriteLine("3) Computadores e Notebooks");
    Console.WriteLine("4) Smartphones");
    Console.WriteLine("5) Vestuario");
    int segmento = Convert.ToInt32(Console.ReadLine());

    // Obter o valor do produto
    Console.WriteLine("Informe o valor do produto");
    double valor = Convert.ToDouble(Console.ReadLine());

    // Contabilizar segmento
    switch (segmento)
    {
        case 1: 
            alimenticio++; 
            valor_alimenticio += valor; 
        break;

        case 2: 
            audio_video++; 
            valor_audio_video += valor; 
        break;

        case 3: 
            computador_notebook++; 
            valor_computador_notebook += valor; 
        break;

        case 4: 
            smartphone++; 
            valor_smartphone += valor; 
        break;

        case 5: 
            vestuario++; 
            valor_vestuario += valor; 
        break;
    }

    

    // Limpar tela
    Console.Clear();

    // Continuar o laco
    Console.WriteLine("Desejar continuar a cadastrar?");
    Console.WriteLine("1) SIM");
    Console.WriteLine("2) NAO");
    continuar = Convert.ToInt32(Console.ReadLine());
} while (continuar != 2);

// Exibir a quantidade de produtos cadastrados
Console.WriteLine("Quantidade de produtos cadastrados: " + (alimenticio+audio_video+computador_notebook+smartphone+vestuario));

// Exibir a quantidade por segmento
Console.WriteLine("Alimenticio: " + alimenticio);
Console.WriteLine("Audio e Video: " + audio_video);
Console.WriteLine("Computadores e Notebooks: " + computador_notebook);
Console.WriteLine("Smartphones: " + smartphone);
Console.WriteLine("Vestuario: " + vestuario);

// Exibir a media de valores por segmento
if(alimenticio > 0)
{
    Console.WriteLine("Alimenticio: " + (valor_alimenticio / alimenticio));
}
else
{
    Console.WriteLine("Nao foi adicionando nenhum produto alimenticio");
}

Console.WriteLine("Audio e Video: " + (valor_audio_video / audio_video));
Console.WriteLine("Computadores e Notebooks: " + (valor_computador_notebook / computador_notebook));
Console.WriteLine("Smartphones: " + (valor_smartphone / smartphone));
Console.WriteLine("Vestuario: " + (valor_vestuario / vestuario));