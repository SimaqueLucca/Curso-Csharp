using System;
using System.Globalization;

namespace Aulas_II
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Um array possue só dados do mesmo tipo, é ordenado e acessado por posições e é alocado de uma unica vez

            Tamanho fixo e apresenta uma dificuldade para inserir e deletar dados
            */

            System.Console.Write("Quantidade de itens do Array: ");
            int n = int.Parse(Console.ReadLine());

            // iniciando vetor

            int[] vetor = new int[n];

            // inserindo dados

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Valor a ser inserido na posição " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }

            double media = soma / n;

            System.Console.WriteLine("Media: " + media);

        }
    }

}
