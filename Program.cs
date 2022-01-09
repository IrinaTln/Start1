using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name.ToUpper() + "!");
            if (name.ToLower() == "juku")
            {
                Console.WriteLine("Пойдем в кино, {0}. Сколько тебе лет?", name);
                int age = int.Parse(Console.ReadLine());
                double price = 6.50;
                string ticket;
                if (age < 0 || age > 120)
                {
                    Console.WriteLine("Странный у тебя возраст!");
                }
                else
                {
                    if (age < 6)
                    {
                        ticket = "О! У тебя билет со скидкой!";
                        price *= 0.5;

                    }
                    else
                    {
                        ticket = "Тебе нужен билет по полной стоимости.";
                    }
                    Console.WriteLine("{0}. Цена твоего билета {1}", ticket, price);
                }
            }
            else
            {
                Console.WriteLine("Я занят.");
            }
            Console.ReadLine();
            /*int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Products of numbers {0} and {1} is {2}", number1, number2, number1*number2);
            Console.ReadLine();*/
        }
    }
}
