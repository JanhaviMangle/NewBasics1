using System;
using System.Collections.Generic;
using System.Text;

namespace NewBasic
{
   public class Dog
    {
        private string name;
        private string breed;

        public Dog()
        {
            this.name = "Balkan";
            this.breed = "Street Excellent";
        }

        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Breed { get { return breed; } set { breed = value; } }
       
        public void sayBau()
        {
            Console.WriteLine("{0}, with breed {1}  said: Bauuuuuuuuuuu", name);
        }
    }
}
