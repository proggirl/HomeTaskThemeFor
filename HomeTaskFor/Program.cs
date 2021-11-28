using System;

namespace HomeTaskFor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine(@"Выбирайте номер решений дз: 
        1 сумму всех целых чисел от 100 до 500 
        2 сумму всех целых чисел от a до 500 (значение a вводится с клавиатуры; a < 500);
        3 сумму всех целых чисел от –10 до b (значение b вводится с клавиатуры; b>–10);
        4 сумму всех целых чисел от a до b (значения a и b вводятся с клавиатуры; b>a)");
             
            string option = Console.ReadLine();
           
                switch (option)
                {
                    case "1":
                        //а) сумму всех целых чисел от 100 до 500;
                        Task1();
                        break;
                    case "2":
                        //сумму всех целых чисел от a до 500 (значение a вводится с клавиатуры; a < 500);
                        Task2();
                        break;
                    case "3":
                        //сумму всех целых чисел от –10 до b (значение b вводится с клавиатуры; b>–10);
                        Task3();
                        break;
                    case "4":
                        //сумму всех целых чисел от a до b (значения a и b вводятся с клавиатуры; b>a)
                        Task4();
                        break;

                }

            }
            static void Task1()
            {
                int number = 100;
                for (int i = 101; i <= 500; i++)
                    number += i;
                Console.WriteLine("Сумма всех целых чисел от 100 до 500 равен: " + number);
            }

            static void Task2()
            {
                Console.Write("Введите значение переменной a: ");
                int a = int.Parse(Console.ReadLine());
                for (int i = a; i <= 500; i++)
                    a += i;
                Console.WriteLine("Сумма всех целых чисел от a до 500 равен: " + a);
            }

            static void Task3()
            {
                Console.Write("Введитезначение переменной b: ");
                var b = int.Parse(Console.ReadLine());
                var sum = 0;
                for (int i = -10; i < b; i++)
                    sum += i;
                Console.WriteLine("Сумма всех целых чисел от –10 до b равен: " + sum);
            }

            static void Task4()
            {
                Console.Write("Введите значение переменной а: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите значение переменной b: ");
                int b = int.Parse(Console.ReadLine());
                if (a > b) Console.WriteLine("Ошибка! Переменная а > b");
                else
                {
                    int i, sum = 0;
                    for (i = a; b >= i; i++)
                        sum += i;
                    Console.WriteLine("Сумма чисел равна: " + sum);
                }
                Console.ReadLine();
            }
        }
    }
}
