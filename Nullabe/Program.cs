using System;
using System.Globalization;

namespace Aulas_II
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            System.Console.WriteLine(x.GetValueOrDefault());
            System.Console.WriteLine(y.GetValueOrDefault());

            System.Console.WriteLine(x.HasValue);
            System.Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                System.Console.WriteLine(x.Value);
            }
            else
            {
                System.Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                System.Console.WriteLine(y.Value);
            }
            else
            {
                System.Console.WriteLine("Y is null");
            }

            /*   ?? operador de coalescencia nula
                Exemplo: 
                
                double? x = null;
                double y = x ?? 0.0;

                x pode ser nullo
                e y não

                então usando o operador ??, garantimos que se X for nulo, y receberá um valor pré definido
            */
        }
    }
}
