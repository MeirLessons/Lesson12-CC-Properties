using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_CC_Properties
{
    public class Person
    {
        //Field
        private int age;
        public int Age 
        {
            get
            { 
                return age;
            }
            set
            {
                if(value > 0 && value < 121)
                    age = value;
                else
                    Console.WriteLine("Value bla bla");
            }
        }

        private readonly string name  = "dan";
        public string Name { get { return name; } }

        public string LName { set; protected get; }

        //private long id_backing_field;
        //public long Id2 { get { return id_backing_field; } set { id_backing_field = value } }
        public long Id { get; set; }

        public string Car { get; } = "mazda";

        private readonly int ii;
        public Person()
        {
            Car = "Buick";
            Name = "moshe";

        }
        public Person(int id)
        {
            Name = "moshe";
            Id = id;
        }
        //public int GetAge()
        //{
        //    return age;
        //}

        //public void SetAge(int value)
        //{
        //    age = value;
        //}
    }
}
