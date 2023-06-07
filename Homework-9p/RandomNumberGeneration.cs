using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9p
{
    internal class RandomNumberGeneration : Settings
    {
        public int RandomNumber { get; set; }

        Random random = new Random();

        public void Generation()
        {
            RandomNumber = random.Next(0, RangeOfNumbers);
        }
    }
}
