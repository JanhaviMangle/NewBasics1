using System;
using System.Collections.Generic;
using System.Text;

namespace NewBasics1
{
    class ReadOnlyDemo
    {
        private readonly String name;
        private readonly String location;
        private readonly int age;

        public ReadOnlyDemo()
        {
            name = "Gosling";
            location = "Blr";
            age = 25;
                
        }

        void setDetails() //Complilation error
        {
            /*name = "Gosling";
            location = "Blr";
            age = 25;*/
        }

        void display()
        {
            Console.WriteLine("hello {0}, aged {1} from{2}" +
                name, age, location);
        }
        static void Main()
        {
            ReadOnlyDemo r1 = new ReadOnlyDemo();
            r1.display();
        }
    }
}
