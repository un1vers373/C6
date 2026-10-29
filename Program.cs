using System;
namespace c1
{
    class Program
    {
        static void Main()
        {
             int number = -1;
            int number1;
            int number2;
            int number4;
            int number6;
           
            while (number != 0)
            {
            Console.WriteLine("1 - Приветствие");
            Console.WriteLine("2 - Сложение чисел");
            Console.WriteLine("3 - Проверка чисел");
            Console.WriteLine("4 - Числа от 1 до 10");
            Console.WriteLine("5 - Проверка чётности");
            Console.WriteLine("0 - Выход");
            Console.Write("Выбери команду: ");

            number = int.Parse(Console.ReadLine());

            switch (number)
            {
            case 1:
                Console.WriteLine("Привет!");
                break;
            
            case 2:
                Console.WriteLine("Введи первое число: ");
                string input = Console.ReadLine();
                number1 = int.Parse(input);
                Console.WriteLine("Введите второе число: ");
                string input1 = Console.ReadLine();
                number2 = int.Parse(input1);
                Console.WriteLine("Сумма: " + (number1 + number2));
                break;

            case 3:
                Console.WriteLine("Введите число: ");
                number4 = int.Parse(Console.ReadLine());
                if (number4 > 0)
                        {
                            Console.WriteLine("Число положительное!");
                        }
                else if (number4 < 0)
                        {
                            Console.WriteLine("Число отрицательное!");
                        }
                else
                        {
                            Console.WriteLine("Число равно нулю!");
                        }
                        
                if (number4 >= 10 && number4 <= 20)
                        {
                            Console.WriteLine("Число находится в диапазоне!");
                        }
                        else
                        {
                            Console.WriteLine("Число не находится в диапазоне!");
                        }
                        break;
            case 4:
            int number5 = 1;
                while (number5 <= 10)
                        {
                            Console.WriteLine(number5);
                            number5++;
                        }
                        Console.WriteLine("Готово!");
                        break;
            case 5:
                Console.WriteLine("Введите число: ");
                number6 = int.Parse(Console.ReadLine());
                if (number6 % 2 == 0)
                        {
                            Console.WriteLine("Число чётное!");
                        }
                else
                        {
                            Console.WriteLine("Число нечётное!");
                        }
                        break;
            case 0: 
                Console.WriteLine("Программа завершена.");
                break;

            default:
                 Console.WriteLine("Ошибка: неверное значение!");
                 break;
            }
            }
        }
    }
}