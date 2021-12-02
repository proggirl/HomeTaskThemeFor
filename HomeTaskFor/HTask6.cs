using System;


namespace HomeTaskAll
{
    public class HTask6
    {
        
        public string TaskText = @"Managing errors and exceptions
                1.Пользователь вводит два целых числа. Написать два метода:
                     1.1. int-метод нахождение произведения чисел.Если результат умножения будет больше возможностей int, 
                вывести исключение
                    1.2. int-метод нахождения частного чисел.Предусмотреть деление на ноль
                2.Сгенерировать n случайных чисел.Возвести четные и положительные из них в квадрат. 
                    Если же число отрицательное – сгенерировать исключение.";

        public void run() 
        {
            Console.WriteLine(TaskText);
            while (true)
            {
                string opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        newer();
                        break;
                    case "2":
                        divider();
                        break;

                    case "3":
                        rndm();
                        break;
                    default:
                        return;
                        
                        
                }
            }
        }

        //все
        void newer()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("Result: " + dec(a, b));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }//так? да
        static int dec(int a,int b)
        {

            return checked(a * b);
        }

       
        void divider() 
        {
            try
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
               
                Console.WriteLine("Result: " + div(a, b));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
         
           
        }

        int div(int a, int b)
        {
            return a / b;
        }
       
void rndm()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {

                    Console.WriteLine("Random:" + rand());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        
        int rand()
        {
            Random random = new Random();
            int n = random.Next(-100, 100);
            if (n <= 0)
                throw new Exception("Random number is negative");
            if (n % 2 == 0)
                return (int)Math.Pow(n, 2);
            return n;
        }
        
    }


}
