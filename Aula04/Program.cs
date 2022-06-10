static class Program
{
    static void Main(string[] args)
    {
        /*
            -------------------- EXEMPLO FIRST / FIRT_OR_DEFAULT / LAST / LAST_OR_DEFAULT --------------------
        */
        // List<int> notas = new List<int>() { 10, 8, 1, 10 };

        // var first = notas.First(n => n == 2);
        // var firstDefault = notas.FirstOrDefault(n => n == 2);

        // var last = notas.Last();
        // var lastDefault = notas.LastOrDefault();

        // var single = notas.Single(x => x == 10);
        // var singleDefault = notas.SingleOrDefault(x => x == 10);


        /*
            -------------------- EXEMPLO COUNT / MAX / MIN / CLEAR --------------------
        */

        // List<int> notas = new List<int>() { 10, 8, 1 }; // 10, 8, 1
        // notas.Add(7); // 10, 8, 1, 7
        // notas.Insert(0, 7); // 10, 8, 7, 1

        // foreach (var item in notas) System.Console.WriteLine(item);
        
        // notas.Clear(); // Zerar a lista
        // List<int> lista1 = new List<int>(2);                
        
        // if (possuiRegistros)
        //     System.Console.WriteLine("Lista com " + notas.Count());
        // else
        //     System.Console.WriteLine("Lista vazia");


        /*
            -------------------- EXEMPLO COUNT / MAX / MIN  --------------------
        */

        // List<int> notasBaixas = new List<int>() { 2, 3, 4 };
        // notas.InsertRange(0, notasBaixas);
        // foreach (var nota in notas) Console.WriteLine(nota);
        // Console.WriteLine("" + notas.Count());
        // Console.WriteLine("" + notas.Max());
        // Console.WriteLine("" + notas.Min());

        /*
            -------------------- EXEMPLO ELEMENT AT / REMOVE AT  --------------------
        */

        // List<int> notas = new List<int>() { 10, 1, 6, 7 }; // 0, 1, 2, 3
        // int indice = 2;

        // notas.RemoveAt(1);
        // var indiceSelecionado = notas.ElementAt(indice);
        // System.Console.WriteLine($"Valor Indice selecionado: {indiceSelecionado}");
        // System.Console.WriteLine($"Valor Indice selecionado: {notas[indice]}");

        // foreach (var nota in notas) System.Console.WriteLine(nota);



        /*
            -------------------- EXEMPLO ADD / ADD RANGE / REMOVE ALL --------------------
        */
        
        // List<int> notasBaixas = new List<int>() { 2, 3, 4 };
        // List<int> notas = new List<int>() { 10, 1, 6, 7 };
        // notas.Add(1); // 10, 6, 7, 1         // 10, 6, 7, 1, 1
        // notas.AddRange(notasBaixas); // 10, 6, 7, 1  2, 3, 4
        // notas.RemoveAll(nota => nota < 7); 

        // foreach (int nota in notas)
        // {
        //     Console.WriteLine(nota);
        // }
    }
}