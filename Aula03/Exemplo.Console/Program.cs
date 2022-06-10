class Program
{
    public enum Days { None, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    public enum OpcoesMenu { Sair, Cadastrar, Editar, Remover, Listar, Pesquisar }

    static void Main(string[] args)
    {
        // ExemploEnum();
        // ExemploWhile();
        ExecutarPrograma1();
        // ExemploArray();
    }

    private static void ExemploWhile()
    {
        int valor = 1;

        bool condicao = true;

        while (condicao)
        {
            Console.WriteLine("Informe o valor válido: ");
            valor = int.Parse(Console.ReadLine());

            if (valor == 5)
            {
                condicao = false;
            }
        }

        if (!condicao)
        {
            Console.WriteLine("valor inválido");
        }
    }


    private static void ExecutarPrograma1()
    {
        var condicao = true;

        while (condicao)
        {
            MostrarMenu();
            int opcao = int.Parse(Console.ReadLine());
            OpcoesMenu opcaoEscolhida = (OpcoesMenu)opcao;
            condicao = EscolherAcao(opcaoEscolhida);
        }
    }

    private static bool EscolherAcao(OpcoesMenu opcao)
    {
        var condicao = true;

        switch (opcao)
        {
            case OpcoesMenu.Cadastrar:
                System.Console.WriteLine("\n\n -------------------- Cadastado com sucesso ------------------ \n");
                break;
            case OpcoesMenu.Editar:
                System.Console.WriteLine("\n\n -------------------- Alterado com sucesso ------------------ \n");
                break;
            case OpcoesMenu.Remover:
                System.Console.WriteLine("\n\n -------------------- Removido com sucesso ------------------ \n");
                break;
            case OpcoesMenu.Sair:
            default:
                condicao = false;
                System.Console.WriteLine("\n\n -------------------- Saindo ------------------ \n");
                break;
        }

        return condicao;
    }

    private static void MostrarMenu()
    {
        System.Console.WriteLine("\n\n -------------------- MENU ------------------ \n");
        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Editar");
        Console.WriteLine("3 - Remover");
        Console.WriteLine("0 - Sair");
        Console.Write("Informe uma opção: ");
    }

    private static void ExemploEnum()
    {
        Days dia = Days.Friday;
        int diaEnum = (int)Days.Wednesday;
        Console.WriteLine(diaEnum);

        int diaInt = 6;
        Console.WriteLine((Days)diaInt);
    }

    private static void ExemploArray()
    {
        /**
        * Declaração de arrays   
        */
        // int[] idades = { 20, 26, 36, 18, 80 };
        // string[] cidades = { "Campo Grande", "Campinas", "Florianópolis" };

        /**
        * Exemplo array e percorrendo com for e foreach
        */
        // int[] valores = { 20, 10, 30 };
        // for(int i = 0; i < valores.Length; i++)
        // {
        //     Console.WriteLine(valores[i]);
        // }

        // foreach(int valor in valores)
        // {
        //     var indice = Array.FindIndex(valores, (x) => x == valor);
        //     Console.WriteLine(indice);
        // }


        /**
        * Manipulação de arrays   
        */
        // Console.WriteLine($"Soma: {valores.Sum()}");
        // Console.WriteLine($"Média: {valores.Average()}");
        // Console.WriteLine($"Maior: {valores.Max()}");
        // Console.WriteLine($"Menor: {valores.Min()}");
        // Console.WriteLine($"Contador: {valores.Count()}");

        /**
        * Manipulação de arrays - ordenando inteiros 
        */
        // foreach (int valor in valores) Console.WriteLine(valor);
        // Array.Sort(valores);
        // foreach (int valor in valores) Console.WriteLine(valor);

        /**
        * Manipulação de arrays - ordenando strings 
        */
        // string[] nomes = { "João", "Maria", "José" };
        // foreach (string nome in nomes) Console.WriteLine(nome);
        // Array.Sort(nomes);
        // System.Console.WriteLine("\n ------------ ordenado \n");
        // foreach (string nome in nomes) Console.WriteLine(nome);

        /**
        * Manipulação de arrays - ordenando strings 
        */
        // if (Array.Exists(nomes, (x) => x.IndexOf("JJ") > -1))
        // {
        //     Console.WriteLine("Existe");
        // }
        // else
        // {
        //     Console.WriteLine("Não existe");
        // }
    }
}