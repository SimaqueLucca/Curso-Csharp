using System;
using System.Collections.Generic;

namespace Listas_Parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando lista vazia
            //List<string> list = new List<string>();
            //instanciando lista com valores
            //List<string> list2 = new List<string> { "Maria", "Alex", "Bob" };

            List<string> list = new List<string>();

            //list add para inserir item na lista (insere ao final dela)
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            //list insert especifica a posição que deseja adicionar na lista
            list.Insert(2, "Marco");

            foreach (string item in list)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("");

            //list count mostrar o tamanho da lista
            System.Console.WriteLine(list.Count);

            System.Console.WriteLine("");
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("");

            //list find ou findlast recebe como argumento uma função que realiza um teste e dá um retorno
            // list find retorna a primeira ocorrencia e findlast retorna a ultima ocorrencia

            string s1 = list.Find(Test);
            System.Console.WriteLine("Primeira ocorrencia: " + s1);

            // expressão lambda "objeto X tal que X na pos 0 (primeiro caractere) seja igual a 'A'"
            string s2 = list.FindLast(x => x[0] == 'A');
            System.Console.WriteLine("Ultima ocorrencia: " + s2);

            // find index e findlastindex retorna o index da primeira e da ultima posição da ocorrencia
            int pos1 = list.FindIndex(x => x[0] == 'A');
            System.Console.WriteLine("Posição da primeira ocorrencia: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            System.Console.WriteLine("Posição da ultima ocorrencia: " + pos2);

            System.Console.WriteLine("");
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("");

            // findall retorna uma nova lista apenas com os objetos que atendem o "filtro"
            // nesse exemplo, retorna uma lista com os objetos que tenham o tamanho de 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string item in list2)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("");

            // remover elementos da lista

            list.Remove("Alex");
            // remove apenas o item indicado pela string

            list.RemoveAll(x => x[0] == 'M');
            // remove de acordo com o predicado/função

            list.RemoveAt(3);
            // remove de acordo com a posição do objeto

            list.RemoveRange(0, 2);
            // remove de acordo com o range (inicia com a posição e o segundo parametro é a quantidade)
        }


        // Nesse exemplo a função Teste verifica os itens da lista e retorna o que possue a letra A na primeira posição
        static bool Test(string s)
        {
            //função que retorna o item da lista que inicia com A
            //Pode ser trocada por uma expressão lambda
            return s[0] == 'A';
        }

    }
}
