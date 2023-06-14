using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9p
{
    internal interface ISetting
    {
          int CountAttempts { get; } //Количество попыток
          int RangeOfNumbers { get; } //Диапазон чисел

    }
}
