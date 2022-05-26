// Variavel para continuar o laco de repeticao
bool continuar = true;

// Laco
do
{
    // Tentativa para obter a nota
    try
    {

        // Obter a nota
        int nota = Convert.ToInt32(Console.ReadLine());

        // Condicional
        if (nota < 0 || nota > 10)
        {
            Console.WriteLine("A nota informada nao esta correta");
        }
        else
        {
            continuar = false;
        }

    }catch (Exception ex)
    {
        Console.WriteLine("Falha ao obter a nota: " + ex.Message);
    }

} while (continuar);