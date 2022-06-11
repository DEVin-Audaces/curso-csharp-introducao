static class Program
{
    enum SerieNetflix { StrangerThings = 1, BreakingBad = 2, Vikings = 3, Logout = 4 }

    static void Main(string[] args)
    {
        // Console.WriteLine("\n--------------  ORDENAÇÃO  --------------");

        // int tamanhoArrayValores = 4;
        // int[] numeros = new int[tamanhoArrayValores];
        // int contador = 0;

        // Console.WriteLine("\nDigite os valores a serem ordenados: ");
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


        // Console.WriteLine("\n--------------  SOMA VALORES  --------------");
        // int[] valores = new int[3];
        // for (int i = 0; i < valores.Length; i++)
        // {
        //     Console.Write($"Informe o valor {i+1}: ");
        //     valores[i] = int.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("Valores informado são:");
        // foreach (var item in valores)
        // {
        //     System.Console.Write($"{item} ");
        // }

        // Console.WriteLine("\nSoma dos valores: " + valores.Sum());
        // Console.WriteLine("\nMaior: " + valores.Max());
        // Console.WriteLine("\nMenor: " + valores.Min());

        // Console.WriteLine("\n--------------  SERIES NETFLIX  --------------");
        // MostrarMenu();
        // bool condicao = true;
        // while (condicao)
        // {
        //     Console.Write("\nDigite a opção desejada: ");
        //     int opcao = int.Parse(Console.ReadLine());

        //     var enumSerieEscolhida = (SerieNetflix) opcao;

        //     switch (enumSerieEscolhida)
        //     {
        //         case SerieNetflix.StrangerThings:
        //             Console.WriteLine("Assistindo a série Stranger Things");
        //             break;
        //         case SerieNetflix.BreakingBad:
        //             Console.WriteLine("Assistindo a série Breaking Bad");
        //             break;
        //         case SerieNetflix.Vikings:
        //             Console.WriteLine("Assistindo a série Vikings");
        //             break;
        //         case SerieNetflix.Logout:
        //         default:
        //             Console.WriteLine("Logout");
        //             Console.WriteLine("Obrigado, nos vemos em breve!");
        //             condicao = false;
        //             break;
        //     }
        // }
    }

    // modificadores retorno nome-método lista-parametros
    private static void MostrarMenu()
    {
        Console.WriteLine("1 - Stranger Things");
        Console.WriteLine("2 - Breaking bad");
        Console.WriteLine("3 - Vikings");
        Console.WriteLine("4 - Logout ");
    }
}
