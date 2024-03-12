using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Employee
    {
        public int id;
        public string name; 
        public Address address;
        public Employee(int id, string name,Address address) {
            this.id = id;
            this.name = name;   
            this.address = address;
        }  
        public void display()
        {
            Console.WriteLine(address.addLine+" "+address.City + " " +address.State + " " +id + " " +name);
        }
        public static void AddressMain()
        {
            Address a1 = new Address("G-13, Sec-3", "Noida", "UP");
            Employee e1 = new Employee(1, "Sonoo", a1);
            e1.display();
        }
    }
}
