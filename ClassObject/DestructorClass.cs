using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObject
{
    internal class DestructorClass
    {
        public DestructorClass() {
            Console.WriteLine("Default Constrctor");
        }
        public DestructorClass(string name)
        {
            Console.WriteLine("Parameterized Constrctor");
        }
        ~DestructorClass()
        {
            Console.WriteLine("Destructor Invoked");
        }
        
    }
 }   
    
