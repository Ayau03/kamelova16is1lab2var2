using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
   public class Assignment1
    {
        public string PositiveNegativeNumbers(int arg)  //функция для проверки аргумента на основе знака
        {
            if (arg > 0) //если число больше 0, то функция возвращает строку, что число "аргумент" положительное
                return $"Число{arg}положительное";
            if (arg < 0)  //если число меньше 0, то функция возвращает строку, что число "аргумент" отрицательное
                return $"Число {arg}отрицательное";
            return $"Число{arg}равно нулю"; // если число равно нулю, то возвращается строка число "аргумент" равно нулю
        }
    }
}
