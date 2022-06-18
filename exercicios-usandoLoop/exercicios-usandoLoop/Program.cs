//Exercícios usando WHILE

Console.WriteLine("EXERCÍCIOS USANDO WHILE");

//Exercício 1 - Senha correta


const int senhaCorreta = 2002;
Console.WriteLine("Digite a senha :");
int senhaDigitada = int.Parse(Console.ReadLine());

while(senhaDigitada != 2002)
{
    Console.WriteLine("Senha inválida, digite outra senha: ");
    senhaDigitada = int.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso permitido.");

Console.WriteLine("----------------------");
//Exercício 2 - posto de gasolina

int i = 0;
int contadorAlcool = 0;
int contadorGasolina = 0;
int contadorDiesel = 0;

while (i < 1)
{
    Console.WriteLine($"Digite a opção que você deseja: " + Environment.NewLine +
        $"1 - Abastecer álcool" + Environment.NewLine +
        $"2 - Abastacer gasolina" + Environment.NewLine +
        $"3 - Abastecer diesel" + Environment.NewLine +
        $"4 - Fim");

    int opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        contadorAlcool++;
    }
    else if (opcao == 2)
    {
        contadorGasolina++;
    }

    else if (opcao == 3)
    {
        contadorDiesel++;
    }
    else if (opcao == 4)
    {
        i = 1;
        Console.WriteLine("Muito obrigado por utilizar nossos serviços !");
    }
    else
    {
        Console.WriteLine("Digite uma opção válida. ");
    }
}

Console.WriteLine($"{contadorAlcool} pessoas abasteceram álcool" + Environment.NewLine +
     $"{contadorGasolina} pessoas abasteceram gasolina" + Environment.NewLine +
     $"{contadorDiesel} pessoas abasteceram diesel ");


Console.WriteLine("----------------------");
Console.WriteLine("Exercícios usando FOR");

//Exercício 3 - Digite um número e mostra todos ímpares do intervalo.



Console.WriteLine("Digite o número que você quer: ");
int numeroDigitado = int.Parse(Console.ReadLine());
for (int x = 1; x < numeroDigitado; x++)
{
    if(x %2 != 0)
    {
        Console.WriteLine(x);
    }

}

//Exercício 4 - Quantidade de valores dentro e fora do intervalo

int contadorIn = 0;
int contadorOut = 0;
Console.WriteLine("Com quantos valores deseja entrar? ");
int valores = int.Parse(Console.ReadLine());

for(int n = 0; n <valores; n++)
{
    Console.WriteLine($"Digite o {n + 1} valor: ");
    int valor = (int.Parse(Console.ReadLine()));

    if(valor >= 10 && valor<= 20)
    {
        contadorIn++;
        Console.WriteLine($"{contadorIn} in ");
    }
    else
    {
        contadorOut++;
        Console.WriteLine($"{contadorOut} out");
    }
}
