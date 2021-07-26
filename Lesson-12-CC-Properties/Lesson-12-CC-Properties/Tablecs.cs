using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_CC_Properties
{
    public class Table
    {
        public /*readonly*/ string Manufacturer { get; } = "table4u";//readonly

        private readonly int legs;
        public int Legs { get { return legs; } }

        public Table(string manufacturer, int legs)
        {
            Manufacturer = manufacturer;
            this.legs = legs;
        }

        public void Foo()
        {
            //Manufacturer = "table4me";
        }
    }
}
