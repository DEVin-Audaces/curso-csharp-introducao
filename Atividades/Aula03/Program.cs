static class Program
{
    enum SerieNetflix { StrangerThings, BreakingBad, Vikings, Logout }
    static void Main(string[] args)
    {
        Console.WriteLine("\n--------------  ORDENAÇÃO  --------------");

        // int tamanhoArrayValores = 4;
        // int[] numeros = new int[tamanhoArrayValores];
        // int contador = 0;

        // Console.WriteLine("\nDigite a quantidade de valores a serem ordenados: ");
        // while (contador < tamanhoArrayValores)
        // {
        //     Console.Write($"Informe valor [{contador + 1}]: ");
        //     numeros[contador] = int.Parse(Console.ReadLine());
        //     contador++;
        // }

        // Array.Sort(numeros);

        // foreach (var item in numeros)
        // {
        //     Console.Write(item + " ");
        // }


        Console.WriteLine("\n--------------  SOMA VALORES  --------------");
        // int[] valores = new int[3];
        // for (int i = 0; i < valores.Length; i++)
        // {
        //     Console.Write($"Informe o valor {i}: ");
        //     valores[i] = int.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("Valores informado são:");
        // foreach (var item in valores)
        // {
        //     System.Console.Write($"{item} ");
        // }

        // Console.WriteLine("\nSoma dos valores: " + valores.Sum());

        Console.WriteLine("\n--------------  SERIES NETFLIX  --------------");
        // MostrarMenu();
        // bool condicao = true;
        // while (condicao)
        // {
        //     Console.Write("\nDigite a opção desejada: ");
        //     int opcao = int.Parse(Console.ReadLine());

        //     switch (opcao)
        //     {
        //         case 1:
        //             Console.WriteLine("Assistindo a série Stranger Things");
        //             break;
        //         case 2:
        //             Console.WriteLine("Assistindo a série Breaking Bad");
        //             break;
        //         case 3:
        //             Console.WriteLine("Assistindo a série Vikings");
        //             break;
        //         default:
        //             Console.WriteLine("Logout");
        //             Console.WriteLine("Obrigado, nos vemos em breve!");
        //             condicao = false;
        //             break;

        //     }
        // }
    }

    private static void MostrarMenu()
    {
        Console.WriteLine("1 - Stranger Things");
        Console.WriteLine("2 - Breaking bad");
        Console.WriteLine("3 - Vikings");
        Console.WriteLine("4 - Logout ");
    }
}