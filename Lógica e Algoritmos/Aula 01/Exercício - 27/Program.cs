// Mes e dia
int mes;
int dia;

// Obter o mes e o dia
Console.Write("Informe um dia");
dia = Convert.ToInt32(Console.Read());
Console.Write("Informe um mês");
mes = Convert.ToInt32(Console.Read());

// Retornar o signo
switch (mes)
{
    case 1:
        if (dia < 20)
        {
            Console.WriteLine("Capricornio");
        }
        else
        {
            Console.WriteLine("Aquario");
        }
    break;

    case 2:
        if (dia < 20)
        {
            Console.WriteLine("Aquario");
        }
        else
        {
            Console.WriteLine("Peixes");
        }
    break;

    case 3:
        if (dia < 20)
        {
            Console.WriteLine("Peixes");
        }
        else
        {
            Console.WriteLine("Aries");
        }
    break;

    case 4:
        if (dia < 20)
        {
            Console.WriteLine("Aries");
        }
        else
        {
            Console.WriteLine("Touro");
        }
    break;

    case 5:
        if (dia < 20)
        {
            Console.WriteLine("Touro");
        }
        else
        {
            Console.WriteLine("Gemeos");
        }
    break;

    case 6:
        if (dia < 20)
        {
            Console.WriteLine("Gemeos");
        }
        else
        {
            Console.WriteLine("Cancer");
        }
    break;
    case 7:
        if (dia < 20)
        {
            Console.WriteLine("Cancer");
        }
        else
        {
            Console.WriteLine("Leao");
        }
        break;

    case 8:
        if (dia < 20)
        {
            Console.WriteLine("Leao");
        }
        else
        {
            Console.WriteLine("Virgem");
        }
        break;

    case 9:
        if (dia < 20)
        {
            Console.WriteLine("Virgem");
        }
        else
        {
            Console.WriteLine("Libra");
        }
        break;

    case 10:
        if (dia < 20)
        {
            Console.WriteLine("Libra");
        }
        else
        {
            Console.WriteLine("Escorpiao");
        }
        break;

    case 11:
        if (dia < 20)
        {
            Console.WriteLine("Escorpiao");
        }
        else
        {
            Console.WriteLine("Sagitario");
        }
        break;

    case 12:
        if (dia < 20)
        {
            Console.WriteLine("Sagitario");
        }
        else
        {
            Console.WriteLine("Capricornio");
        }
        break;
}