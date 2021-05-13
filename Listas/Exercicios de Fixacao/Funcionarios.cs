namespace Exercicios_de_Fixacao
{
    public class Funcionarios
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionarios(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;

        }

        public void AumentarSalario(int porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }

    }
}