using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Address
    {
        public String addLine, City, State;
        public Address(string addLine, string City, string State) { 
        this.addLine = addLine;
            this.City = City;   
            this.State = State;
        }
    }
}