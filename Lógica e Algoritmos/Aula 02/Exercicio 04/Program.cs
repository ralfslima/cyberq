// Obter um numero
Console.WriteLine("Informe um numero");
int numero = Convert.ToInt32(Console.ReadLine());

// Menor e maior
int menor = numero - 10;
int maior = numero + 10;

// Laco While
while(menor <= maior)
{
    Console.WriteLine(menor);
    menor++;
}

// Laco For
for(int n = numero - 10; n <= numero + 10; n++)
{
    Console.WriteLine(n);
}

