using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person //adding : Person inhertits the class  
    {
        public int Id { get; set; }
        public override void SayName() //implementing sayname method 
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }
    }
}
