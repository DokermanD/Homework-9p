namespace Homework_9p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Генерация числа
                RandomNumberGeneration numberGeneration = new RandomNumberGeneration();
                numberGeneration.Generation();

                //Вывод правил
                Console.WriteLine
                    (
                    $"\nПривет!\n" +
                    $"Я загадал число от 0 до {numberGeneration.RangeOfNumbers}\n" +
                    $"У вас есть {numberGeneration.CountAttempts} попыток.\n" +
                    "Попробуйте угадать число.\n"
                    );

               
                CheckingNumber checking = new CheckingNumber();
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