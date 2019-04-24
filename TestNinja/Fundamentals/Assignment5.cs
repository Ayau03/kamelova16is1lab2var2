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

        DateTime date1 = new DateTime();
        public void SetDate(int y, int m, int d, int h, int mm, int s)  //данный метод принимает аргументы для установления даты
        {
            if (h > 24) throw new ArgumentException(); //если аргумент h, который устанавливает часы, больше 24, то вызывается исключение

            date1 = new DateTime(y, m, d, h, mm, s);
        }
    }
}
