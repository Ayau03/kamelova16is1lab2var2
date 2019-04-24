using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
   public class Assignment3
    {
        public ActionResults GetDay(string day)  //функция, которая проверяет дни недели
        {
            if (day == "saturday" || day == "sunday") //если аргумент Суббота или Воскресенье, то возвращается функция Выходные
                return new Weekends();

            return new Weekdays(); //иначе возвращается Будни
        }
    }
    public class ActionResults
    {
    }
    public class Weekdays : ActionResults
    {
    }
    public class Weekends: ActionResults
    {
    }
}
