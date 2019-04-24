using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
   public class Assignment5
    {
        public int Result { get; set; }

        public int DivideNumbers(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();

            Result =  a / b;
            return Result;
        }
    }
}
