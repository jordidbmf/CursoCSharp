#region Desafio jogo número aleatório
//Random aleatorio = new Random();
//int numeroSecreto = aleatorio.Next(1, 101);

//do
//{
//    Console.Write("Digite um número entre 1 e 100: ");
//    int chute = int.Parse(Console.ReadLine()!);

//    if (chute == numeroSecreto)
//    {
//        Console.WriteLine("Parabéns! Você acertou o número.");
//        break;
//    }
//    else if (chute < numeroSecreto)
//    {
//        Console.WriteLine("O número é maior.");
//    }
//    else
//    {
//        Console.WriteLine("O número é menor.");
//    }

//} while (true);

//Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
#endregion

#region Desafio for e foreach
//List<int> listaDeNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//for(int i = 0; i < listaDeNumeros.Count; i++)
//{
//    if (listaDeNumeros[i] % 2 == 0)
//    {
//        Console.WriteLine($"Número = {listaDeNumeros[i]}");
//    }
//}

//foreach (int numeros in listaDeNumeros)
//{
//    if (numeros % 2 == 0)
//    {
//        Console.WriteLine($"Número = {numeros}");
//    }

//}
#endregion

#region média de vendas de carros
//Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
//    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
//    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
//    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
//    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
//    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
//};

//void MediaDeVendas()
//{
//    Console.Write($"Digite o carro que você deseja consultar: ");
//    string carro = Console.ReadLine()!;
//    if (vendasCarros.ContainsKey(carro))
//    {
//        double mediaVendas = vendasCarros[carro].Average();
//        Console.WriteLine($"A média de vendas do carro {carro} é: {mediaVendas}");
//    }
//    else
//    {
//        Console.WriteLine($"O carro {carro} não existe na base de dados!");
//    }
//}

//MediaDeVendas();

#endregion