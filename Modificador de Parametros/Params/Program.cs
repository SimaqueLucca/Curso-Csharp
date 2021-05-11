using System;

namespace Problema
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int s1 = Calculadora.Soma(2, 3);
            int s2 = Calculadora.Soma(2, 3, 4);
            int s3 = Calculadora.Soma(2, 3, 4, 5);

            System.Console.WriteLine(s3);
            */

            /*
            Utilizando um array no parametro sem o modificador params

            int s1 = Calculadora.Soma(new int[] { 2, 3 });
            int s2 = Calculadora.Soma(new int[] { 2, 3, 4, 5, 6, 7, 8, 9 });

           
            */

            // podendo enviar parametros variaveis e sem a necessidade de instanciar um array

            int s1 = Calculadora.Soma(2, 3);
            int s2 = Calculadora.Soma(2, 3, 4, 5, 6, 7, 8, 9);

            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
        }
    }

}
