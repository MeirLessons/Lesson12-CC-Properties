using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_CC_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 15;//setter => p.SetAge(15);
            int pAge = p.Age;//getter

            p.Id = 13;
            Console.WriteLine(p.Id);

            Console.WriteLine(p.Name);
            p.Name = "Meir";
        }
    }
}
