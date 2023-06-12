using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Homework_9p.Interfese;

namespace Homework_9p
{
    internal class StartGame
    {
        public static void Start()
        {
            while (true)
            {
                //Интерфейсы
                ICheckingNumber checking = new CheckingNumber();
                IRandomNumberGeneration numberGeneration = new RandomNumberGeneration();

                //Генерация числа
                numberGeneration.Generation();

                //Вывод правил
                Console.WriteLine
                    (
                    $"\nПривет!\n" +
                    $"Я загадал число от 0 до {Settings.RangeOfNumbers}\n" +
                    $"У вас есть {Settings.CountAttempts} попыток.\n" +
                    "Попробуйте угадать число.\n"
                    );



                while (true)
                {

                    var numberUser = int.TryParse(Console.ReadLine(), out int result);
                    //Проверка что введено число
                    if (numberUser)
                    {
                        var comand = checking.Check(result, numberGeneration);

                        if (comand == "1") break;

                    }
                    else
                    {
                        Console.WriteLine("Введите пожалуйста число!");
                    }
                }
            }
        }
         
    }
}
