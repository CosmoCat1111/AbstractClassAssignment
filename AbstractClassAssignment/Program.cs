using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee Sam = new Employee() { firstName = "Sample", lastName = " Student" };
            //instantiate employee object
            Sam.SayName(); //call the sayname method 
            Console.ReadLine();
        }
    }
}
