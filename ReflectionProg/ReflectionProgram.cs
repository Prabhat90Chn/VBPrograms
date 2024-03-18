using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace ReflectionProg
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        
        public Student()
        {
            RollNo = 0;
            Name = string.Empty;
        }
        public Student(int rollNo, string name)
        {
            RollNo = rollNo;
            Name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine("Rollno :{0}", RollNo);
            Console.WriteLine("Name :{0}",Name);
        }
    }

    internal class ReflectionProgram

    {
        static void Main(string[] args)
        {
            Assembly executing = Assembly.GetExecutingAssembly();

             Type[] types = executing.GetTypes();
            
            foreach (Type t in types)
            {
                Console.WriteLine(t.Name);
            
                MethodInfo[] methods = t.GetMethods();
                foreach (MethodInfo m in methods) 
                { 
                Console.WriteLine("Methods : {0}",m.Name);
                    
                ParameterInfo[] para = m.GetParameters();
                    foreach (ParameterInfo p in para) 
                    {
                        Console.WriteLine("Parameters : {0} Types : {1}", p.Name, p.ParameterType);
                    }

                }
            }
        }
    }
}
