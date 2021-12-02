using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskAll
{
   public class HTask4
    {
        public string TaskText = @" Using decision statement
        1 .Пользователь вводит три числа.Программа должна возвести в квадрат положительные числа, 
        а отрицательные оставить без изменения
        2. Дано название месяца 2021 года.Вывести, сколько в нем дней
        3. Даны три вещественных числа a, b, c. Проверить:
                а) a < b < c ?
                б) b > a > c ?";

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
                    default:
                        return;
                }
            }
        }

        void Task1()
        {
            Console.WriteLine("Enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Check(a));
            Console.WriteLine(Check(b));
            Console.WriteLine(Check(c));
        }

        int Check(int temp)
        {
            if (temp >= 0) temp = (int)Math.Pow(temp, 2);
            return temp;
        }
       

        void Task2()
        {
            int n = int.Parse(Console.ReadLine());
            n = 12;

            switch (n)
            {
                case 1:
                    Console.WriteLine("31");
                    break;
                case 2:
                    Console.WriteLine("28");
                    break;
                case 3:
                    Console.WriteLine("31");
                    break;
                case 4:
                    Console.WriteLine("30");
                    break;
                case 5:
                    Console.WriteLine("31");
                    break;
                case 6:
                    Console.WriteLine("30");
                    break;
                case 7:
                    Console.WriteLine("31");
                    break;
                case 8:
                    Console.WriteLine("31");
                    break;
                case 9:
                    Console.WriteLine("30");
                    break;
                case 10:
                    Console.WriteLine("30");
                    break;
                case 11:
                    Console.WriteLine("30");
                    break;
                case 12:
                    Console.WriteLine("31");
                    break;
            }
        }
        //public static void Task2_1()
        //{

        //    Console.Write("Вводите номер месяца: ");
        //    int month = int.Parse(Console.ReadLine());
        //    Console.Write("Вводите год: ");
        //    int year = int.Parse(Console.ReadLine());
        //    DateTime dt1 = new DateTime(year, month, 1);
        //    DateTime dt2 = dt1.AddMonths(1);
        //    int days = (dt2 - dt1).Days;
        //    Console.Write("количество дней в месяце: " + days);
        //    Console.ReadLine();
        //}
  
        void Task3()
        {
            double a, b, c;
            Console.Write("Введите вещественное число a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественное число b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественное число c = ");
            c = double.Parse(Console.ReadLine());
            if ((b > a) && (a > c))
            {

                Console.WriteLine("{0} > {1} > {2} - {3}", b, a, c, ((b > a) && (a > c)));
            }
            else if ((a < b) && (b < c))
            {

                Console.WriteLine("{0} < {1} < {2} - {3}", a, b, c, (a < b) && (b < c));
            }
            else
            {
                Console.WriteLine("Нет правильных выполнений неравенств");
            }
            Console.ReadLine();
        }

        //public static void Task3_1()
        //{
        //    double a, b, c;
        //    Console.Write("Введите вещественное число a = ");
        //    a = double.Parse(Console.ReadLine());
        //    Console.Write("Введите вещественное число b = ");
        //    b = double.Parse(Console.ReadLine());
        //    Console.Write("Введите вещественное число c = ");
        //    c = double.Parse(Console.ReadLine());

        //    Console.WriteLine("а) a < b < c = {0} > {1} > {2} - {3}", b, a, c, ((b > a) && (a > c)));
        //    Console.WriteLine("б) b > a > c =  {0} < {1} < {2} - {3}", a, b, c, (a < b) && (b < c));

        //    Console.ReadLine();
        //}
        
    }
}
