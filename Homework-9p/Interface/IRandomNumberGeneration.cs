using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9p.Interfese
{
    internal interface IRandomNumberGeneration
    {
        public int RandomNumber { get; set; }
        public void Generation(ISetting setting);
    }
}
