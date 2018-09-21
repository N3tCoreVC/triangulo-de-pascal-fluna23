using System;

namespace ejercicios
{
    class Program
    {
        static int num;
        static void Main(string[] args)
        {
            Console.WriteLine("Dame base del triángulo: ");

            if (int.TryParse(Console.ReadLine(), out num))
            {
                pasca(num + 1);
            }
            else
                Console.WriteLine("Número inválido.");
        }

        static void pasca(int val){
            int lim = val, aux = val;
            int[,] arre = new int[val+val, val+val];
            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < val*2; j++)
                {
                    arre[i, j] = 0;
                }
            }
            for (int i = 0; i < val; i++)
            {
                for (int j = lim; j < aux; j+=2)
                {
                    arre[i, j] = 1;
                }
                aux++;
                lim--;
            }
            lim = val;
            aux = val;
            for (int i = 2; i < val; i++)
            {
                for (int j = lim; j < aux; j+=2)
                {
                    arre[i, j] = arre[i - 1, j - 1] + arre[i - 1, j + 1];
                }
                aux++;
                lim--;
            }

            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < val*2; j++)
                {
                    if(arre[i, j] != 0)
                        Console.Write(arre[i, j]+"");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}