Console.WriteLine("Esse é o programa de tabuada");
Console.WriteLine("nesse programa você escolhe qual serà o primeiro e o ultimo valor da tabuada");
Console.WriteLine("Deseja usar o programa?(s/n)");
string resposta = Console.ReadLine().ToUpper();
if (resposta == "S")
{
    Console.Write("Digite o primeiro número (Start): ");
    int start = int.Parse(Console.ReadLine());

    Console.Write("Digite o número final (End): ");
    int end = int.Parse(Console.ReadLine());

    for (int i = start; i <= end; i++)
    {
        Console.WriteLine($"Tabuada do {i}:");

        for (int j = 1; j <= 10; j++)
        {
            int resultado = i * j;
            Console.WriteLine($"{i} x {j} = {resultado}");
        }
    }
}
Console.WriteLine("Volte quando quiser usar o programa!");


