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
                //IRandomNumberGeneration numberGeneration = new RandomNumberGeneration();
                IRandomNumberGeneration numberGeneration = new RandomNumberGenerationChet();
                ISetting setting = new Settings();

                //Генерация числа
                numberGeneration.Generation(setting);

                //Вывод правил
                Console.WriteLine
                    (
                    $"\nПривет!\n" +
                    $"Я загадал число от 0 до {setting.RangeOfNumbers}\n" +
                    $"У вас есть {setting.CountAttempts} попыток.\n" +
                    "Попробуйте угадать число.\n"
                    );



                while (true)
                {

                    var numberUser = int.TryParse(Console.ReadLine(), out int result);
                    //Проверка что введено число
                    if (numberUser)
                    {
                        var comand = checking.Check(result, numberGeneration, setting);

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
