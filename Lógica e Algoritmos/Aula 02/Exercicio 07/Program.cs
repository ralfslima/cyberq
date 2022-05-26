// Numero
int numero = Convert.ToInt32(Console.ReadLine());

// Antecessor
int antecessor = numero - 1;

// Valor
int valor = 0;

// Laco
do
{
    
    if(antecessor == numero - 1)
    {
        valor = numero * antecessor;
        Console.WriteLine(numero + " X " + antecessor + " = "+valor);
    }
    else
    {
        Console.WriteLine(valor + " X " + antecessor + " = " + (valor * antecessor));
        valor = valor * antecessor;
    }

    antecessor--;

}while (antecessor >= 1);