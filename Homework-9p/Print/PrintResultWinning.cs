using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_9p.Interfese;

namespace Homework_9p.Print
{
    internal class PrintResultWinning : IPrintRezult
    {
        public void PrintRezult()
        {
            Console.WriteLine("Поздравляю вы угадали!");
        }
    }
}
