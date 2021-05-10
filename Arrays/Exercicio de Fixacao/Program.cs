using System;

namespace Exercicio_de_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int QuantidadeAlunos = int.Parse(Console.ReadLine());
            System.Console.WriteLine("");

            Quartos[] Quarto = new Quartos[10];

            for (int i = 0; i < QuantidadeAlunos; i++)
            {
                System.Console.WriteLine("Aluguel #" + (i + 1) + ":");
                System.Console.Write("Nome do Aluno: ");
                string nome = Console.ReadLine();

                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                int quarto = 999;

                while (quarto < 0 || quarto > 9)
                {
                    System.Console.Write("Quarto que deseja Alugar: ");
                    quarto = int.Parse(Console.ReadLine());

                    System.Console.WriteLine("");

                    if (quarto < 0 || quarto > 9)
                    {

                        System.Console.WriteLine("Não temos esse quarto, por favor escolha um quarto entre 0 e 9.");
                    }
                }

                Quarto[quarto] = new Quartos { Nome = nome, Email = email };
            }

            System.Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 9; i++)
            {
                if (Quarto[i] != null)
                {
                    System.Console.WriteLine(i + ": " + Quarto[i].Nome + ", " + Quarto[i].Email);
                };
            }
        }
    }
}
