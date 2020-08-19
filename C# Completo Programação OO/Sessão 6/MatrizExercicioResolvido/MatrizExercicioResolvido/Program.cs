using System;

namespace MatrizExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] mat;
            int neg = 0;

            Console.Write("Digite a ordem da matriz: ");
            n = int.Parse(Console.ReadLine());
            mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite a posição de linha {0} da matriz: ", i);
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        neg++;
                    }
                    if (i == j)
                    {
                        if (i < (n - 1))
                        {
                            Console.Write(mat[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(mat[i, j]);
                        }


                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Números negativos = " + neg);
        }
    }
}
