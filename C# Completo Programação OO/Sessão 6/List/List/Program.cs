using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); //Criando um lsita


            //Adicionando elementos à uma lista de forma sequencial
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            //Imprimindo a lista
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Adicionando um elemento em um local específico de uma lista
            list.Insert(2, "Marco");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Contando quantos elementos existem na lista
            Console.WriteLine("Quantidade: " + list.Count);
            Console.WriteLine();

            //Procurando o primeiro da lista que cumpra um requisito
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro A: " + s1);
            //Procurando o ultimo da lista que cumpra um requisito
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo A: " + s2);
            Console.WriteLine();

            //Procurando a posição do primeiro da lista que cumpra um requisito
            int pos1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine("Pos primeiro M: " + pos1);
            //Procurando a posição do ultimo da lista que cumpra um requisito
            int pos2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("Pos primeiro M: " + pos2);
            Console.WriteLine();

            //Criando uma nova lista com todos os elementos que cumpram um requisito
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Removendo um elemento pela posição dele
            list.RemoveAt(3);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Removendo um elemento específico
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Removendo todos os elementos da lista que cumpram um requisito
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Adicionando novos elementos pois tava sem elementos o suficiente para fazer mais um teste
            list.Add("Alfredo");
            list.Add("Shiryu");
            list.Add("Jiraya");
            list.Add("Lazunie");
            list.Add("Jhonatan");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Removendo elementos de uma faixa
            list.RemoveRange(2, 2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

        }
    }
}
