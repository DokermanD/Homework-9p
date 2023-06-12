using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_9p.Interfese;
using Homework_9p.Print;

namespace Homework_9p
{
    internal class CheckingNumber : ICheckingNumber
    {
        PrintResultLess resultLess = new PrintResultLess();
        PrintResultMore resultMore = new PrintResultMore();
        PrintResultWinning resultWinning = new PrintResultWinning();

        int attempts = 0;
        string ret = string.Empty;
        public string Check(int numberUser, IRandomNumberGeneration numberGeneration )
        {
            //Подсчёт количества попыток
            attempts++;


            if (numberUser > numberGeneration.RandomNumber) // Если больше
            {
                resultMore.PrintRezult();
            }
            else if (numberUser < numberGeneration.RandomNumber) // Если меньше
            {
                resultLess.PrintRezult();
            }
            else // Если угадали
            {
                resultWinning.PrintRezult();
                ret = PrintMenu();
            }

            //Проверка количества попыток
            if (attempts >= Settings.CountAttempts)
            {
                Console.WriteLine(
                    "***************************\n" +
                    "Вы использовали все попытки\n" +
                    "***************************\n");

                ret = PrintMenu();
            }

            return ret;
        }

        private string PrintMenu()
        {
            Console.WriteLine(                   
                    "\nПопробовать ещё, введите - 1\n" +
                    "Выйти из игры, введите - 2"
                    );

            var comand = Console.ReadLine();

            if (comand == "2") Environment.Exit(0);
            if (comand == "1") ret = "1";

            return ret;
        }
    }
}
