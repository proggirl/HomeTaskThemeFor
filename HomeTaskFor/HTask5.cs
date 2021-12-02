using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskAll
{
   public class HTask5
    {
        public string TaskText = @" Using compound assignment and iteration statements
                10 сумма всех целых чисел от 100 до 500
                11 сумма всех целых чисел от a до 500(значение a вводится с клавиатуры; a < 500);
                12 сумма всех целых чисел от –10 до b(значение b вводится с клавиатуры; b >–10);
                13 сумма всех целых чисел от a до b(значения a и b вводятся с клавиатуры; b > a);";
        
        public void run()
        {
            Console.WriteLine(TaskText);
            while (true)
            {
                string opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    default:
                        return;
                }
            }
        }

        void Task1()
        {
            int number = 100;
            for (int i = 101; i <= 500; i++)
                number += i;
            Console.WriteLine("Сумма всех целых чисел от 100 до 500 равен: " + number);
        }

        void Task2()
        {
            Console.Write("Введите значение переменной a: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i <= 500; i++)
                a += i;
            Console.WriteLine("Сумма всех целых чисел от a до 500 равен: " + a);
        }

        void Task3()
        {
            Console.Write("Введитезначение переменной b: ");
            var b = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = -10; i < b; i++)
                sum += i;
            Console.WriteLine("Сумма всех целых чисел от –10 до b равен: " + sum);
        }

        void Task4()
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
