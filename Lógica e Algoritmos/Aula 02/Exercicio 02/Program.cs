// Variavel para obter um numero
int numero = -1;

// Variavel para somar os valores informados
int soma = 0;

// Laco
while(numero != 0)
{ 
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
}

// Exibir a soma
Console.WriteLine("A soma dos valores e: "+soma);

