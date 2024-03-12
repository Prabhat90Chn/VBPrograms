using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObject
{
    internal class PropertiesClass
    {
        private string name;
        private string address;
        private int counter;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
        public String Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value+" city";
            }
        }
        public int Counter
        {
            get 
            { 
            return ++counter;
            }   
            
        }

        public static void PropertiesMain()
        {
            PropertiesClass p= new PropertiesClass();
            p.Name = "Abc";
            Console.WriteLine("Name set is = "+p.Name);
            p.Address = "Mumbai";
            Console.WriteLine("Adress is = "+p.Address);
            Console.WriteLine("Total counter is = "+p.Counter);
        }

    }
}
