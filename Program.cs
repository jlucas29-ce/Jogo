using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading; 
using SistemaBatalha;

class Program
{   string? escolha2, escolha1, escolha, escolha3,escolha4;
    string? personagem;
static void Main(string[] args)
    {
        bool jogar = true;

        while (jogar)
        {
            Console.Clear();
            Console.WriteLine("Crônica do Orangotango Kerchek: A busca pela cura das varíolas dos orangotangos");
            Console.WriteLine("1 - Iniciar");
            Console.WriteLine("2 - Introdução");
            Console.WriteLine("3 - Desenvolvedores");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    IniciarJogo();
                    break;
                case "2":
                    jogar = false;
                    Console.Clear();
                    MostrarDialogo2("Introdução \n Em uma floresta exuberante e cheia de vida, uma aldeia habitada por orangotangos. Entre eles, havia um orangotango especial chamado Kershek. Ele era um capoeirista nato, conhecido por sua habilidade e graça nos movimentos da capoeira. Mas Kershek guardava um segredo: ele dominava a arte proibida da capoeira, um estilo que poucos conheciam e que era considerado sagrado pelos anciões da aldeia. \n Kershek vivia em harmonia com sua comunidade, onde todos os orangotangos se reuniam para praticar a capoeira como uma forma de expressão e diversão. No entanto, a arte que Kershek dominava era diferente; ela tinha o poder de proteger e bater, mas também poderia ser perigosa se utilizada de maneira errada.Certa manhã, enquanto o sol filtrava suas luzes através das copas das árvores, Kershek recebeu uma notícia alarmante: sua irmã, Kelly kershek, estava gravemente doente. \n A varíola dos orangotangos havia se espalhado pela aldeia, e Kelly kershek era uma das vítimas. Desesperado, Kershek sabia que precisava agir rapidamente. Ele ouviu rumores sobre uma cura mágica que estava escondida em uma dungeon perdida na floresta, um lugar repleto de perigos e desafios.");
                    Main(args);
                    break;
                    case "3":
                    jogar = false;
                    Console.Clear();
                    MostrarDialogo2("Desenvolvedores \n 1 - João Lucas Saraiva Farias \n 2 - João Henry Brito Cavalcante \n 3 - Brenda Kelly Tavares de Lima \n 4 - Ana Vitória Oliveira Sena \n 5 - Pedro Ìcaro Lima da Fontoura \n 6 - Jardel Moreira");
                    Main(args);
                    break;
                    case "4":
                    jogar = false;
                    Console.WriteLine("Saindo do jogo...");
                    break;
                    default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void IniciarJogo()
    {
        string personagem = "";
        Console.Clear();

       
      personagem = EscolherPersonagem();

        Console.Clear();
      
        MostrarDialogo($"Mago maneiro- \nOlá... {personagem} Kershek");
        Console.Clear();
        
        MostrarDialogo($"Mago maneiro-\n 'Bem-vindo {personagem} Kershek ao mundo dos orangotangos.");

    

        Console.Clear();
        MostrarDialogo($"Mago maneiro-\n'Estou sem meus poderes para conseguir ajudar todo o povoado e sua irmã (Kelly Kershek) precisa de ajuda.'");
        
        Console.Clear();

        MostrarDialogo("Mago meneiro- \n 'Preciso que você vá e encontre a cura e traga para mim, assim podemos ajudar a todos!!'");

       
        if (EscolherDesafio())
        {   
            Console.Clear();
            MostrarDialogo("Mago meneiro- \n 'Ótimo.. confio na sua coragem! Use suas habilidades da capoeira proibida para fazer tudo melhorar mais uma vez!!'");
            Console.Clear();

            MostrarDialogo("*Local: Montanhas\n Mago maneiro\n 'KERSHEK KERSHEK....A  SUA ALDEIA EM APUROS!!!!!!!' ");
            Console.Clear();

            MostrarDialogo("Kershek-\n'calma mago, não estou entendendo me explique mais calmamente'");
            Console.Clear();
            
            MostrarDialogo("Mago maneiro-\n 'KERSHEK!! A ALDEIA ESTÁ FICANDO INFESTADA, A DOENÇA ESTÁ SE EXPANDINDO RAPIDAMETE!! SUA IRMÃ ESTÁ INFECTADA, PRECISANDO DE AJUDA! '");
            Console.Clear();
            
            MostrarDialogo("Kershek começa entrar em desespero........");
            Console.Clear();

            MostrarDialogo ("Kershek- \n MEU DEUS!! MINHA IRMÃ!! EU PRECISO SALVA-LÁ...... NÃO..... EU TENHO QUE SALVAR TODOS");
            Console.Clear(); 

            PrimeiraFase();
           

        }
       
        else
        {
            Console.WriteLine("Voltando ao menu inicial...");
            Console.ReadKey();
        }
        if(PrimeiraFase()){
            MostrarDialogo(" Kershek ao lado de mago maneiro se juntam e vao a vila....... chegando la...");
            Console.Clear();
            
                Console.Write("1 - Conversar com o ancião da aldeia \n 2 -  Praticar capoeira com os amigos \n 3 - Visitar sua irmã Kelly");
                Console.Write("\nDigite o número da sua escolha: ");
                string? escolha2 = Console.ReadLine(); 
                SegundaFase(escolha2,personagem);
        }
        
        
    }

    static string EscolherPersonagem()
    {       string? personagem;

            Console.Clear();
            Console.WriteLine("Informe o nome do seu personagem:");
            personagem = Console.ReadLine();
        
            return personagem;
    }

    static bool EscolherDesafio()
    {
        bool escolhaValida = false;
        while (!escolhaValida)
        {
            Console.Clear();
            Console.WriteLine("Você deseja enfrentar o desafio?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Digite o número da sua escolha: ");
            string? escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    return true;
                case "2":
                    return false;
                default:
                    Console.WriteLine("Escolha inválida! Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }
        return false;
    }


    static void MostrarDialogo(string mensagem)
    {
        foreach (char c in mensagem)
        {
            Console.Write(c);
            Thread.Sleep(25); 
        }
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
    }
    static bool PrimeiraFase()
    {
       bool escolhaValida = false;
        while (!escolhaValida)
        {
            Console.Clear();
           Console.WriteLine("DECISÃO:\n 1. KERSHEK DEVE IR A ALDEIA \n OU \n 2. KERSHEK DEVE IR EM BUSCA DA CURA");
            Console.Write("Digite o número da sua escolha: ");
            string? escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    return true;
                case "2":
                MostrarDialogo2("kershek decide ir em busca sozinho.... determinado a salvar sua irma e age em desespero e vai sem avisar ao mago assim se perdendo....");
                    return false;
                default:
                    Console.WriteLine("Escolha inválida! Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }
        return true;
    }
     static void MostrarDialogo2(string mensagem)
    {
        foreach (char c in mensagem)
        {
            Console.Write(c);
            Thread.Sleep(15); 
        }
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer para retornar ao menu inicial...");
        Console.ReadKey(true);
    }
    static bool SegundaFase(string escolha2,string personagem)
    {
        bool escolhaValida = false;
        while (!escolhaValida)
        {
            Console.Clear();
          
            switch (escolha2)
            {
                case "1":
                Console.Clear();
                
                MostrarDialogo("(ancião)\n 'olá kershek, sei que estava nas montanhas.... acabou ocorrendo umas coisas enquanto você estava fora...'");
                Console.Clear();
                
                MostrarDialogo($"{personagem} Kershek\n 'ANCIÃO POR FAVOR ME EXPLIQUE A SITUALÇÃO!!!'");
                Console.Clear();
                
                MostrarDialogo("(ancião)\n  A varíola dos orangotangos é uma doença mágica rara que se originou de uma poderosa maga chamada Mariaaziatica. Conhecida por suas habilidades em manipular a natureza e as forças mágicas da floresta, Mariaaziatica era uma guardiã do equilíbrio entre os seres mágicos e a fauna local.........\nCerta vez, em um momento de desespero, Mariaaziatica lançou um feitiço para proteger a floresta de invasores. No entanto, o feitiço saiu errado e resultou na criação de uma praga que afetou os orangotangos da aldeia próxima. A doença se espalhou rapidamente entre eles, causando erupções na pele e fraqueza extrema......... \npor favor vá visitar sua irmã.... direi o resto ao mago.");
                RetornarEscolha(escolha2, personagem);
                    return true;

                case "2":
                Console.Clear();
                
                MostrarDialogo("Durante a prática, Kershek pode auxilios dicas de seus amigos sobre como usar melhor suas habilidades até ele aperfeiçoar a a técnica tradicional da vila. A Ginga da Selva é uma habilidade especial de capoeira desenvolvida pelos orangotangos durante anos de treinamento nas florestas vibrantes.\n Essa técnica combina agilidade, ritmo e a conexão com os elementos naturais ao redor, permitindo que os orangotangos se movam com graça e eficácia em combate ou em situações de evasão. recebe um buff de 10% no ataque");
                RetornarEscolha(escolha2, personagem);
                return true;

                

                case "3":
                Console.Clear();
                
                MostrarDialogo("Ao visitar Kelly, Kershek fica denso e nervoso por causa da situação da irmã...");
                Console.Clear();
            
                MostrarDialogo($"{personagem} kershek \n 'Ola minha irmã, tudo bem com vc, fale pra mim, sou eu kershek, vir te visitar...' ");
                Console.Clear();
                
                MostrarDialogo("(Kelly) \n 'Irmão..... Por favor......me salve........ Me ajude... '\n Kelly desmaia......\n");
                Console.Clear();
                
                MostrarDialogo("Kershek  com uma determinação monstruosa, promete a situação mesmo");
                Console.Clear();
                
                MostrarDialogo($"{personagem} Kershek \n EU O ORANGOTANGO KERSHEK, IREI SALVA-LÁ MINHA IRMÃ MAS NÃO SÓ VOCÊ MAS TAMBÉM A VILA TODA EM NOME DA FORÇA DA CAPOEIRA.......,");
                Console.Clear();
                
                MostrarDialogo("APÓS ISSO.....");
                Console.Clear();
                
                
                MostrarDialogo($"Médicos chegam e vão cuidar de sua irma, {personagem} Kershek esta determinado, com sangue nos olhos vai atrás de mago maneiro.......");
                Console.Clear();

                MostrarDialogo($"-{personagem} Kershek\n 'mago! Mago! Mago!'\n -Mago maneiro\n  fale {personagem}, o que aconteceu?\n Kershek\n 'minha irma desmaiou, precisamos não salvar só ela e sim a vila toda!!! Temos que usar aquilo que você me ensinou....... A CAPOEIRA PROBIDA' ");
                Console.Clear();

                MostrarDialogo("-Mago maneiro \n 'não creio nisso, kershek você vai usar arte da capoeira proibida.......'\n Kershek)\n isso mesmo a arte da capoeira proibida..... mago.... precisamos salvar a nossa aldeia!!!!! Estou determinado a explorar o mais perveso mundo, o mais perigoso, para salvar todos, minha irma merece um futuro, todos merecem..... por favor mago, como podemos ajudar?  ");
                Console.Clear();

                MostrarDialogo("-Mago maneiro\n 'falei com o ancião e ele me disse tudo sobre a doença e descobri onde podemos encontrar a cura..... mas não sera nada fácil, iremos passar dificieis situações que podemos até mesmo morrer..... você esta disposto a fazer isso?'");
                Console.Clear();
                
                Console.WriteLine("DECISÃO:\n 1 - SIM \n 2 - NÃO");
                Console.Write("A sua decisão é: ");
                string? escolha3 = Console.ReadLine();
                TerceiraFase(escolha3,personagem);   

                return true;

                default:
                    MostrarDialogo2("Você Perdeu!!");
                    
                    break;
            }
        }
        return true;
    }
    static void RetornarEscolha(string escolha2, string personagem)
    {
        Console.Write("1 - Conversar com o ancião da aldeia\n 2 -  Praticar capoeira com os amigos \n 3 - Explorar o mercado da aldeia \n 4 - Visitar sua irmã Kelly");
        Console.Write("Digite o número da sua escolha: ");
        SegundaFase(escolha2,personagem);
        }
        static bool TerceiraFase(string escolha3,string personagem)
    {
        bool escolhaValida = false;
        while (!escolhaValida)
        {
            Console.Clear();
             
          
            switch (escolha3)
            {
                case "1":
                 MostrarDialogo($"{personagem} kershek \n sim mago,  estou dispoto a tudo!!!!! Prometo que morro em nome da nossa aldeia eu quero que todos estejam bem vivos e consigam viver feliz e praticar a nossa capoeira.....");
                 Console.Clear();
                 
                MostrarDialogo("(mago maneiro) \n bem irei te explicar onde vamos achar a cura......");
                Console.Clear();
                
                MostrarDialogo("(mago maneiro)\n se você escutou o que o ancião disse, a doença veio acidentalmente da bruxa mariaaziatica, devemos entrar na floresta e entrar na dungeon e encontrolar o ALTAR DA CURA que é onde ela vive.... fiquei sabendo que tem caçadores a procura dela também, não estou sabendo que eles querem mas sei que não é coisa boa!!....");
                Console.Clear();
    
                Console.WriteLine("Após essa conversa mago maneiro e o kershek vao atrás de onde onde bruxa vive, assim começando uma caminhada, até chegar na floresta...");
                Console.Clear();
                
                MostrarDialogo("Local: Montanhas\n Mago maneiro e kershek chegam na floresta.....");
                Console.Clear();

                MostrarDialogo("Eles veem um rio e um caminho pelas as arvores, kershek e mago ficam confusos por dentro daquela floresta também a ver umas coisas que parecem obstáculos....");
                Console.Clear();

                string? escolha4 = Console.ReadLine();
                QuartaFase(escolha4,personagem);

                    return true;

                case "2":
                MostrarDialogo2("Você Perdeu!!");
                return true;


                default:
                    Console.WriteLine("Escolha inválida! Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }
        return true;
    }
     static bool QuartaFase(string escolha4,string personagem)
    {
        bool escolhaValida = false;
        while (!escolhaValida)
        {
            Console.Clear();
              Console.WriteLine("DECISÃO:\n 1 - Seguir o rio\n OU\n 2 - Seguir caminho das árvores");
                Console.Write("A sua decisão é: ");
                escolha4 = Console.ReadLine();
          
            switch (escolha4)
            {
                case "1":
                 Console.WriteLine("Kershek pode encontrar mais animais e talvez até algum deles tenha informações sobre a dungeon. ");
                MostrarDialogo("Em determinado ponto, Kershek se deparou com uma bifurcação na trilha. À esquerda, a trilha era estreita e escura, rodeada por árvores retorcidas e espinhosas. À direita, a trilha era mais ampla e iluminada, com flores coloridas e um leve perfume adocicado no ar.");
                MostrarDialogo("Continuar?");
                Console.Write("DECISÃO:\n1- Sim\n ou\n2 - não(caso não ele tomará a decisão de seguir o caminho das arvorés)");
                string? escolha5 = Console.ReadLine();
                if(escolha5 == "2"){
                    return false; 
                }
                    return true;

                case "2":
                Batalha.IniciarLabirinto();
                MostrarDialogo("Ao seguir o caminho do rio Kershek encontra uma família de macacos brincando. Eles parecem amigáveis e podem ter informações úteis. No entanto, ele também percebe que o tempo está passando e que precisa ser rápido.......");
                MostrarDialogo("Conversando com os macacos-\n nós, os bravos macacos aventureiros, ouviram rumores de uma antiga e misteriosa dungeon escondida nas profundezas da Área dos Pinheiros. Dizem que lá dentro, há uma duengon que é cheio de desafios épicos que só os mais fortes e inteligentes podem superar.Para chegar lá você tem que ouvir seus sentidos.... ");
                Console.WriteLine("Decisão: \nUsar a capoeira para atravessar um obstáculo\n ou \nprocurar uma passagem alternativa?");
                 Console.Write("A sua decisão é: ");
                return true;

                default:
                    Console.WriteLine("Escolha inválida! Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }
        return true;
    }
     static bool QuintaFase(string escolha4,string personagem)
    {
        bool escolhaValida = false;
        while (!escolhaValida)
        {
            Console.Clear();
             
          
            switch (escolha4)
            {
                case "1":
                 
                
                    return true;

                case "2":
                
                return true;

                default:
                    Console.WriteLine("Escolha inválida! Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }
        return true;
    }
    
}

















namespace SistemaBatalha
{
    public class Batalha
    {
        public static void IniciarLabirinto()
        {
           
            string[,] labirinto = new string[10, 21]
            {
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
                {"#","#","#","#","#"," "," "," "," "," "," "," "," "," "," "," ","#","#","#","#","#"},
                {" "," ","#","#","#"," ","#","#","#","#","#","#","#","#","#"," ","#","#","#","#","#"},
                {"#"," "," ","#","#"," ","#","#","#","#","#","#","#","#","#"," ","#","#","#","#","#"},
                {"#","#"," "," "," "," ","#","#","#","#","#","#","#","#","#"," ","#","#","#","#","#"},
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"," ","#","#","#","#","#"},
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"," "," "," "," ","#","#"},
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"," ","#","#"},
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"," ","#","#"},
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"," "," ","end"},
            };
            string jogador = "°";
            int posLinha = 2;
            int posColuna = 1;

            bool fimDeJogo = false;
            labirinto[posLinha, posColuna] = jogador;

            while (!fimDeJogo)
            {
                Console.Clear();
                //A linha
                for (int linha = 0; linha < 10; linha++)
                {
                    for (int coluna = 0; coluna < 21; coluna++)
                    {
                        Console.Write(labirinto[linha, coluna]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n\nPara onde você deseja ir?");
                Console.WriteLine("> W = Cima");
                Console.WriteLine("> A = Esquerda");
                Console.WriteLine("> S = Baixo");
                Console.WriteLine("> D = Direita");
                Console.WriteLine();
                Console.Write("Meu Comando é: ");

                string? comando = Console.ReadLine().ToUpper();

                //as intruções if e else
                if (comando == "W")
                {
                    if (labirinto[posLinha - 1, posColuna] != "#")
                    {
                        labirinto[posLinha, posColuna] = " ";
                        posLinha--;
                    }
                }
                else if (comando == "A")
                {
                    if (labirinto[posLinha, posColuna - 1] != "#")
                    {
                        labirinto[posLinha, posColuna] = " ";
                        posColuna--;
                    }
                }
                else if (comando == "S")
                {
                    if (labirinto[posLinha + 1, posColuna] != "#")
                    {
                        labirinto[posLinha, posColuna] = " ";
                        posLinha++;
                    }
                }
                else if (comando == "D")
                {
                    if (labirinto[posLinha, posColuna + 1] != "#")
                    {
                        labirinto[posLinha, posColuna] = " ";
                        posColuna++;
                    }
                }
                else
                {
                    Console.WriteLine("Comando inválido! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                }

                labirinto[posLinha, posColuna] = jogador;

                if (posLinha == 9 && posColuna == 19) // Ajuste conforme a posição final
                    fimDeJogo = true;
            }
            Console.Clear();
            Console.WriteLine("PARABÉNS!!! VOCÊ CONSEGUIU PASSAR DO CAMINHO DAS ÁRVORES");
            Console.ReadKey();
        }
    }
}