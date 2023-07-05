// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string>();
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Cane Hill"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"


░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaDeUmaBanda();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void ExibirMediaDeUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média da banda");
    Console.Write("Digite o nome da banda que você deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        double mediaDaBanda = bandasRegistradas[nomeDaBanda].Average();
        // List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é igual a: {mediaDaBanda}.");
        Console.WriteLine($"\nDigite uma tecla para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        //Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada!");
        //Console.WriteLine("Digite uma tecla para voltar ao menu principal...");
        //Console.ReadKey();
        //Console.Clear();
        //ExibirOpcoesDoMenu();
        BandaNaoEncontrada(nomeDaBanda);
    }
}

void AvaliarUmaBanda()
{
    // Digite qual banda deseja avaliar
    // Se a banda existir no dicionário -> atribuir uma nota
    // Se a banda não existir volta para o menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        //Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        //Console.WriteLine("Digite uma tecla para voltar ao menu principal...");
        //Console.ReadKey();
        //Console.Clear();
        //ExibirOpcoesDoMenu();
        BandaNaoEncontrada(nomeDaBanda);
    }
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //listaDasBandas.Add(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000); //esperar 2 milissegundos
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void BandaNaoEncontrada(string nomeDaBanda)
{
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();