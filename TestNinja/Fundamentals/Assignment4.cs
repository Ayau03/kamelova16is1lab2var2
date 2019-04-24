using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public  class Assignment4
    {
        public string TypeOfTicket { get; set; }
        public void AgeOfPeople(int a)
        {
            if (a <= 15) TypeOfTicket = "детский";
            else TypeOfTicket = "взрослый";
        }
    }
}
