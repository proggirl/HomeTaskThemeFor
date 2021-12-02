using System;

namespace HomeTaskAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name for dog: ");
            string dogName = Console.ReadLine();
            Console.WriteLine("Enter the breed for dog: ");
            string dogBreed = Console.ReadLine();

            Dog firstDog = new Dog(dogName, dogBreed);
            Dog secondDog = new Dog();
            for (int i = 1; i <= 3; i++)
                firstDog.SayGav();

            for (int i= 0; i < 10; i++)
            {
                secondDog.SayGav();
            }

            Console.WriteLine(firstDog.GetName());
            Console.WriteLine(firstDog.GetBreed());

            Console.WriteLine(secondDog.GetName());
            Console.WriteLine(secondDog.GetBreed());
            ///все же правильно  что тут не то ?я перепутала первую с вторым сейчас поняла) )) когда ты удаляла я это понял))
            ///смотрю ты тут удаляеш вторую а ждеш первую  по этому взял и все вернул))
            ///даа) все правильно поняла  ? думаю да отлично


            Console.Write(Dog.CountGav.ToString());
            Console.ReadLine();

            //HTask2 task2 = new HTask2();
            //HTask3 task3 = new HTask3();
            //HTask4 task4 = new HTask4();
            //HTask5 task5 = new HTask5();
            //HTask6 task6 = new HTask6();

            
            ////HTask2--(тип переменной) task2 --(переменная) = new --(это ключевое слова создаеть обекть от правого вещи там могуть быть все что угодна и классы и примитивы) HTask2() --(тут имя класса конструктор по умолчанию вызываеться );
       

            //while (true)
            //{

            //    Console.WriteLine("Выбирайте тему с решениями дз: \n2-Тема 2 \n3-Тема 3 \n4-Тема 4 \n5-Тема 5 \n6-Тема 6" +
            //        "\n" );
                

            //    string option = Console.ReadLine();

            //    switch (option)
            //    {
            //        case "2":
            //            task2.Run();
            //            break;
            //        case "3":
            //            task3.start();
            //            break;
            //        case "4":
            //            task4.run();
            //            break;
            //        case "5":
            //            task5.run();
            //            break;
            //        case "6":
            //            task6.run();
            //            break;
            //        default:
            //            return;
                        

            //    }


            //}

            


           
        }
    }
}
