// Produtos
string menu = "*** SELECIONE O PRODUTO ***\n";
       menu += "1) Arroz\n";
       menu += "2) Feijao\n";
       menu += "3) Trigo\n";
       menu += "4) Acucar\n";
       menu += "5) Macarrao\n";
       menu += "6) Lata de milho\n";
       menu += "7) Lata de ervilha\n";
       menu += "8) Finalizar";

// Produto selecionado
int produto = 0;

// Armazenar a quantidade comprada de cada produto
int arroz = 0, feijao = 0, trigo = 0, acucar = 0, macarrao = 0, lataMilha = 0, lataErvilha = 0;

// Laco
do
{
    // Obter o produto
    Console.WriteLine(menu);
    produto = Convert.ToInt32(Console.ReadLine());

    // Contador de produtos
    switch(produto)
    {
        case 1:
            arroz++;
        break;

        case 2:
            feijao++;
        break;
    }

    // Limpar console
    Console.Clear();
} while (produto != 8);

// Total
double total = (arroz * 18.70) + (feijao * 5.85);
Console.WriteLine("O total da compra e {0:C2}", total);
