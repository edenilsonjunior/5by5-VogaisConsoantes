/*
 2- Faça um vetor de caracteres de 10 posicoes e imprima os seguintes itens:
	A) somente as vogais
	B) somente as consoantes
 */


Console.WriteLine("=====Vogais e Consoantes=====");

char[] letras = new char[10];
char[] vogais = new char[10];
char[] consoantes = new char[10];
int qntVogais = 0, qntConsoantes = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite a letra({i}): ");
    letras[i] = char.Parse(Console.ReadLine());
}


for (int i = 0; i < 10; i++)
{

    if (letras[i] == 'a' || letras[i] == 'e' || letras[i] == 'i' || letras[i] == 'o' || letras[i] == 'u')
    {
        vogais[qntVogais++] = letras[i];
    }
    else
    {
        consoantes[qntConsoantes++] = letras[i];
    }
}

Console.WriteLine("=============================");

if (qntVogais > 0)
{
    Console.WriteLine("Vogais:");

    for (int i = 0; i < qntVogais; i++)
    {
        Console.Write($"{vogais[i]} ");
    }
}

Console.WriteLine("\n=============================");

if (qntConsoantes > 0)
{
    Console.WriteLine("Consoantes:");

    for (int i = 0; i < qntConsoantes; i++)
    {
        Console.Write($"{consoantes[i]} ");
    }
}

Console.WriteLine("\n=============================");

Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();