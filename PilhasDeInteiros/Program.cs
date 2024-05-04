namespace PilhasDeInteiros;

internal class Program
{
    private static void Main(string[] args)
    {
        //VARIAVEIS GLOBAIS
        PilhaNumero pilha1 = new PilhaNumero();
        PilhaNumero pilha2 = new PilhaNumero();


        //FUNCOES
        void AdicionarNumeros()
        {
            Console.WriteLine("Em qual pilha deseja adicionar?\n" +
                "1 - Pilha 1;\n" +
                "2 - Pilha 2;\n" +
                "0 - Voltar.");
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    PopularPilha(pilha1);
                    break;
                case 2:
                    PopularPilha(pilha2);
                    break;
                default:
                    break;
            }
        }

        void PopularPilha(PilhaNumero pilha)
        {
            int num;
            do
            {
                Console.Write("Informe o numero que deseja adicionar, ou digite 0 para voltar:");
                num = int.Parse(Console.ReadLine());
                if (num != 0) pilha.Push(new Numero(num));
            } while (num != 0);
        }

        void TamanhoPilha()
        {
            if (pilha1.QtdNumeros == pilha2.QtdNumeros)
                Console.WriteLine($"As pilhas tem o mesmo tamanho: {pilha1.QtdNumeros}");
            else
            {
                if (pilha1.QtdNumeros > pilha2.QtdNumeros)
                    Console.WriteLine($"A pilha 1 tem {pilha1.QtdNumeros} numeros e a pilha 2 tem {pilha2.QtdNumeros} numeros.\n" +
                        $"Sendo assim, a pilha 1 é MAIOR que a pilha 2.");
                else
                    Console.WriteLine($"A pilha 1 tem {pilha1.QtdNumeros} numeros e a pilha 2 tem {pilha2.QtdNumeros} numeros.\n" +
                        $"Sendo assim, a pilha 1 é MENOR que a pilha 2.");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        void PropsDaPilha()
        {
            Console.WriteLine("Qual pilha deseja verificar?\n" +
                "1 - Pilha 1;\n" +
                "2 - Pilha 2;\n" +
                "0 - Voltar.");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"O MAIOR numero encontrado na pilha 1 é: {pilha1.MaiorValor}.\n" +
                        $"O MENOR numero encontrado na pilha 1 é: {pilha1.MenorValor}\n" +
                        $"A MÉDIA ARITMÉTICA dos elementos da pilha 1 é: {pilha1.Media}\n" +
                        $"\nPressione qualquer tecla para voltar.");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine($"O MAIOR numero encontrado na pilha 2 é: {pilha2.MaiorValor}.\n" +
                        $"O MENOR numero encontrado na pilha 2 é: {pilha2.MenorValor}\n" +
                        $"A MÉDIA ARITMÉTICA dos elementos da pilha 2 é: {pilha2.Media}" +
                        $"\nPressione qualquer tecla para voltar.");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }

        void CopiarPilha()
        {
            PilhaNumero aux = new();
            Console.WriteLine("Qual pilha deseja copiar? \n" +
                "1 - Pilha 1;\n" +
                "2 - Pilha 2;\n" +
                "0 - Voltar.");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    aux = pilha1;
                    Console.WriteLine("Pilha copiada para uma variável auxiliar com sucesso:");
                    aux.RunOver(true);
                    break;
                case 2:
                    aux = pilha2;
                    Console.WriteLine("Pilha copiada para uma variável auxiliar com sucesso:");
                    aux.RunOver(true);
                    break;
                default:
                    Console.WriteLine("Redicecionando para menu principal. Pressione qualquer tecla...");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }


        //MENU
        void menu()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                int pilha = 0;
                Console.WriteLine("Bem vindo ao comparador de pilhas de inteiros!\n" +
                    "Selecione uma opção:\n" +
                    "1 - Adicionar números em uma pilha;\n" +
                    "2 - Ver o tamanho das pilhas;\n" +
                    "3 - Ver o maior, o menor numero e a média aritmética dos elementos de uma pilha;\n" +
                    "4 - Copiar uma pilha;\n" +
                    "5 - Ver os elementos ímpares de uma pilha;\n" +
                    "6 - Ver os elementos pares de uma pilha;\n" +
                    "0 - Sair do programa.");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarNumeros();
                        break;
                    case 2:
                        TamanhoPilha();
                        break;
                    case 3:
                        PropsDaPilha();
                        break;
                    case 4:
                        CopiarPilha();
                        break;
                    case 5:
                        Console.WriteLine("De qual pilha você deseja ver os elementos IMPARES?\n" +
                            "1 - Pilha 1;\n" +
                            "2 - Pilha 2;\n" +
                            "0 - Voltar.");
                        pilha = int.Parse(Console.ReadLine());
                        if (pilha == 1) pilha1.GetImPar("Os numeros IMPARES da pilha 1 são:", false);
                        if (pilha == 2) pilha2.GetImPar("Os numeros IMPARES da pilha 2 são:", false);
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("De qual pilha você deseja ver os elementos PARES?\n" +
                            "1 - Pilha 1;\n" +
                            "2 - Pilha 2;\n" +
                            "0 - Voltar.");
                        pilha = int.Parse(Console.ReadLine());
                        if (pilha == 1) pilha1.GetImPar("Os numeros PARES da pilha 1 são:", true);
                        if (pilha == 2) pilha2.GetImPar("Os numeros PARES da pilha 2 são:", true);
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);
        }


        //PROGRAMA
        menu();
    }
}