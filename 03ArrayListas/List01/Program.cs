using System;
using System.Collections.Generic;

namespace List01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");        //Add aciciona no final da lista
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");   //Insert adiciona na posição que você quiser

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);// mostrar o tamanho da lista

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A' : " + s1); // retorna o primeiro item da lista que contém o que estou buscando (A)

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' : " + s2); // retorna o último item da lista que contém o que estou buscando (A)


            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A' : " + pos1); // retorna o primeiro index da lista que contém o que estou buscando (A)

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A' : " + pos2); // retorna o último index da lista que contém o que estou biuscando (A)

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");            //retorna todos os itens cujo tamanho é 5 caracteres
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(3); //remove o item  da posição 3
            Console.WriteLine("---------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); //remove 2 itens a partir da posição 2
            Console.WriteLine("---------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); //remove todos os itens que contem M
            Console.WriteLine("---------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
