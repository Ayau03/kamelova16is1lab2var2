using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment2
    {
        public IEnumerable<int> GetNumbers(int a, int b) //данная функция принимает два значения и считает их сумму
        {
            if ((a + b) % 2 == 0)  //если сумма четная, то формируется массив чисел до первого аргумента - а
            for (var i = 0; i <= a; i++)
                    yield return i;
            else for (var i = 0; i <= b; i++) //иначе массив чисел формируется до второго аргумента - b
                    yield return i;
        }
    }

}
//Выбор данной функции обусловлен тем, что, задается простое условие, при выполнении или невыполнении которого формируются различные массивы