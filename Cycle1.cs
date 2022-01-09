using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start1
{
    class Cycle1
    {
        static int MassivSize(int min, int max)
        {
            Random rnd = new Random();
            int A = rnd.Next(min, max);
            return A;
        }
        static void Main(string[] args)
        {
            int A = MassivSize(1, 20);
            int[] massiv = new int[A];
            int E;
            for (int i = 0; i < A; i++)
            {
                E = MassivSize(1, 10);
                massiv[i] = E;
            }
            foreach (var item in massiv)
            {
                Console.WriteLine("{0,3}", item);
            }
            Console.WriteLine();

            string[] abc = new string[5] { "A", "B", "C", "D", "E" };

            int ind = MassivSize(0, 4);
            Console.WriteLine("Элемент с индексом {0} и {1}", ind, abc[ind]);
            int j = 0;

            while (j != abc.Length)
            {
                Console.WriteLine(abc[j]);
                j++;
            }

            //Двумерный массив генерируя случайные цифры

            A = MassivSize(3, 12); // ряды
            E = MassivSize(3, 12); // места
            int[,] table = new int[A, E];
            //int[,] table = new int[,] { }; //объявляем пустой двумерный массив

            for (int i = 0; i < A; i++)
            {
                for (int k = 0; k < E; k++)
                {
                    table[i, k] = MassivSize(-10, 10);
                }
            }
            for (int i = 0; i < A; i++)
            {
                for (int k = 0; k < E; k++)
                {
                    Console.Write("0,4", table[i,k]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
