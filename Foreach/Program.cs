using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Maria", "Alex", "Bob" };

            foreach (string item in vetor)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
