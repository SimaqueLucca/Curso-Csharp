using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicios_de_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseja registrar quantos funcionarios? ");
            int N = int.Parse(Console.ReadLine());

            List<Funcionarios> funcionarios = new List<Funcionarios>();

            for (int i = 1; i <= N; i++)
            {
                System.Console.WriteLine("Funcionário #" + i + ": ");

                System.Console.Write("Informe um ID: ");
                int id = int.Parse(Console.ReadLine());

                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();

                System.Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.WriteLine();

                funcionarios.Add(new Funcionarios(id, nome, salario));
            }

            System.Console.Write("Informe o ID do funcionario que deseja aumentar o salario: ");
            int posFuncionario = int.Parse(Console.ReadLine());

            bool existeID = funcionarios.Exists(x => x.ID == posFuncionario);

            if (existeID)
            {
                System.Console.Write("Informe a porcentagem de aumento: ");
                int quantidade = int.Parse(Console.ReadLine());

                posFuncionario = funcionarios.FindIndex(x => x.ID == posFuncionario);
                funcionarios[posFuncionario].AumentarSalario(quantidade);
            }
            else
            {
                System.Console.WriteLine("Esse ID não existe!");
            }

            System.Console.WriteLine();

            System.Console.WriteLine("Lista atualizada dos funcionarios:");

            foreach (var item in funcionarios)
            {
                System.Console.WriteLine(item.ID + ", " + item.Nome + ", " + item.Salario);
            }
        }
    }
}
