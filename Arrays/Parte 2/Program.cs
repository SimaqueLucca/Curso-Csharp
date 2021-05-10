using System;
using System.Globalization;

namespace Parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseja inserir quantos produtos? ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
                System.Console.Write("Preço do produto: R$");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.WriteLine("");

                vetor[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vetor[i].Preco;
            }

            double media = soma / n;

            System.Console.Write("Preço médio: R$" + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
