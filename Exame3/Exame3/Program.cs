static void Main()
{
    int A = 0, b = 0, c = 0, nulo = 0;

    while (true)
    {
        Console.WriteLine("Insira seu voto (1=A, 2=B, 3=C, 9=Nulo, 0=Encerrar):");
        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 0)
            break;

        switch (escolha)
        {
            case 1: A++; break;
            case 2: b++; break;
            case 3: c++; break;
            case 9: nulo++; break;
            default: Console.WriteLine("Voto inválido!"); break;
        }


        Console.WriteLine($"\nA: {A} | B: {b} | C: {c} | Nulos: {nulo}");


        var key = Console.ReadKey();
        Console.WriteLine("\n");

        if (key.Key == ConsoleKey.D0)
            break;

    }
}