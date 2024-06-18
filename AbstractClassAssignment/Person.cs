using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person
    {
        //2 properties 
        public string firstName { get; set; }
        public string lastName { get; set; }
        //method SayName()
        public abstract void SayName();
    }
}
