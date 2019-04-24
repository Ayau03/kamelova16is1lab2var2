using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public  class Assignment4
    {
        public string TypeOfTicket { get; set; } //объект тип билета
        public void AgeOfPeople(int a) 
        {
            if (a <= 15) TypeOfTicket = "детский"; //если возраст меньше 15, то тип билета устанавливается Детский
            else TypeOfTicket = "взрослый"; // иначе тип билета Взрослый
        }
    }
}
