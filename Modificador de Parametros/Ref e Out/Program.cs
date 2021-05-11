using System;

namespace Ref_e_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 10;
            Calculadora.Triplo(ref a);
            System.Console.WriteLine(a);
            */


            int a = 10;
            int triplo;
            Calculadora.Triplo(a, out triplo);
            System.Console.WriteLine(triplo);

            /* enviando um valor original, mas retornando o valor em outra variavel (que não foi inicializada com algum valor) */

        }
    }
}
