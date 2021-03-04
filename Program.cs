using System;
using System.Collections.Generic;
using System.Text;

namespace NewBasics1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First dog's name: ");
            String dogName = Console.ReadLine();
            Console.WriteLine("Enter first dog's breed: ");
            String dogBreed = Console.ReadLine();

            //Using dog constructor to set name and breed
            Dog firstDog = new Dog(dogName, dogBreed);
            Dog secondDog = new Dog();

            firstDog.sayBau();
            secondDog.sayBau();

            Console.WriteLine("Enter Second dog's name: ");
            dogName = Console.ReadLine();
            Console.WriteLine("Enter first dog's breed: ");
            dogBreed = Console.ReadLine();

            //using properties to set name and breed
            secondDog.Name = dogName;
            secondDog.Breed = dogBreed;

            Console.WriteLine("the name is:" + secondDog.Name);
            Console.WriteLine("the breed is:" + secondDog.Breed);

            Console.ReadKey();
        }
    }
}
