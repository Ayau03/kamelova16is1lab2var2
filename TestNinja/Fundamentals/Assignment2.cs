using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment2
    {
        public IEnumerable<int> GetNumbers(int a, int b)
        {
            if ((a + b) % 2 == 0)
            for (var i = 0; i <= a; i++)
                    yield return i;
            else for (var i = 0; i <= b; i++)
                    yield return i;
        }
    }

}
