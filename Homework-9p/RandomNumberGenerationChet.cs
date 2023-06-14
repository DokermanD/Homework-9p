using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_9p.Interfese;

namespace Homework_9p
{
    internal class RandomNumberGenerationChet : IRandomNumberGeneration 
    {
        public int RandomNumber { get; set; }

        Random random = new Random();

        public void Generation(ISetting setting)
        {
            RandomNumber = random.Next(0, setting.RangeOfNumbers);

            if (RandomNumber % 2 == 1) RandomNumber++;

        }

       
    }
}
