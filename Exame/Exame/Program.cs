string resposta;
int media;
int nota1;
int nota2;
int nota3;


Console.WriteLine("Bem vindo ao programa de media escolar");
Console.WriteLine("Esse é um programa que calcula a media de um aluno com base em suas notas");
Console.WriteLine("Deseja saber sua media?(s/n)");
resposta = Console.ReadLine().ToUpper();
if (resposta == "S")
{
    Console.WriteLine("Digite suas notas:");
    Console.WriteLine("levando em consideração que a primeira nota tem o peso de(3), a segunda(2) e a terceira(1)");
    nota1 = int.Parse(Console.ReadLine());
    nota2 = int.Parse(Console.ReadLine());
    nota3 = int.Parse(Console.ReadLine());
    media = (nota1 * 3 + nota2 * 2 + nota3 * 1) / 6;
    Console.WriteLine($"De acordo com suas notas sua media foi de {media}");
    if (media > 7)
    {
        Console.WriteLine("Você foi aprovado com uma otima media!");
    } 
    else if (media > 5)
    {
        Console.WriteLine("Você esta de recuperação, estude muito");
    }
    else
    {
        Console.WriteLine("Você foi reprovado");
    }
    
}
Console.WriteLine("Volte quando quiser usar o programa");