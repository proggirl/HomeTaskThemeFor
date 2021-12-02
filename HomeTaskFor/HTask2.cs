using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskAll
{
    public class HTask2
    {
        public  string TaskText = @"Кор бо тағирёбандахо ва амалхои арифметики
        1 Дано двузначное число. Получить число, образованное при перестановке цифр заданного числа
        2 Пользователь вводит количество недель, месяцев, лет и получает количество дней за это время. 
        Считать, что в месяце 30 дней.
        3 С начала суток прошло n секунд.";

        public  void Run()
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
                    default:
                        return;                        
                }
            }

        }


          void Task1()
        {
            Console.Write("a =");
            int a = int.Parse(Console.ReadLine());

            int b = a / 10;
            int c = a % 10;

            Console.WriteLine(c.ToString() + b.ToString());

            Console.ReadLine();
        }

         void Task2()
        {
            Console.Write("Enter weeks:");
            int weeks = int.Parse(Console.ReadLine());
            Console.Write("Enter months:");
            int months = int.Parse(Console.ReadLine());
            Console.Write("Enter Year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Days- {(weeks * 7) + (months * 30) + (year * 365) }");

            Console.ReadLine();
        }

         void Task3()
        {
            Console.Write("N секунд = ");
            var n = int.Parse(Console.ReadLine());

            var h = (n / 3600);
            Console.WriteLine("Полных часов прошло с начала суток: " + h);
            var m = (n % 3600) / 60;
            Console.WriteLine("Полных минут прошло с начала очередного часа: " + m);
            var s = (n % 3600) - (m * 60);
            Console.WriteLine("Полных секунд прошло с начала очередной минуты: " + s);

            Console.ReadLine();

        }
    }
}
