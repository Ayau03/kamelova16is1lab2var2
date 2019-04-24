using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
   public class Assignment3
    {
        public ActionResults GetDay(string day)
        {
            if (day == "saturday" || day == "sunday")
                return new Weekends();

            return new Weekdays();
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
