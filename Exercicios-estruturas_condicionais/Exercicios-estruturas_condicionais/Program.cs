using System;
using System.Globalization;

//Verificação positivo-negativo

Console.WriteLine("Digite um número inteiro para a verificação: ");
int numero = int.Parse(Console.ReadLine());

if (numero >= 0)
{
    Console.WriteLine("O número é positivo");
}

else
{
    Console.WriteLine("O número é negativo");
}

Console.WriteLine("--------------------");

//Verificação ímpar ou par

Console.WriteLine("Digite o número inteiro para verificação de par-impar : ");
int numero2 = int.Parse(Console.ReadLine());

if (numero2 % 2 == 0)
{
    Console.WriteLine("Par");
}

else
{
    Console.WriteLine("Impar");
}

Console.WriteLine("--------------------");

//Verificação se são múltiplos

Console.WriteLine("Digite os dois números para verificar se são múltiplos: ");
string[] numerosMultiplos = Console.ReadLine().Split(' ');

int n1 = int.Parse(numerosMultiplos[0]);
int n2 = int.Parse(numerosMultiplos[1]);

if (n1 % n2 == 0 || n2 % n1 == 0)
{
    Console.WriteLine("São múltiplos! ");
}
else
{
    Console.WriteLine("Não são múltiplos. ");

}

Console.WriteLine("--------------------");

//Duração de um jogo

Console.WriteLine("Digite a hora que iniciou e a hora que terminou o jogo: ");
string[] horariosJogo = Console.ReadLine().Split(' ');

int horarioInicial = int.Parse(horariosJogo[0]);
int horarioFinal = int.Parse(horariosJogo[1]);

if (horarioInicial > horarioFinal)
{
    Console.WriteLine($"O jogo durou {(24 - horarioInicial) + horarioFinal}");
}
else
{
    Console.WriteLine($"O jogo durou {horarioFinal - horarioInicial} horas");

}


Console.WriteLine("--------------------");

//Lanchonete
Console.WriteLine("Digite a opção que você quer e a quantidade.");
Console.WriteLine($"Cardápio: " + Environment.NewLine +
    $"CÓDIGO - ESPECIFICAÇÃO - PREÇO" + Environment.NewLine +
    $"1 - Cachorro quente - R$ 4.00" + Environment.NewLine +
    $"2 - X-Salada - R$ 4.50" + Environment.NewLine +
    $"3 - X-Bacon - R$ 5.00" + Environment.NewLine +
    $"4 - Torrada simples - R$ 2.00" + Environment.NewLine +
    $"5 - Refrigerante - R$ 1.50" + Environment.NewLine);
string[] opcao = Console.ReadLine().Split(' ');

int opcaoCodigo = int.Parse(opcao[0]);
int quantidade = int.Parse(opcao[1]);
switch (opcaoCodigo)
{
    case 1:
        Console.WriteLine($"Você escolheu cachorro quente, e o preço total é: R$ {quantidade * 4} ");
        break;
    case 2:
        Console.WriteLine($"Você escolheu X-Salada, e o preço total é: R$ {quantidade * 4.50} ");
        break;
    case 3:
        Console.WriteLine($"Você escolheu X-Bacon, e o preço total é: R$ {quantidade * 5} ");
        break;
    case 4:
        Console.WriteLine($"Você escolheu Torrada simples, e o preço total é: R$ {quantidade * 2} ");
        break;
    case 5:
        Console.WriteLine($"Você escolheu Refrigerante, e o preço total é: R$ {quantidade * 1.50} ");
        break;
    default:
        Console.WriteLine("Digite uma opção válida.");
        break;
}

