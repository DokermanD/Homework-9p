using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9p.Interfese
{
    internal interface ICheckingNumber
    {
        public string Check(int numberUser, IRandomNumberGeneration numberGeneration, ISetting setting);
    }
}
