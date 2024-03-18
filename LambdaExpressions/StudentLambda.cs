using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpressions
{
    internal class StudentLambda
    {
        public void Display()
        {
            List<StudentClass> students = new List<StudentClass> {
                new StudentClass() { rollNo = 1, name="A" },
                new StudentClass() { rollNo = 3, name="C" },
                new StudentClass() { rollNo = 4, name="D" },
                new StudentClass() { rollNo = 5, name="E" },
                new StudentClass() { rollNo = 6, name="F" },
                new StudentClass() { rollNo = 2, name="B" }
                };
            List<StudentClass> newDetail = students.OrderBy(x => x.rollNo).ToList();
            IEnumerator<StudentClass> e = newDetail.GetEnumerator();
            while ( e.MoveNext()) 
            {
                Console.WriteLine("{0}, {1}",e.Current.rollNo,e.Current.name);
            };
            Func<int, int> sqaure = x => x * x;
            Console.WriteLine(sqaure);
            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}";
                Console.WriteLine(greeting);
            };
            greet("hi");
        }
        
    }
}
