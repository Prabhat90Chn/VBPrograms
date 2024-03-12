using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObject
{
    internal class Employee
    {
        public int id;
        public String name;
        public float salary;

       public Employee()
        {
            Console.WriteLine("This is Default Constructor");
        }
        public Employee(int id, String name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            Console.WriteLine("Parameterised Constructor Invoked");
        }
        public void Display()
        {
            Console.WriteLine("Id = " + id + " " + "Name = " +name+" "+" Salary = "+ salary);
        }
        
    }
}
