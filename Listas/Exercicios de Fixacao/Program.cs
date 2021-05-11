using System;
using System.Globalization;

namespace Exercicios_de_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseja registrar quantos funcionarios?");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                System.Console.WriteLine("Funcionário #" + i + ": ");

                System.Console.Write("Informe um ID: ");
                int id = int.Parse(Console.ReadLine());

                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();

                System.Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            }
        }
    }
}
