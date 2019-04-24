using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
   public class Assignment1
    {
        public string PositiveNegativeNumbers(int arg)
        {
            if (arg > 0)
                return $"Число{arg}положительное";
            if (arg < 0)
            return $"Число {arg}отрицательное";
            return $"Число{arg}равно нулю";
        }
    }
}
