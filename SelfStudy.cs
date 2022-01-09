using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start1
{
    class SelfStudy
    {
 
        public static int[] ArrayCreator()
        {
            int[] array = new int[5];

            Console.WriteLine("Создаем массив из 5-ти чисел:");

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("Введите число: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Введи именно цифру!");
                }

            }

            return array;
        }

        public static void marketPlace()
        {
            string word;
            do
            {
                Console.WriteLine("Угадай отзыв на фразу. Как только отгадаешь, программа завершится.");
                Console.WriteLine("Купи слона!");
                word = Console.ReadLine();

            } while (word.ToLower() != "слон");
        }

        public static void HitIt()
        {
            Random A = new Random();
            int number = A.Next(1, 10);
            Console.WriteLine(number);

            int answer = 0;

            Console.WriteLine("Отгадай число от 1 до 10!");
            answer = int.Parse(Console.ReadLine());
            int j = 0;

            if (answer==number)
            {
                Console.WriteLine("Вы выиграли! Это верное число!");
            }
            else
            {
                do
                {
                    if (j<5)
                    {
                        Console.WriteLine("Вы не угадали. Попробуйте еще раз!");
                        answer=int.Parse(Console.ReadLine());
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Все попытки использованы. Вы проиграли!");
                        break;
                    }
                } while (answer!=number);
            }                    
        }

        static int summa, korrutis=1;

        public static void TopOfArray()
        {
            int[] array2 = ArrayCreator();
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }

            int C = array2.Length;

            for (int bypass = 1; bypass < C; bypass++)
            {
                for (int i = 0; i < C - bypass; i++)
                {
                    if (array2[i] > array2[i+1])
                    {
                        int data_assistant = array2[i];
                        array2[i] = array2[i + 1];
                        array2[i + 1] = data_assistant;
                    }
                }
            }

            Console.WriteLine(); /* сортирую массив в порядке возрастания методом пузырька */
            Console.WriteLine("Массив в порядке возрастания:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine(); /* Беру последний элемент в массиве */
            Console.WriteLine("Наибольшее число в вашем массиве: " + array2[4]);

            Console.WriteLine(); /* Или использую медот Max для массива, тогда можно было и не сортировать. */
            int M = array2.Max();
            Console.WriteLine("Максимальное число в вашем массиве: " + M);

            Console.WriteLine(); /* или через цикл с условием */

            int max = array2[0];

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] > max)
                    max = array2[i];
            }
            Console.WriteLine("Самое большое число в вашем массиве: " + max);

        }

        public static void Main(string[] args)
        {
            HitIt();
            marketPlace();

            int[] array = ArrayCreator();
            foreach (var item in array)
            {
                Console.Write("{0,3}", item);
                summa += item;
                korrutis *= item;
            }

            double avarage = summa / array.Length;
            Console.WriteLine("\nСумма цифр в вашем массиве - {0}", summa);
            Console.WriteLine("Произведение цифр из вашего массива - {0}", korrutis);
            Console.WriteLine("Среднее значение массива - {0}", avarage);

            TopOfArray();

            Console.ReadLine();

        }
 
    }
}
