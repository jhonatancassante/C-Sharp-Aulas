using System;
using System.Collections.Generic;

namespace ListExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #{0}:", i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine();
                list.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Entre com  o ID do funcionário que receberá aumento: ");
            n = int.Parse(Console.ReadLine());

            Funcionario temp = list.Find(x => x.Id == n);

            if (temp != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcent = double.Parse(Console.ReadLine());
                temp.Aumento(porcent);
            }
            else
            {
                Console.WriteLine("Este ID não existe!");
            }
            Console.WriteLine();

            Console.WriteLine("Lista atualizada de funcionários:");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
